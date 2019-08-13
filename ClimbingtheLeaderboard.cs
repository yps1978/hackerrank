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

    // Complete the climbingLeaderboard function below.
    static int[] climbingLeaderboard(int[] scores, int[] alice)
        {
            int i = 0;
            int lastScore = 0;
            var index = 1;
            var scorePosition = new Dictionary<int, int>();

            while (i < scores.Length)
            {
                if (scores[i] != lastScore)
                {
                    scorePosition[scores[i]] = index++;
                    lastScore = scores[i];
                }
                i++;
            }
            int[] positions = new int[alice.Length];

            for (i = 0; i < alice.Length; i++)
            {
                int start = 0, end = scores.Length - 1;

                while (true)
                {
                    var pivot = start + (end - start) / 2;


                    if (alice[i] < scores[pivot])
                        start = pivot + 1;
                    else if (alice[i] > scores[pivot])
                        end = pivot - 1;
                    else
                    {
                        positions[i] = scorePosition[scores[pivot]];
                        break;
                    }
                    if (start > end)
                    {
                        positions[i] = scorePosition[scores[pivot]]
                         + (alice[i] > scores[pivot] ? 0 : 1);
                        break;
                    }
                }
            }

            return positions;
        }


    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int scoresCount = Convert.ToInt32(Console.ReadLine());

        int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
        ;
        int aliceCount = Convert.ToInt32(Console.ReadLine());

        int[] alice = Array.ConvertAll(Console.ReadLine().Split(' '), aliceTemp => Convert.ToInt32(aliceTemp))
        ;
        int[] result = climbingLeaderboard(scores, alice);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
