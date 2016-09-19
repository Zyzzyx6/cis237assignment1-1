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
        
        //****************
        //CONSTRUCTOR
        //****************
        public CSVProcessorClass()
        {

             loadWineArray();
          
        }

        public void loadWineArray() //Creat WineLst array and Load array
        {
            string pathToCsv = "../../../dataFiles/WineList.csv"; //create string variable for path to CSV

            StreamReader file = new StreamReader(pathToCsv);
            var lineCount = File.ReadAllLines(pathToCsv).Length;

            wineList = new string[lineCount, 3];

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

