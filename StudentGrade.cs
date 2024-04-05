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

class Result
{

    /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> gradingStudents(List<int> grades)
    {
        
        List<int> grades1 = new List<int> ();

        for (int i=0;i<grades.Count;i++)
        {
           if(grades[i]>=38)
            {
                int temp = nextMultipleof5(grades[i]);
                if(temp-grades[i]<3)
                {
                    grades1.Add(temp);
                }
                else if(temp - grades[i] >= 3)
                {
                    grades1.Add(grades[i]);
                }
            }
           else
            {
                grades1.Add(grades[i]);
            }

        }
        
       /* foreach(int i in grades1)
        {
            Console.WriteLine(i);
        }
       */
        return grades1;
    }
    public static int nextMultipleof5(int grade)
    {
       while(grade % 5 !=0)
        {
            grade++;
        }
        return grade;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        


        List<int> grades = new List<int> { 84,29,57};

        
        List<int> result = Result.gradingStudents(grades);

        
    }
}
