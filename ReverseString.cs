﻿using System.CodeDom.Compiler;
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

class Solution
{
    public static void Main(string[] args)
    {

        String s = "GirishGaikwad";

        var arrchar = s.ToCharArray();

        string x = string.Empty;

        for (int i = arrchar.Length-1; i>=0;i--)
        {
            x += arrchar[i];
           
        }

        Console.WriteLine(x);
    }
}
