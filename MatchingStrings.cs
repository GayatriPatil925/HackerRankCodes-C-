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
     * Complete the 'matchingStrings' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. STRING_ARRAY strings
     *  2. STRING_ARRAY queries
     */

    public static List<int> matchingStrings(List<string> strings, List<string> queries)
    {
        List<int> result = new List<int>();

        for (int i=0; i<queries.Count;i++)
        {
           int temp = 0;
            for(int j=0; j<strings.Count;j++)
            {
                if(queries[i]==strings[j])
                {
                    temp++;
                }
            }

            result.Add(temp);
        }
      /*  foreach (var i in result)
        {
            Console.WriteLine(i);
        }
      */
        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        

        
        List<string> strings = new List<string> { "ab", "ab","abc"};
        List<string> queries = new List<string> { "ab", "abc", "bc" };

        

        List<int> res = Result.matchingStrings(strings, queries);

        
    }
}
