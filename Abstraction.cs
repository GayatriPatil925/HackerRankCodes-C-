using System;

namespace AbstractScenario
{
    abstract class Zoo
    {
       public abstract void Animal();

        public void Voice()
        {
            Console.WriteLine("Panda says : wee wee");
        }    
    }

    class APlanet : Zoo
    {
        public override void Animal()
        {
            Console.WriteLine("Hey Girish Gaikwad");
        }

         
    }
    class Abstraction
    {
        static void Main(string[] args)
        {
            APlanet p=new APlanet();
            p.Animal();
            p.Voice();

        }
    }
}
