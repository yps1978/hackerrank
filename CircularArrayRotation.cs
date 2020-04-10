using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        var input1=Console.ReadLine().Split(' ');
        var n=int.Parse(input1[0]);
        var k=int.Parse(input1[1]);
        var q=int.Parse(input1[2]);
        var input2=Console.ReadLine().Split(' ');
        var arr=Array.ConvertAll(input2, s=>int.Parse(s));
        var newArr=new int[n];
        var newK = k % n;
        
        for (var i=0; i<newK; i++)
            newArr[i]=arr[n-newK+i];
        for (var i=newK; i<n; i++)
            newArr[i]=arr[Math.Abs(newK-i)];
        
        var output=new int[q];
        for (var i=0; i<q; i++)
            output[i]=int.Parse(Console.ReadLine());
        
        for (var i=0; i<q; i++)
            Console.WriteLine(newArr[output[i]]);
    }
}