using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable2
{
    class Deliverable2
    {
        static void Main(string[] args)
        {

            string a, b, c, d;
            int optionOne = 0, optionTwo = 4, optionThree = 10, optionFour = 11;       


            Console.WriteLine("Hello user, what are you in the mood for?");
            Console.WriteLine("Here are your options: ");

            Console.WriteLine(a = "1). Action");
            Console.WriteLine(b = "2). Chill Out");
            Console.WriteLine(c = "3). Push it to the limit");
            Console.WriteLine(d = "4). Craving food");
            Console.ReadLine();

            if (a == "1" || a == "Action" || a == "ACTION" ||
                b == "2" || b == "Chill Out" || b == "CHILL OUT" ||
                c == "3" || c == "Push it to the limit" || c == "PUSH IT TO THE LIMIT" ||
                d == "4" || d == "Craving food" || b == "CRAVING FOOD")
            {
                Console.WriteLine("I didn't get that. Try one more time. You got this!");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("How many people are you going to bring?");
                Console.WriteLine(a = "0");
                Console.WriteLine(b = "1 - 4");
                Console.WriteLine(c = "5 - 10");
                Console.WriteLine(d = "11+");
                Console.ReadLine();
            }
            if (optionOne == 0)
            {
                Console.WriteLine("You should run to Taco Bell in your sneakers!");
                Console.WriteLine("I had fun talking to you! Good-bye! See ya later!");
                Console.ReadLine();

            }
            else 
            {
                Console.WriteLine("I had fun talking to you! Good-bye! See ya later!");
            }

            if (optionTwo > 0 || optionTwo  <= 4)
            {
                Console.WriteLine("You guys should go Stock Car Racing in your sedan!");
                Console.WriteLine("I had fun talking to you! Good-bye! See ya later!");
                Console.ReadLine();
            }
            if (optionThree > 4 || optionThree <= 10)
            {
                Console.WriteLine("You guys should go Hiking in the woods. Take a Volkswagen Bus for the Woodstock vibe.");
                Console.WriteLine("I had fun kicking it with you! Good-bye!");
                Console.ReadLine();
            }
            if (optionFour > 10)

                Console.WriteLine("You all need to go Skydiving! My buddy Billy has an airplane he can lend you.");
                Console.WriteLine("I wish you all a safe journey! Good-bye!");
                Console.ReadLine();

        }
    }
}



        
