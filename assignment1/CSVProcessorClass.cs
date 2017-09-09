//Marty Russon
//Project 1 Wine List utility
//September 9, 2017

//Outside resources: Stackoverflow, Microsoft

//Project: Wine List utility to demonstrate usage of multiple classes, 2d array creation and loading from 
//an external csv file. Array search implamented and return results to screen. Add new wine to array.

//Class: This class exclusively used for populating the empty array created in Main from an external csv file


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1
{
    public class CSVProcessorClass 
    {

     
        public string[,] wineList;

        public void loadWineArray(string[,] wineList) //Creat WineLst array and Load array
        {
            string pathToCsv = "../../../dataFiles/WineList.csv"; //create string variable for path to CSV

            StreamReader file = new StreamReader(pathToCsv);
            var lineCount = File.ReadAllLines(pathToCsv).Length;
            
            

            try
            {

               string inputString;

                file = File.OpenText(pathToCsv);     //Open external file and prepare for reading

                // Load the array.
                for (int row = 0; row < lineCount; row++)
                {
                    inputString = file.ReadLine();
                    var varString = inputString.Split(',');
                    for (int col = 0; col < 3; col++)
                    {
                        wineList[row, col] = varString[col];

                    }
                }
                Console.WriteLine();
                Console.WriteLine("WineList Loaded");
                Console.WriteLine();
            }

            catch
            {
                Console.WriteLine("Error reading file"); //Oops Bad read

            }

            file.Close();
 

        }



     }

   }

