using System;

namespace Factorial
{
    class recurssion
    {
        public int fac(int n)
        {
            int n1 = n;

            
                if (n1 == 0)
                {
                    return 1;
                }
                else
                {
                    return n1 * fac(n1 - 1);
                }
           
        }
    }

    class Factorial
    {
        static void Main(string[] args)
        {

            int n = 6; int fact = 1;
            for(int i=1;i<=n;i++)
            {
                fact *= i;
            }
            Console.WriteLine(fact);
            recurssion r = new recurssion();
           Console.WriteLine(r.fac(5));
            
        }
    }
}
