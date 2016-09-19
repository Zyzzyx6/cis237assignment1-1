using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {

        

        static void Main(string[] args)
        {
            Console.WindowWidth = 100;
            Console.WindowHeight = 30;
           
   
            UserInterface ui = new UserInterface();

            int choice = ui.GetUserInput();
           
            while (choice != 5)
            { 
    
                switch (choice)
                {
                    case 1:

                        WineItemCollection wineCollection = new WineItemCollection("process");                     

                        break;
                    case 2:     //Search wine list
                        WineItem searchWine = new WineItem();
                        break;
                    case 3:     //add new wine

                        break;
                    case 4:
                        
                        WineItemCollection printWineList = new WineItemCollection();
                        printWineList.printFullArray();
                        break;
                    case 5:
                       Environment.Exit(-1);
                        break;
                   
                }
                choice = ui.GetUserInput();
               

            }


        }


    }
}
