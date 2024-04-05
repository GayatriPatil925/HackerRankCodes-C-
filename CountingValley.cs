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
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */

    public static int countingValleys(int steps, string path)
    {
        int Sealevel = 0, temp = 0;
        var input = path.ToCharArray();

        for (int i = 0; i < steps; i++)
        {
            if (input[i] == 'U')
            {
                Sealevel++;
                if (Sealevel == 0)
                {
                    temp++;
                }
            }
            else
            {
                Sealevel--;
            }
        }

        //Console.WriteLine(temp);
        return temp;
    }

}

class Solution
{
    public static void Main(string[] args)
    {


        int steps = 8;

        string path = "UDDDUDUU";

        int result = Result.countingValleys(steps, path);


    }
}

