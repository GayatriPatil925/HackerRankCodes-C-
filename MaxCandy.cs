using System.Collections.Generic;
using System;
using System.Linq;

class Maxcandy
 {
    //We have a array where each value represents no. of candies that kids are having
    //We have another int variable which represents the extra candy
    //What we are finding is when we add extra candy to no. of candies array, one of the kid will have more number of candies
    //after addition and we are trying to print it
    //for example array is [4, 2, 1, 2] and number of candy is 5. Now we will add this 5 to each element in array and find out which
    //high number of candies

    static void Main(string[] args)
    {
        List<int> candy = new List<int> { 4, 2, 1, 2 };
        List<bool> result = new List<bool> ();
        Console.Write("enter a extra value :");
        int extra = Convert.ToInt32(Console.ReadLine());
        int largecandy = candy.Max();

        for(int i=0;i<candy.Count;i++)
        {
            if(candy[i]+extra >  largecandy)
            {

                result.Add(true);
            }
            else
            {
                result.Add(false);
            }
        }

        foreach(bool i in result)
        {
            Console.WriteLine(i);
        }
        

        
    }
}