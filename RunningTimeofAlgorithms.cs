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

    // Complete the runningTime function below.
    static int runningTime(int[] arr) {
        var n = 0;
        for (var i = 1; i < arr.Length; i++)
        {
            if (arr[i] < arr[i - 1])
            {
                var j = i - 1;
                var elem = arr[i];
                while (j >= 0 && arr[j] > elem)
                {
                    n++;
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                //@here means that position is first
                arr[j + 1] = elem;
            }
        }
        return n;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int result = runningTime(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
