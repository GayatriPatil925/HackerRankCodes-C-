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
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        int temp1 = 0 ,temp2=0 ;
        int result;
        for(int i=0;i<arr.Count;i++)
        {
            temp1 += arr[i][i];
            //Console.WriteLine(arr[i][i]);
        }
        //Console.WriteLine(temp1);
        int temp3 = 0;
        for (int i=arr.Count-1;i>=0;i--)
        {
            
            temp2 += arr[temp3][i];
            //Console.WriteLine(arr[temp3][i]);
            temp3++;
        }
        //Console.WriteLine(temp3);

        result = Math.Abs(temp1 - temp2);

        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {


        List<List<int>> arr = new List<List<int>> {new List<int> { 11, 2, 4 }, new List<int>{ 4, 5, 6 }, new List<int>{ 10, 8, -12 } };
        
        int result = Result.diagonalDifference(arr);

        
    }
}

