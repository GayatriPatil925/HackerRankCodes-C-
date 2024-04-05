using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            int ch;

            string n="Y";
            while (n == "Y") 
            {
                Console.WriteLine("Enter 2 Nos to Perform Operation");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Choose Operation");
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Substraction");
                Console.WriteLine("3.Multiplication");
                Console.WriteLine("4.Division");
                Console.WriteLine("5.Sin");
                Console.WriteLine("6.Cos");
                Console.WriteLine("7.Tan");
                ch = Convert.ToInt32(Console.ReadLine());

                switch (ch) 
                {
                    case 1:
                        Console.WriteLine("Addition is:-"+(a + b));
                        break;

                     case 2:
                        Console.WriteLine("Substration is:-" + (a - b));
                        break;

                    case 3:
                        Console.WriteLine("Multiplication is:-"+ (a * b));
                        break;
                    case 4:
                        Console.WriteLine("Division is:-" + (a / b));
                        break;

                    case 5:
                        Console.WriteLine("Sin is:-" + Math.Sin(a));
                        break;

                     case 6:
                        Console.WriteLine("Cos is:-" + Math.Cos(b));
                        break;

                    case 7:
                        Console.WriteLine("Tan is:-" + Math.Tan(a));
                        break;

                    default:
                        Console.WriteLine("Invalid Operation");
                        break;
                }

                Console.WriteLine("Do you want Continue.........");
                n=Console.ReadLine();
            }
        }
    }
}
