using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    class Test
    {
        public static void Main(String[] args)
        {
            ATMProgram bob = new ATMProgram();
            int quit = 1;
            do
            {
                String directions = Console.ReadLine();
                int index = -999;
                int value = -999;
                String directionsPlusSpace = directions + " ";
                char first = char.ToLower(directions[0]);
                switch (first)
                {
                    case 'r':
                        bob.restock();
                        break;
                    case 'w':
                        index = directions.IndexOf("$");
                        value = Int32.Parse(directions.Substring(index + 1));
                        bob.withdraw(value);
                        break;
                    case 'i':
                        if (directionsPlusSpace.Contains(" $100 "))
                        {
                            Console.WriteLine("$100 - " + bob.getHundreds());
                        }
                        if (directionsPlusSpace.Contains(" $50 "))
                        {
                            Console.WriteLine("$50 - " + bob.getFifty());
                        }
                        if (directionsPlusSpace.Contains(" $20 "))
                        {
                            Console.WriteLine("$20 - " + bob.getTwenty());
                        }
                        if (directionsPlusSpace.Contains(" $10 "))
                        {
                            Console.WriteLine("$10 - " + bob.getTens());
                        }
                        if (directionsPlusSpace.Contains(" $5 "))
                        {
                            Console.WriteLine("$5 - " + bob.getFives());
                        }
                        if (directionsPlusSpace.Contains(" $1 "))
                        {
                            Console.WriteLine("$1 - " + bob.getOnes());
                        }
                        break;
                    case 'q':
                        quit = 0;
                        break;
                    default:
                        Console.WriteLine("Failure: Invalid Command");
                        break;


                }

            } while (quit != 0);


            Console.ReadKey();
        }
    }
}
