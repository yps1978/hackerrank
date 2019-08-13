using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string time = Console.ReadLine();
        var date=DateTime.Parse(time);
        Console.WriteLine(date.ToString("HH:mm:ss"));
    }
}
