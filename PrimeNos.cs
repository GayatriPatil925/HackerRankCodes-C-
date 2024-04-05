using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace prime
{
    internal class PrimeNos
    {
        static void Main(string[] args)
        {
            int ints = 10,Count=0;

            for(int i = 1; i <= ints; i++) 
            {
                if (ints%i == 0)
                {
                    Count++;
                }
            }
            if(Count == 2) 
            {
                Console.WriteLine("prime");
            }
            else 
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}
