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
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */
    /*
     * The numbers are 1,2 3,4  and5 . Calculate the following sums using four of the five integers:

1.Sum everything except 1, the sum is 2+3+4+5=14.
2.Sum everything except 2, the sum is 1+3+4+5=13.
3.Sum everything except 3, the sum is 1+2+4+5=12.
4.Sum everything except 4, the sum is 1+2+4+5=11.
5.Sum everything except 5, the sum is 1+2+3+4=10.
    */
    public static void miniMaxSum(List<int> arr)
    {
        arr.Sort();

         double Min = 0, Max = 0;
        /*
        for(int i=0;i<arr.Count-1;i++)
        {
            Min = Min + arr[i];
        }

        for (int i = 1; i < arr.Count; i++)
        {
            Max = Max + arr[i];
        }
        */

        for (int i = 0; i < arr.Count;i++)
        {
            if(i!=arr.Count-1)
            {
                Min = Min + arr[i];
            }
            if(i!=0)
            {
                Max = Max + arr[i];
            }


        }
        Console.WriteLine(Min + " " + Max);
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = new List<int> { 1, 2, 3, 4, 5 };

        Result.miniMaxSum(arr);
    }
}
