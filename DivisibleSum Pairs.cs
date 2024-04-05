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
     * Lets say we have an array = [1, 2, 3, 4, 5] and a int k = 5
     * Here we want to get all the pairs in array that are divisible by zero returning.
     * For example: array has values 1, 2, 3, 4, 5
     * we will try to add value at index one with all the remaining values one by one and check whether they are
     * divisible by k i.e 5 or not
     * same thing we will repeat for other values as well
     */

    public static int divisibleSumPairs(int n, int k, List<int> ar)
    {
        int count = 0;
        for(int i=0;i<n-1;i++)
        {
            for(int j=i+1; j<n;j++)
            {
                if((ar[i]+ar[j])%k==0)
                {
                    count++;
                }
            }

        }

        Console.WriteLine(count);

        return count;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = 5;

        int k = 2;

        List<int> ar =new List<int> { 5 ,9 ,10, 7, 4 };

        int result = Result.divisibleSumPairs(n, k, ar);

        
    }
}
