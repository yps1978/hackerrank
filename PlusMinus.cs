using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        double f1=0, f2=0, f3=0;
        for (var i=0; i<n; i++)
        {
            if (arr[i]>0)
                f1++;
            else if (arr[i]<0)
                f2++;
                else
                f3++;
        }
        Console.WriteLine((f1/n).ToString("0.000000"));
        Console.WriteLine((f2/n).ToString("0.000000"));
        Console.WriteLine((f3/n).ToString("0.000000"));
    }
}
