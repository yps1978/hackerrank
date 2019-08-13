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

    // Complete the dayOfProgrammer function below.
    static string dayOfProgrammer(int year) {
        DateTime day;
        var gregorianLeapYear = year % 400 == 0 || (year % 4 == 0 && year % 100 != 0);
        var julianLeapYear = year % 4 == 0;
        if (year < 1918)
            day=new DateTime(year,1,1).AddDays(julianLeapYear && year%100==0 ?254 : 255);
        else if (year == 1918)
            day = new DateTime(year, 2, 14).AddDays(255 - 31);
        else
            day = new DateTime(year, 1, 1).AddDays(255);

        return day.ToString("dd.MM.yyyy");

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int year = Convert.ToInt32(Console.ReadLine().Trim());

        string result = dayOfProgrammer(year);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
