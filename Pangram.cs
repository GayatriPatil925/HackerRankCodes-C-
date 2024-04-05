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
     * Verify whether input sentence contains all the characters from ABCD.
     */

    public static string pangrams(string s)
    {
        string temp2 = " ";
        var s1=s.ToLower();
        string input = "abcdefghijklmnopqrstuvwxyz";
        var x=input.ToCharArray();
        var st1=s1.ToCharArray();

        int  temp = 0;

        for (int i = 0; i <x.Length; i++) 
        {
            int count = 0;
            for(int j = 0;j<st1.Length; j++)
            {
                if (x[i] == st1[j])
                {
                    count++;
                }
            }
            Console.WriteLine(x[i]+"count is "+count);
            if (count != 0)
            {
                temp++;
            }
        }
        if(temp == 26)
        {
            temp2 = "pangram";
        }
        else
        {
            temp2= "not pangram";
        }

       return temp2;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        

        string s = "We promptly judged antique ivory buckles for the prize";

        string result = Result.pangrams(s);

        
    }
}
