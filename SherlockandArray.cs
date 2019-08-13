using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        var testCount=Convert.ToInt32(Console.ReadLine());
        var output=new bool[testCount];
        for (var i=0; i<testCount; i++)
        {
            var n=Convert.ToInt32(Console.ReadLine());
            var splitArray=Console.ReadLine().Split(' ');
            var arr = Array.ConvertAll(splitArray, e=>int.Parse(e));
            
            //algorithm here
            var leftSum=new long[n];
            var rightSum=new long[n];
            for (var j=0; j<n; j++)
            {
                var k=n-j-1;
                if (j==0){
                    leftSum[j]=0;
                    rightSum[k]=0;
                }
                else if (j==1){
                    leftSum[j]=arr[j-1];
                    rightSum[k]=arr[k+1];
                }
                else{
                    leftSum[j]=leftSum[j-1]+arr[j-1];
                    rightSum[k]=rightSum[k+1]+arr[k+1];
                }
            }
            for (var j=0; j<n; j++)
            {
                var yes= j==0 ? (rightSum[j] ==0) : (j==n-1 ? leftSum[j]==0 : leftSum[j]==rightSum[j]);
                if (yes)
                    output[i]=true;
            }
        }

        //print output
        for (var i=0; i<testCount; i++)
            Console.WriteLine(output[i] ? "YES" : "NO");

    }
}