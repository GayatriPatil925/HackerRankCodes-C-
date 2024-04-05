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
     * Complete the 'countingSort' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static List<int> countingSort(List<int> arr)
    {

        int[] a = arr.ToArray();
        int[] b = new int[a.Length];

        for(int i = 0;i< a.Length; i++)
        {
            b[a[i]] += 1;
        }
        /*
        a[0] = 1
            b[a[0]] = b[1] = +1
            b[a[1]] = b[1] = +1
        */
        foreach(int i in b)
        {
            Console.WriteLine(i);
        }
        return b.ToList();
    }

}

class Solution
{
    public static void Main(string[] args)
    {



        List<int> arr = new List<int> { 1, 1, 3, 2, 1 };

        List<int> result = Result.countingSort(arr);

       
    }
}
