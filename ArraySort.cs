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

    public static void Array_Sort(List<int> arr)
    {

        //Array Sorting
        for (int i = 0; i < arr.Count - 1; i++)
        {
            for (int j = 0; j < arr.Count-i-1; j++)
            {
                int temp = 0;
                if (arr[j] > arr[j+1])
                {
                    temp=arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                }
            }
        }
        /*
         *Another Way
        //Sort values using LINQ
        var SortedValues = from val in arr
                           orderby val
                           select val;
        //arr.OrderBy(x => x);
        */

        foreach (var i in arr)
        {
            Console.WriteLine(i);
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = new List<int> { 9, 6, 3, 2, 5 };

        Result.Array_Sort(arr);
    }
}
