//Marty Russon
//Project 1 Wine List utility
//September 22, 2017

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
    class WineItemCollection 
    {
        
      
        //***************
        //Constructor
        //***************
        
        public WineItemCollection()
        {
            //do nothing
        }



        //*************************
        //Methods
        //************************* 

        public void addWineToArray(string[,] wineList)
        {
            string wineIDInput;
            string wineDescriptionInput;
            string winePackInput;
            Console.WriteLine("Enter WineId Number: ");
            wineIDInput = Console.ReadLine();


            Console.WriteLine("Enter wine description");
            wineDescriptionInput = Console.ReadLine();

            Console.WriteLine("Enter pack type");
            winePackInput = Console.ReadLine();

                 
            
            int newRow = wineList.GetLength(0) + 1;

            

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine();

            int insertRow = wineList.GetLength(0) - 1;

            wineList[insertRow, 0] = wineIDInput.ToString();
            wineList[insertRow, 1] = wineDescriptionInput.ToString();
            wineList[insertRow, 2] = winePackInput.ToString();

            

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Wine Added");
            Console.WriteLine();

        }


 
    }
}
