using System;



namespace Encapsulation
{
    class Encapsulation
    {
       

            int Salary;
        
        public int Setter
        {

            get { return Salary; }
            set { Salary = value; }
        }


        static void Main(string[] args)
        {
            int s;
            Encapsulation p = new Encapsulation();
            p.Salary = 10; //to set value
            Console.WriteLine(p.Salary); //to get value

        }
    }
}
