using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the gradingStudents function below.
     */
    static int[] gradingStudents(int[] grades) {
        var adjustedGrades=new int[grades.Length];
        for (int i=0; i<grades.Length; i++)
        {
            adjustedGrades[i]=grades[i];
            if (grades[i]>=38)
            {
                var div=grades[i] / 5;
                var mod=grades[i] % 5;
                if (mod>0 && (div+1)*5 - grades[i]<3)
                    adjustedGrades[i]=(div+1)*5;
            }
        }
        return adjustedGrades;
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] grades = new int [n];

        for (int gradesItr = 0; gradesItr < n; gradesItr++) {
            int gradesItem = Convert.ToInt32(Console.ReadLine());
            grades[gradesItr] = gradesItem;
        }

        int[] result = gradingStudents(grades);

        tw.WriteLine(string.Join("\n", result));

        tw.Flush();
        tw.Close();
    }
}
