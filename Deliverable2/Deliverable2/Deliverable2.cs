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

            string question ="";
            bool Answer1 = true, Answer2 = true, Answer3 =true, Answer4 =true;
            int number1 = 0 , number2 = 4, number3 = 10, number4 = 11;


            Console.WriteLine("Hello user, what are you in the mood for?");
            Console.WriteLine("Here are your options: ");
            

            Console.WriteLine("Action");
            Console.WriteLine("Chill Out");
            Console.WriteLine("Danger");
            Console.WriteLine("Craving food");
            Console.ReadLine();
            
            
           

            if (question != "Action" || question != "Chill Out" || question != "Danger" || question != "Craving Food")
            {
                Console.WriteLine("How many people are you bringing with you?");        
                Console.WriteLine("0",number1);
                Console.WriteLine("1-4?",number2);
                Console.WriteLine("5-10",number3);
                Console.WriteLine("11+?",number4);
                Console.ReadLine();

            }

            else 
            {
                Console.WriteLine("I did not understand. Please try again.");
                Console.ReadLine();
                return;

                
            }
             
                if (Answer1 != true || Answer2 != true || Answer3 != true || Answer4 != true)
            {
                Console.WriteLine("You should go to Taco Bell in a Sedan");
                Console.WriteLine("Thanks for chatting with me! Goodbye!");
                Console.ReadLine();
                }

                else if (Answer2 != true || Answer1 !=true || Answer3 != true || Answer4 !=true)
                {
                Console.WriteLine(" You should go Hiking up the mountain. Best views out there. I would pack your best sneakers.");
                Console.WriteLine("Thanks for chatting with me! Goodbye!");
                Console.ReadLine();
                }

                else if (Answer3 != true || Answer1 != true || Answer2 != true || Answer4 != true)
                {
                Console.WriteLine("I laugh in the face of Danger! -Simba Voice. I can lend you an Airplane to go Skydiving in. You should do that.");
                Console.WriteLine("Thanks for chatting with me! Goodbye!");
                Console.ReadLine();
                }

                else if (Answer4 == true || Answer1 != true || Answer2 != true || Answer4 != true)
                {
                Console.WriteLine("The best thing to do would be go Stock Car Racing in a Volkswagon Bus");
                Console.WriteLine("Thanks for chatting with me! Goodbye!");
                Console.ReadLine();
                }

                else
                {
                Console.WriteLine("I did not understand. Please try again.");
                Console.ReadLine();
                return;
                }



                
        }
    }
}



        
