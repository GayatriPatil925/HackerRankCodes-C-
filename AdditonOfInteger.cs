using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Addition of an integer no eg:- input:-129;
            // 1+2+9
            //o/p :- 12
            int i=129,temp=0;

            while(i>0) 
            {
                temp += i % 10;
                i=i/10;
            }
            Console.WriteLine(temp);
        }
    }
}
