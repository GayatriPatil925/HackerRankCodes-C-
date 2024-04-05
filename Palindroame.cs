using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s,rev="";
            Console.WriteLine("Enter a String");
            s= Console.ReadLine();

            for(int i = s.Length-1; i >=0; i--)
            {
                rev = rev + s[i];
                    
            }
            Console.WriteLine(rev);
            if(s==rev)
            {
                Console.WriteLine("it is palindrome");
            }
            else
            {
                Console.WriteLine("it is not palindrome");
            }
        }
    }
}
