//Marty Russon
//Project 1 Wine List utility
//While the program fundamentally works, I way screwed this one up!!!!!!!!!

//Outside resources: Stackoverflow, Microsoft

//Known issues: I ran out of time. It is poorly documented and badly in need of error handling. I am completely 
//unsure of layout. It also seems like I was recreating classes repetitively. 
//Not sure how to test for existance of a class after they are instantiated.
//while I did learn a lot about classes, methods within those classes and constructors. I do not understand 
//normal layout and structure of a multi class program. I worked very hard on this yet came to realize the
//limits of my knowledge. Please give me the exceptionally low grade I deserve. I may be in over my head.

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
                        WineItemCollection addWine = new WineItemCollection("add");
                        addWine.addWineToArray();
                        break;
                    case 4: 
                        WineItemCollection printWineList = new WineItemCollection("add");
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
