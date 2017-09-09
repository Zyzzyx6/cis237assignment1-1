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
using System.IO;

namespace assignment1
{
    class Program
    {
       

        static void Main(string[] args)
        {


            Console.WindowWidth = 100;
            Console.WindowHeight = 30;
           
            var System = new string[4000,3]; //Instantiates an empty 2d array named System
            UserInterface ui = new UserInterface(); //Creates the navigation menu
            CSVProcessorClass csvProcess = new CSVProcessorClass(); //Instantiates CSV processor class
            WineItemCollection wineCollection = new WineItemCollection();
            WineItem searchWine = new WineItem();
            

            int choice = ui.GetUserInput();
           
            while (choice != 5)
            { 
    
                switch (choice)
                {
                    case 1:     //Load array from CSV file
                        csvProcess.loadWineArray(System);
                           
                        break;
                    case 2:     //Search wine list
                        
                        searchWine.searchWineList(System);
                        ui.DisplaySearchResults(searchWine.ToString()); //Demonstrate override method
                        
                        break;
                    case 3:     //Add new wine
                       
                        wineCollection.addWineToArray(System);
                        break;
                    case 4:     //Print entire list
                        //ui.printFullArray(System);
                        ui.PrintAllOutput(System);
                       
                        break;
                    case 5:
                       Environment.Exit(-1); //Exits program
                        break;
                   
                }
                choice = ui.GetUserInput();
               

            }


        }


    }
}
