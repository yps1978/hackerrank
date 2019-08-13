using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        for (var i=0; i<n; i++)
        {
            for (var j=0;j<n;j++)
            {
                Console.Write(n - j - 1 > i ? " " : "#");
            }
            Console.WriteLine();
        }
    }
}
