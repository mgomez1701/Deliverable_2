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

            string ch, rh;


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
                    Console.WriteLine("How many of you are going?");
                    Console.WriteLine("0");
                    Console.WriteLine("1-4");
                    Console.WriteLine("5-10");
                    Console.WriteLine("11+");
                    Console.ReadLine();
                    break;
                case "Chill Out":
                    Console.WriteLine("How many of you are going?");
                    Console.WriteLine("0");
                    Console.WriteLine("1-4");
                    Console.WriteLine("5-10");
                    Console.WriteLine("11+");
                    Console.ReadLine();
                    break;
                case "Danger":
                    Console.WriteLine("How many of you are going?");
                    Console.WriteLine("0");
                    Console.WriteLine("1-4");
                    Console.WriteLine("5-10");
                    Console.WriteLine("11+");
                    Console.ReadLine();
                    break;
                case "Craving Food":
                    Console.WriteLine("How many of you are going?");
                    Console.WriteLine("0");
                    Console.WriteLine("1-4");
                    Console.WriteLine("5-10");
                    Console.WriteLine("11+");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("I am not yet programmed to understand that. Please make sure you type the words out just like they look.");
                    Console.ReadLine();
                    break;

            }

            
            rh = Convert.ToString(Console.ReadLine());

            switch (rh)
            {
                case "0":
                    Console.WriteLine("If you are by yourself you should go to Taco Bell in a Sedan?");
                    Console.WriteLine("Thank you for chatting with me. Have fun. Good-bye!");
                    Console.ReadLine();
                    break;
                case "1-4":
                    Console.WriteLine("You all shouuld go Hiking in the mountains. Make sure you pack your sneakers!");
                    Console.WriteLine("Thank you for chatting with me. Have fun. Good-bye!");
                    Console.ReadLine();
                    break;
                case "5-10":
                    Console.WriteLine("I think going Stock Car Racing in a Volkswagon Bus would be a sight to see.");
                    Console.WriteLine("Thank you for chatting with me. Have fun. Good-bye!");
                    Console.ReadLine();
                    break;
                case "11+":
                    Console.WriteLine("All of you should go Sky Diving! I have an Airplane that you can borrow!");
                    Console.WriteLine("Thank you for chatting with me. Have fun. Good-bye!");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("I am not yet programmed to understand that. Please make sure you type the numbers out just like they look.");
                    Console.ReadLine();
                    break;

                    
            }

            Console.ReadLine();
                
        }
    }
}



        
