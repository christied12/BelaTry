using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelaTry
{
    class Program
    {
        static void Main(string[] args)
        {
            // take info and change to upper case and split values
            string[] input = Console.ReadLine().ToUpper().Split(" ");

            // define variables
            long n = Int64.Parse(input[0]);
            char b = input[1][0];

            int points = 0;

            // tell when to stop/start and initialize a counter
            for (int i = 0; i < (n * 4); i++)
            {
                char[] card = Console.ReadLine().ToUpper().ToCharArray();

                char description = card[0];
                char suit = card[1];

                if (suit == b)
                {
                    if (description == 'K')
                    {
                        points = points + 4;
                    }
                    else if (description == 'A')
                    {
                        points = points + 11;
                    }
                    else if (description == 'Q')
                    {
                        points = points + 3;
                    }
                    else if (description == 'J')
                    {
                        points += 20;
                    }
                    else if (description == 'T')
                    {
                        points = points + 10;
                    }
                    else if (description =='9')
                    {
                        points += 14;
                    }
                    else if (description == '8')
                    {
                        points = points + 0;
                    }
                    else if (description == '7')
                    {
                        points += 0;
                    }

                }
                if (suit != b)

                {   if (description == 'K')
                    {
                        points = points + 4;
                    }
                   else if ( description == 'Q')
                    {
                        points += 3;
                    }
                        
                    else if (description == 'T')
                    {
                        points = points + 10;
                    }
                    else if (description == 'J')
                    {
                        points += 2;
                    }
                    else if (description == '9') 
                    {
                        points = points + 0;
                    }
                    else if (description == '8')
                    {
                        points += 0;
                    }
                    else if (description == '7')
                    {
                        points = points + 0;
                    }
                    else if (description == 'A')
                    {
                        points += 11;
                    }
                }
            } Console.WriteLine(points);
        }
    }
}
