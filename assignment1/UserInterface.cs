//Marty Russon
//Project 1 Wine List utility
//September 9, 2017

//Outside resources: Stackoverflow, Microsoft

//Project: Wine List utility to demonstrate usage of multiple classes, 2d array creation and loading from 
//an external csv file. Array search implamented and return results to screen. Add new wine to array.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class UserInterface 
    {

       

        public int GetUserInput() //Get user input from the display menu and return it to main
        {
            this.DisplayMenu();

            string input = Console.ReadLine();
            try
            {

          
            while (input != "1" && input != "2" && input != "3" && input != "4" && input != "5")
            {
                Console.WriteLine("That is not a valid entry");
                Console.WriteLine("Please make a valid choice");
                Console.WriteLine();
                
                input = Console.ReadLine();

                this.DisplayMenu();

            }

            
            }
            catch
            {
                Console.WriteLine("Please enter a valid entry");
            }

            return Int32.Parse(input);
        }


        public void DisplayMenu() //Displays top navigation menu 
        {
          
            Console.WriteLine("{0,20}{1,22}{2,20}{3,22}{4,10}",
               "1.) Load Wine List", "2.) Search Wine List", "3.) Add New Wine", "4.) Print Wine List", "5.) Exit");
            Console.WriteLine("_________________________________________________________________________________________");

            Console.Write("Enter Menu Number: ");
            Console.WriteLine();
            
        }

        public void PrintAllOutput(string[,] wineList) //Loop through array and print every entry
        {

            int wineListSize = wineList.GetLength(0);
            //Loops through and prints full array
            for (int row = 0; row < wineListSize; row++)
            {
                if (wineList[row, 0] != null)
                {
                    Console.Write("{0,6}{1,60}{2,20}", wineList[row, 0], wineList[row, 1], wineList[row, 2] + Environment.NewLine);

                }

            }


            Console.WriteLine();
        }

       public void DisplaySearchResults(string results) //Displays the results of a user search
        {
            Console.WriteLine();
            Console.WriteLine();
            
            Console.WriteLine(results);
            
            Console.WriteLine();
            Console.WriteLine();
        }

        public void printFullArray(string[,] wineList)
        {

           
            return;

        }


    }
}
