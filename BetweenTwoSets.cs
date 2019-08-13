using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int m = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        string[] b_temp = Console.ReadLine().Split(' ');
        int[] b = Array.ConvertAll(b_temp,Int32.Parse);
        
        var total = 0;
            var maxlen = Math.Max(n, m);
            //assuming the elements are sorted
            for (var x = a[n - 1]; x <= b[0]; x++)
            {

                var goodx = true;
                for (var j = 0; j < maxlen; j++)
                {
                    if (j < n && x % a[j] != 0)
                    {
                        goodx = false;
                        break;
                    }
                    if (j < m && b[j] % x != 0)
                    {
                        goodx = false;
                        break;
                    }
                }
                total += (goodx ? 1 : 0);
            }
            Console.WriteLine(total);
    }
}
