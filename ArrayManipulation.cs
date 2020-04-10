using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the arrayManipulation function below.
    static long arrayManipulation(int n, int[][] queries) {
         long[] points = new long[n + 1];
            long[] ends = new long[n + 1];

            var sorted = queries.ToList().OrderBy(x => x[0]).ToArray();
            long qIndex = 0;
            long increment = 0;
            long maxValue = 0;

            for (var i = 1; i <= n; i++)
            {
                while (qIndex < sorted.Count() && i == sorted[qIndex][0])
                {
                    increment += sorted[qIndex][2];
                    ends[sorted[qIndex][1]] += sorted[qIndex][2];
                    qIndex += 1;
                }
                points[i] += increment;
                if (points[i] > maxValue)
                    maxValue = points[i];

                increment -= ends[i];
            }

            return maxValue;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nm = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);

        int[][] queries = new int[m][];

        for (int i = 0; i < m; i++) {
            queries[i] = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
        }

        long result = arrayManipulation(n, queries);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
