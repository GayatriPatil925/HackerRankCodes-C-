using System;

namespace Overloading
{

    class Sample
    {
        public void add()
        {
            int a = 6, b = 6;

            int c = a + b;
            Console.WriteLine(c);
        }
        public void add(int a,int b)
        {
            int A = a, B = b;
            int c = A + B;
            Console.WriteLine(c);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();
            s.add();
            s.add(5, 6);
        }
    }
}
