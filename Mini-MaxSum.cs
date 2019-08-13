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

    // Complete the miniMaxSum function below.
    static void miniMaxSum(int[] arr) {
        long max=0, min=long.MaxValue, sum=0;
        for (var i=0; i<arr.Length; i++)
        {
            if (arr[i]>max)
                max=arr[i];
            if (arr[i]<min)
                min=arr[i];
            sum+=arr[i];
        }
        Console.WriteLine("{0} {1}", sum-max, sum-min);
    }

    static void Main(string[] args) {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}
