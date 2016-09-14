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
                        CSVProcessorClass csvProcess = new CSVProcessorClass();
                        Console.WriteLine("WineList Loaded");
                        
                        break;
                    case 2:
                        
                        
                        break;
                    case 3:

                        break;
                    case 4:
                        CSVProcessorClass print = new CSVProcessorClass();
                        print.printFullArray();
                        break;
                    case 5:
                        break;
                   
                }
                choice = ui.GetUserInput();

            }
            

            


        }


    }
}
