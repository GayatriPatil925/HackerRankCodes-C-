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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        double a=0, b=0, c=0;

        for(int i=0;i<arr.Count;i++)
        {
            if(arr[i]<0)
            {
                a++;
            }
            else if(arr[i]>0)
            {
                b++;
            }
            else
            {
                c++;
            }
        }


       
       


        Console.WriteLine((b / arr.Count).ToString("f6"));
        Console.WriteLine((a / arr.Count).ToString("f6"));
        Console.WriteLine((c / arr.Count).ToString("f6"));


    }

}

class Solution
{
    public static void Main(string[] args)
    {


        List<int> arr = new List<int> { -4, 3, -9, 0, 4, 1 };

        Result.plusMinus(arr);
    }
}
