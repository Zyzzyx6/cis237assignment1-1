using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class UserInterface : Program
    {

        public int GetUserInput()
        {
            this.DisplayMenu();

            string input = Console.ReadLine();
           
            while (input != "1" && input != "2" && input != "3" && input != "4" && input != "5")
            {
                Console.WriteLine("That is not a valid entry");
                Console.WriteLine("Please make a valid choice");
                Console.WriteLine();
                
                input = Console.ReadLine();

                this.DisplayMenu();

            }

            return Int32.Parse(input);
        }


        public void DisplayMenu() //Displays top navigation menu
        {
          
            Console.WriteLine("{0,20}{1,22}{2,20}{3,22}{4,10}",
               "1.) Load Wine List", "2.) Search Wine List", "3.) Add New Wine", "4.) Print Wine List", "5.) Exit");
            Console.WriteLine("____________________________________________________________________");

            Console.Write("Enter Menu Number: ");
 
            
        }      
        
   

    }
}
