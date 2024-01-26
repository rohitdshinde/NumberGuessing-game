using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            string user;
            bool iscorrection=false;
            Random random= new Random();
            int rvalue=random.Next(1,10);

            Console.WriteLine("Welcome to the dice game");
            Console.WriteLine("Guess any number to 1 to 10");
            Console.WriteLine("If you guess correct value you !!WIN!!");

            while (!iscorrection)
            {
                Console.WriteLine("Enter a number");
                int a=Convert.ToInt32(Console.ReadLine());

                if (a>rvalue) 
                {
                    Console.WriteLine();
                    Console.WriteLine("Your guess is High:"+ a +" Random value "+rvalue);
                    
                }
                else if (a<rvalue)
                {

                    Console.WriteLine("Your guess is Low:" + a + "Random value " + rvalue);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("CORRECT GUESS");
                    Console.WriteLine("Do you want to continue? (Y/N)");
                    user = Console.ReadLine();

                    if (user == "Y")
                    {
                        iscorrection = false;
                    }
                    else 
                       {
                        iscorrection = true;
                    }

                    

                   
                }
                /*
                if (user != null && user.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
              */

            }
            Console.WriteLine("Conguratulation YOU !!WIN!!");
            Console.ReadLine();
        }
    }
}
