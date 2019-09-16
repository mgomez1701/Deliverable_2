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

            string ch;


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
                    Console.ReadLine();
                    break;
                case "Chill Out":
                    Console.WriteLine("How many of you are going?");
                    Console.ReadLine();
                    break;
                case "Danger":
                    Console.WriteLine("How many of you are going?");
                    Console.ReadLine();
                    break;
                case "Craving Food":
                    Console.WriteLine("How many of you are going?");
                    Console.ReadLine();
                    break;
            }

            Console.ReadLine();
                
        }
    }
}



        
