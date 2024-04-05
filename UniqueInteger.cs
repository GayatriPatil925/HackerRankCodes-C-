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
     * Complete the 'lonelyinteger' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int Lonelyinteger(List<int> a)
    {
        int extra = 0;
        for(int i=0;i<a.Count;i++)
        {
            int temp = 0;
            for(int j=0;j<a.Count;j++)
            {
               
                    if (a[i] == a[j])
                    {
                        temp++;
                    }
            }
            if(temp == 1)
            {
                return a[i];
            }
        }

        return extra;
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        

        List<int> a = new List<int> { 1,2,3,4,4,3,2,1};

        int result = Result.Lonelyinteger(a);


        Console.WriteLine(result);
        
    }
}
