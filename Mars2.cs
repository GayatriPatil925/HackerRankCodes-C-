using System;

class Solution
{
    static void Main(string[] args)
    {
        var alteredCharCount = 0;
        var sosSignal = "SOS";
        var index = 0;
        var nextChar = Console.Read();
        //special handling for hacker rank execution environment
        //while running on my own computer I compare it with ascii code of enter key which is 13.
        while (nextChar != -1)
        {
            if ((char)nextChar != sosSignal[index++])
                alteredCharCount++;

            if (index % 3 == 0)
                index = 0;
            nextChar = Console.Read();
        }

        Console.WriteLine(alteredCharCount);
    }
}