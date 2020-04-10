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
    static readonly int[,] mov = { { 0, 0 }, { 0, 1 }, { 0, 2 }, { 1, 1 }, { 2, 0 }, { 2, 1 }, { 2, 2 } };

    // Complete the hourglassSum function below.
    static int hourglassSum(int[][] arr) {
        var max = int.MinValue;
        for (int i = 0; i < arr.Length; i++)
            for (int j = 0; j < arr[i].Length; j++)
            {
                var hourglass = getHourglass(arr, i, j);
                if (hourglass > max)
                    max = hourglass;
            }

        return max;
    }

    static int getHourglass(int[][] arr, int x, int y)
    {
        var sum = 0;
        for (int i = 0; i < mov.GetLength(0); i++)
        {
            if (x + mov[i, 0] > arr.Length - 1)
                return int.MinValue;

            if (y + mov[i, 1] > arr[x].Length - 1)
                return int.MinValue;

            sum += arr[x + mov[i, 0]][y + mov[i, 1]];
        }
        return sum;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++) {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = hourglassSum(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
