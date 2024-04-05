using System;

class CamelCase
{
    //private static object chararr;
/*
 * Sample Input

    Frist S is for Separate
    C for combine
Second C is for class , V for variable , M method 
S;M;plasticCup()

C;V;mobile phone

C;C;coffee machine

S;C;LargeSoftwareBook

C;M;white sheet of paper

S;V;pictureFrame

Sample Output

plastic cup

mobilePhone

CoffeeMachine

large software book

whiteSheetOfPaper()

picture frame

    */
static void Main(string[] args)
{

    while(true)
    {
        string input = Console.ReadLine();

        if (input == null || input.Trim() == " ")
        {
            break;
        }

        var split = input.Split(";");
        string op = split[0];
        string type = split[1];
        string words = split[2];

        var charaar = words.ToCharArray();

        string temp = string.Empty;

        if(op=="S")
        {
            foreach(var i in charaar)
            {
                if(char.IsUpper(i))
                {
                    temp = temp + " " + char.ToLower(i);
                }
                else if (i!='(' && i!=')')
                {
                    temp = temp + i;
                }

            }
            Console.WriteLine(temp.Trim());
        }



        if(op=="C")
        {
            for(int i=0;i<charaar.Length;i++)
            {
                if (type == "C")
                {
                    if (i == 0)
                    {
                        temp = temp + char.ToUpper(charaar[0]);
                    }
                    else if (charaar[i] != ' ')
                    {
                        if (i > 0 && charaar[i - 1] == ' ')
                        {
                            temp = temp + char.ToUpper(charaar[i]);
                        }
                        else
                        {
                            temp = temp + charaar[i];
                        }
                    }
                }

                else if (type == "V")
                {
                    if (charaar[i] != ' ')
                    {
                        if (i > 0 && charaar[i - 1] == ' ')
                        {
                            temp = temp + char.ToUpper(charaar[i]);
                        }
                        else
                        {
                            temp = temp + charaar[i];
                        }
                    }
                }

                else if (type == "M")
                {
                    if (charaar[i] != ' ')
                    {
                        if (i > 0 && charaar[i - 1] == ' ')
                        {
                            temp = temp + char.ToUpper(charaar[i]);
                        }
                        else if(i == charaar.Length-1)
                        {
                            temp = temp + charaar[i] + "()";
                        }
                        else
                        {
                            temp = temp + charaar[i];
                        }
                    }  
                }
            }
            Console.WriteLine(temp.Trim());
        }
    }

}
}
