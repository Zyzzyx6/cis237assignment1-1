using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class UserInterface
    {
       
        public UserInterface() 
        {
            DisplayMenu();   
        }

        public int menuNumber
        {
            get { return menuNumber; }
            set { menuNumber = value; }
        }

        public void DisplayMenu() //Displays top navigation menu
        {
            Console.Clear();
            Console.WriteLine("{0,20}{1,22}{2,20}{3,22}{4,10}",
               "1.) Load Wine List", "2.) Search Wine List", "3.) Add New Wine", "4.) Print Wine List", "5.) Exit");
            Console.WriteLine("____________________________________________________________________");

            Console.Write("Enter Menu Number: ");

             menuNumber = Convert.ToInt32(Console.ReadLine());
    
        }        

    }
}
