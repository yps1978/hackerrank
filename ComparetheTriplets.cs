using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_a0 = Console.ReadLine().Split(' ');
        int a0 = Convert.ToInt32(tokens_a0[0]);
        int a1 = Convert.ToInt32(tokens_a0[1]);
        int a2 = Convert.ToInt32(tokens_a0[2]);
        string[] tokens_b0 = Console.ReadLine().Split(' ');
        int b0 = Convert.ToInt32(tokens_b0[0]);
        int b1 = Convert.ToInt32(tokens_b0[1]);
        int b2 = Convert.ToInt32(tokens_b0[2]);
        int aScore= (a0>b0 ? 1:0) + (a1>b1 ? 1:0) + (a2>b2 ? 1:0);
        int bScore= (a0<b0 ? 1:0) + (a1<b1 ? 1:0) + (a2<b2 ? 1:0);
        Console.WriteLine(string.Format("{0} {1}", aScore, bScore));
    }
}
