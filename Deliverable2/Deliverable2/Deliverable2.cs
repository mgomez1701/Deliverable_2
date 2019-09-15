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

            string question;      


            Console.WriteLine("Hello user, what are you in the mood for?");
            Console.WriteLine("Here are your options: ");
            

            Console.WriteLine("Action");
            Console.WriteLine("Chill Out");
            Console.WriteLine("Danger");
            Console.WriteLine("Craving food");
            question = Convert.ToString(Console.ReadLine());


            if (question == "Action" || question == "Chill Out" || question == "Danger" || question == "Craving Food")
            {
                Console.WriteLine("How many people are you bringing with you?");
                Console.ReadLine();

            }

            else 
            {
                Console.WriteLine("I did not understand. Please try again.");
                Console.ReadLine();
            }
            
            
        }
    }
}



        
