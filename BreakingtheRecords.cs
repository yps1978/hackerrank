using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] score_temp = Console.ReadLine().Split(' ');
        int[] score = Array.ConvertAll(score_temp,Int32.Parse);
        // your code goes here
        int highest = score[0], highcount = 0,
                lowest = score[0], lowcount = 0;

            for (var i = 1; i < n; i++)
            {
                if (score[i] > highest)
                {
                    highcount++;
                    highest = score[i];
                }
                if (score[i] < lowest)
                {
                    lowcount++;
                    lowest = score[i];
                }
            }
            Console.WriteLine("{0} {1}", highcount, lowcount);
    }
}
