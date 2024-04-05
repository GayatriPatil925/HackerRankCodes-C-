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
     * Complete the 'marsExploration' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int marsExploration(string s)
    {
       var s1=s.ToCharArray();
        int c1=0;
        int temp = s1.Length / 3;
        int temp2 = temp * 2;

        for(int i=0; i<s1.Length;i+=3)
        {
            if (s1[i] != 'S')
            {
                c1++;
            }
            if(s1[i+1] !='O')
            {
               c1++;
            }
            if (s1[i+2] != 'S')
            {
                c1++;
            }
        }
        
            Console.WriteLine(c1);
        return c1;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        

        string s = "SOSOOSOSOSOSOSSOSOSOSOSOSOS";

        int result = Result.marsExploration(s);

        
    }
}
