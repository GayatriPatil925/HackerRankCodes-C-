using System;
using System.Linq;

class Stringreverse
{
    

    static void Main(string[] args)
    {
        Console.WriteLine("Enter String :-");
        string input= (Console.ReadLine()).ToUpper();
        var chararr = input.ToCharArray();
        var uchar = input.Distinct().ToArray();
   //The Distinct method in C# is used to remove duplicate elements from a collection
        

       foreach(char i in uchar)
        {
            Console.WriteLine(i);
        }

        for(int i=0; i<uchar.Length;i++)
        {
            int temp = 0;
            for (int j=0;j<chararr.Length;j++)
            {
                
                if(uchar[i] == chararr[j])
                {
                  temp++;
                }
            }

            string n= $"For {uchar[i]} Occurance is {temp}";
            Console.WriteLine(n);

            Console.WriteLine(string.Format("For {0} occurrence is {1}", uchar[i], temp));
        }
    }
}
