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

    // Complete the findMedian function below.
    static int findMedian(int[] arr) {
        var sorted = quickSort(arr, 0, arr.Length - 1);
        return sorted[arr.Length / 2];
    }

    static int partition(int[] arr, int start, int end)
    {
        int pivot = arr[end];

        // index of smaller element 
        int i = (start - 1);
        for (int j = start; j < end; j++)
        {
            if (arr[j] <= pivot)
            {
                i++;

                // swap
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        // swap
        int temp1 = arr[i + 1];
        arr[i + 1] = arr[end];
        arr[end] = temp1;

        return i + 1;
    }

    static int[] quickSort(int[] arr, int start, int end)
    {
        if (start < end)
        {
            int pi = partition(arr, start, end);

            quickSort(arr, start, pi - 1);
            quickSort(arr, pi + 1, end);
        }
        return arr;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int result = findMedian(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
