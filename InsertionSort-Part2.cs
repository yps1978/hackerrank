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

    static int[] insertionSort1(int n, int[] arr)
    {
        var i = n - 1;
        var elem = arr[i];
        while (i > 0)
        {
            i--;
            if (arr[i] > elem)
                arr[i + 1] = arr[i];
            else
            {
                arr[i + 1] = elem;
                return arr;
            }
        }
        //@here means that position is first
        arr[i] = elem;

        return arr;
    }
    // Complete the insertionSort2 function below.
    static void insertionSort2(int n, int[] arr) {
        var i = 0;
        while (i < n - 1)
        {
            i++;
            if (arr[i] < arr[i - 1])
                arr = insertionSort1(i + 1, arr);
            Console.WriteLine("{0}", string.Join(" ", arr));
        }
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        insertionSort2(n, arr);
    }
}
