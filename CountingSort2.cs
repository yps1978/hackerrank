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

    // Complete the countingSort function below.
    static int[] countingSort(int[] arr)
    {
        var counts = new int[100];
        for (int i = 0; i < arr.Length; i++)
            counts[arr[i]]++;

        var sortedList = new List<int>();
        for (int i = 0; i < counts.Length; i++)
            for (int j = 0; j < counts[i]; j++)
            {
                sortedList.Add(i);
            }

        return sortedList.ToArray();
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = Console.Out;
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        int[] result = countingSort(arr);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
