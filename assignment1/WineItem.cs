using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItem : WineItemCollection
    {

        //int input = 0;
        
        //****************
        //Constructors
        //****************
        public WineItem()
        {
            GetUserInput();
        }


        public int GetUserInput()
        {


            this.DisplaySearchMenu();
            string value = Console.ReadLine();
            
            
            bool found = false;
            int index = 0;
            int position = 0;
            try { 
            while (!found && index < wineList.Length)
            {
                if (wineList[index, 0] == value)
                {
                    found = true;
                    position = index;
                    showSearchResult(position);
                 }
                if (found == true)
                {

                     //Console.WriteLine();
                     //Console.WriteLine("Please enter a stock number to search:");
                    //Console.WriteLine();
                }
                index++;
            }

            
           }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        return position;

        }

        //********************
        //Methods
        //********************
        public void showSearchResult(int position)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("{0,6}{1,60}{2,20}", wineList[position, 0], wineList[position, 1], wineList[position, 2]);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }

        

        public void DisplaySearchMenu()
        {

            Console.WriteLine();
            Console.WriteLine("Please enter a stock number to search:");
            Console.WriteLine();

            

            //return Int32.Parse(input);

        }

  


    }
}
 