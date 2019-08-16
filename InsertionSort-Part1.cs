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

    // Complete the insertionSort1 function below.
    static void insertionSort1(int n, int[] arr) {
        var i = n - 1;
        var elem = arr[i];
        while (i > 0)
        {
            i--;
            if (arr[i] > elem)
            {
                arr[i + 1] = arr[i];
                Console.WriteLine("{0}", string.Join(" ", arr));
            }
            else
            {
                arr[i + 1] = elem;
                Console.WriteLine("{0}", string.Join(" ", arr));
                return;
            }
        }
        //@here means that position is first
        arr[i] = elem;
        Console.WriteLine("{0}", string.Join(" ", arr));
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        insertionSort1(n, arr);
    }
}
