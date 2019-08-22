using LIDMS.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Serialization;

namespace LIDMS.IO.Parsers
{
    public class JsonParser
    {
        private readonly string _splitterNodeName;
        private List<string> _columnNames;
        private int _reagentInfoCount;

        private object[,] _content;
        private int _rowId = 1;

        private bool[] _nodesVisited;
        private List<string> _missingColumns;

        public JsonParser(string jsonSplitterNodeName)
        {
            _splitterNodeName = jsonSplitterNodeName;
            _reagentInfoCount = 0;
        }

        public object[,] Parse(string jsonData, ref List<string> missingParameters, ref List<string> columnNames)
        {
            _columnNames = columnNames;

            _missingColumns = new List<string>();
            _content = new object[500, _columnNames.Count];

            var json = new JavaScriptSerializer().DeserializeObject(jsonData);

            //new version of json data is single-element, different to previous implementation where multiple patient data was included in a form of array
            if (!(json is Array))
                json = new[] { json };

            try
            {
                TraverseJsonTree("", "", json, false);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            columnNames = _columnNames;

            if (_missingColumns.Any())
            {
                missingParameters = _missingColumns;
                return null;
            }

            var matrix = _content.ResizeArray(_rowId + 1, _columnNames.Count);

            return matrix;
        }

        private void TraverseJsonTree(string path, string key, object json, bool pastSplitter)
        {
            if (json == null) return;

            if (json is Array)
            {
                var array = (Array)json;
                for (var i = 0; i < array.Length; i++)
                {
                    if (key == "")
                        _nodesVisited = new bool[_columnNames.Count];

                    TraverseJsonTree(path, "", array.GetValue(i), pastSplitter);

                    if (key == "")
                        for (int k = 0; k < _nodesVisited.Length; k++)
                            if (!_nodesVisited[k])
                                _missingColumns.Add(_columnNames[k]);

                    if (key == _splitterNodeName)
                    {
                        if (_rowId > 0)
                            ReconcileRows(_rowId - 1, _rowId);

                        if (_rowId < array.Length)
                            _rowId++;
                    }
                }
            }
            else if (json is Dictionary<string, object>)
            {
                var sortedDict = (Dictionary<string, object>)json;
                foreach (var item in sortedDict)
                {
                    var columnId = GetIndex(path + "." + item.Key);

                    if (pastSplitter && item.Value is Array)
                    {
                        if (item.Key == "ReagentInfo")
                            SetReagentInfo(path, (Array)item.Value);
                        else
                            continue;
                    }

                    if (item.Value is Array)
                    {
                        var values = (Array)item.Value;
                        if (values.AllPrimitives())
                        {
                            if (columnId >= 0)
                            {
                                _nodesVisited[columnId] = true;
                                _content[_rowId, columnId] = values.FlattenView();
                            }
                        }
                        else
                        {
                            if (string.Equals(item.Key, _splitterNodeName, StringComparison.CurrentCultureIgnoreCase))
                                pastSplitter = true;

                            TraverseJsonTree(path + "." + item.Key, item.Key, item.Value, pastSplitter);

                            if (string.Equals(item.Key, _splitterNodeName, StringComparison.CurrentCultureIgnoreCase))
                                pastSplitter = false;
                        }
                    }
                    else if (item.Value is Dictionary<string, object>)
                        TraverseJsonTree(path + "." + item.Key, item.Key, item.Value, pastSplitter);
                    else
                    {
                        if (columnId >= 0)
                        {
                            _nodesVisited[columnId] = true;
                            _content[_rowId, columnId] = string.Format("\"{0}\"", item.Value);
                        }
                    }
                }
            }
        }

        public int CompareKeyValuePairs(KeyValuePair<string, object> a, KeyValuePair<string, object> b)
        {
            return a.Value == b.Value
                   || (!(a.Value is Array) && !(b.Value is Array))
                   || (!(a.Value is Array && ((Array)a.Value).Length > 0) && !(b.Value is Array && ((Array)b.Value).Length > 0))
                ? 0
                : (b.Value is Array ? -1 : 1);
        }

        private void SetReagentInfo(string path, Array array)
        {
            if (array == null) return;

            if (array.Length > _reagentInfoCount)
            {
                _content = _content.ResizeArray(_content.GetLength(0), _content.GetLength(1) + ((array.Length - _reagentInfoCount) * 3));
                for (int i = 0; i < array.Length; i++)
                {
                    var idx = _reagentInfoCount + i;
                    var suffix = idx == 0 ? "" : (idx + 1).ToString();
                    _columnNames.AddRange(new[] { string.Format("{0}.Reagent{1}", path, suffix),
                        string.Format("{0}.ReagentLotNo{1}", path, suffix),
                        string.Format("{0}.ReagentSerialNo{1}", path, suffix) });
                }
                _reagentInfoCount = array.Length;
            }

            var startIdx = _content.GetLength(1) - (_reagentInfoCount * 3);
            foreach (var item in array)
            {
                var dictEntry = (Dictionary<string, object>)item;
                _content[_rowId, startIdx] = dictEntry["ReagentName"];
                _content[_rowId, startIdx + 1] = dictEntry["LotNumber"];
                _content[_rowId, startIdx + 2] = dictEntry["SerialNumber"];
                startIdx += 3;
            }
        }

        private void ReconcileRows(int rowSource, int rowDest)
        {
            if (rowSource < 1 || rowDest < 1)
                return;

            for (var i = 0; i < _content.GetLength(1); i++)
            {
                _content[rowDest, i] = _content[rowDest, i] ?? _content[rowSource, i];
                _content[rowSource, i] = _content[rowSource, i] ?? _content[rowDest, i];
            }
        }

        private int GetIndex(string nodePath)
        {
            return _columnNames.IndexOf(nodePath);
        }
    }
}