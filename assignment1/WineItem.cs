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
    class WineItem 
    {


        //****************
        //Constructors
        //****************
        public WineItem()
        {
            //do nothing
        }
        //***************
        //Backing Fields
        //***************
        private string _wineID;
        private string _description;
        private string _pack;
       

        //***************
        //Properties
        //***************
        
        public string WineID
        {
            get { return _wineID; }
            set { _wineID = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string Pack
        {
            get { return _pack; }
            set { _pack = value; }
        }

       


        //********************
        //Methods
        //********************
        public override string ToString() //Concat and assign value to ToString()
        {
            
            return this._wineID + "     " + this._description + "     " + this._pack;
            
        }

        public void searchWineList(string[,] wineList) //Search Array for user entered stock number
        {

            
            Console.WriteLine();
            Console.WriteLine("Please enter a stock number to search:");
            Console.WriteLine();
            string userSearch = Console.ReadLine();

            
            bool found = false;
            int index = 0;
            int position = 0;
            try
            {
                //Loop through wine list array until end
                while (!found && index < wineList.GetLength(0))
                {
                    if (wineList[index, 0] == userSearch) //does the user input stock number match anything in the array
                    {
                        found = true;
                        position = index;
                        _wineID = wineList[position, 0];
                        _description = wineList[position, 1];
                        _pack = wineList[position, 2];
                      
                    }
                    else
                    {
                        _description = "No wine found."; //Error message in case wine not found
                        _wineID = "";
                        _pack = "";
                    }
                    index++;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            
        }

    }
}
 