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

            string ch ="";
            int value = 12;
            
           





            Console.WriteLine("Hello user, what are you in the mood for?");
            Console.WriteLine("Here are your options: ");

            Console.WriteLine("Action");
            Console.WriteLine("Chill Out");
            Console.WriteLine("Danger");
            Console.WriteLine("Craving food");
            ch = Convert.ToString(Console.ReadLine());


            switch (ch)
            { 
                case "Action":
                    Console.WriteLine("I love doing action packed activities! How many of you are going?");
                    value = Convert.ToInt32(Console.ReadLine());
                   

                    break;

                case "Chill Out":
                    Console.WriteLine("Chilling out is what I do best. How many of you are going?");
                    value = Convert.ToInt32(Console.ReadLine());

                    break;

                case "Danger":
                    Console.WriteLine("You are freaking me out a bit, but I can help with Danger. How many of you are going?");
                    value = Convert.ToInt32(Console.ReadLine());

                    break;

                case "Craving Food":
                    Console.WriteLine("I got the best spot for you to How many of you are going?");
                    value = Convert.ToInt32(Console.ReadLine());

                    break;

                default:
                    Console.WriteLine("I am not yet programmed to understand that. Please make sure to type the words out exactly how they look. Caps matter.");
                    Console.ReadLine();
                    
                    break;

            }

            if (int.TryParse(ch, out value))
                value = Convert.ToInt32(Console.ReadLine());



            if (value == 0 && ch == "Craving Food") 
            {
                Console.WriteLine("Okay if you are in the mood for good food, I would go to Taco Bell in a Sedan");
                Console.WriteLine("Thank you for chatting with me. Have fun. Good-bye!");
                Console.ReadLine();
            }

            else if (value <= 4 && ch == "Chill Out")
            {
                Console.WriteLine("If you are looking to chill out, you should go Hiking in the mountains. Be sure to pack your Sneakers");
                Console.WriteLine("Thank you for chatting with me. Have fun. Good-bye!");
                Console.ReadLine();           
            }
            
            else if ( value <= 10  && ch == "Action")
            {
                Console.WriteLine("If you are looking for action, Stock Car Racing in a Volkswagon Bus would be perfect!");
                Console.WriteLine("Thank you for chatting with me. Have fun. Good-bye!");
                Console.ReadLine();
            }

            else if  (ch == "Danger")
            {
                Console.WriteLine("If you are looking for danger, you should go Sky Diving! I have an Airplane that you can borrow!");
                Console.WriteLine("Thank you for chatting with me. Have fun. Good-bye!");
                Console.ReadLine();
            }
          

            Console.ReadLine();
                
        }
    }
}



        
