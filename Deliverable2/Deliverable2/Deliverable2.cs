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
                Console.ReadLine();
            }





        }




    }
         
}
