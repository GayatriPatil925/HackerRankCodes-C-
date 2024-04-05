using System;

namespace Interface
{
    
    interface Animal
    {
        void Zoo();

        void Zoo1();
    }
    
    interface Birds
    {
        void Zoo();
        void Zoo1();
    }

    class APlanet : Animal, Birds
    {
        public void Zoo()
        {
            Console.WriteLine("Hey Girish Gaikwad");
        }

        public void Zoo1()
        {
            Console.WriteLine("Panda says : wee wee");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            APlanet p = new APlanet();
            Animal sample = p;
            sample.Zoo();
            p.Zoo1();
        }
    }
}
