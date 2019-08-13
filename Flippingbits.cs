using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var n = int.Parse(Console.ReadLine());
            var input = new uint[n];
            for (var i = 0; i < n; i++)
                input[i] = uint.Parse(Console.ReadLine());

            for (var i = 0; i < n; i++)
            {
                var bytes = BitConverter.GetBytes(input[i]);
                var bits = new BitArray(bytes);
                var invertedBitArray = new BitArray(bits.Length);
                for (var j = 0; j < bits.Length; j++)
                    invertedBitArray[j] = !bits[j];
                var outBytes = new byte[bytes.Length];
                invertedBitArray.CopyTo(outBytes, 0);
                var outValue=BitConverter.ToUInt32(outBytes, 0);
                Console.WriteLine(outValue);
            }
    }
}