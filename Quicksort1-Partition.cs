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

    // Complete the quickSort function below.
    static int[] quickSort(int[] arr) {
        if (arr.Length <= 1)
            return arr;

        var pivot = arr[arr.Length / 2];
        var left = new List<int>();
        var right = new List<int>();
        for (var i = 0; i < arr.Length; i++)
        {
            if (arr[i] < pivot)
                left.Add(arr[i]);
            else if (arr[i] > pivot)
                right.Add(arr[i]);
        }

        return quickSort(left.ToArray()).Concat(new[] { pivot }).Concat(quickSort(right.ToArray())).ToArray();
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int[] result = quickSort(arr);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
