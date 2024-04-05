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
     * Complete the 'breakingRecords' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY scores as parameter.
     */

    public static List<int> breakingRecords(List<int> scores)
    {
        List<int> result = new List<int>();
        

        int Min=0, Max=0;
        int LS = scores[0] , MS=scores[0];
        
        for(int i=1; i<scores.Count;i++)
        {
            if(scores[i] < LS)  
            {
                LS = scores[i];
                Min++;
            }
            if(scores[i] > MS)
            {
                MS = scores[i];
                Max++;
            }
            
        }
       // Console.WriteLine(Min);
        //Console.WriteLine(Max);
        
        result.Add(Max);
        result.Add(Min);
        return result;
     
    }

}

class Solution
{
    public static void Main(string[] args)
    {



        List<int> scores = new List<int> { 10, 5 ,20 ,20 ,4, 5 ,2 ,25, 1};
        List<int> result = Result.breakingRecords(scores);

       
    }
}
