using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1
{
    class CSVProcessorClass
    {
        private StreamReader wineFile;
        

        public CSVProcessorClass()
        {
            
                //loadWineArray();
                Console.WriteLine("array loaded");
           
        }

        private void loadWineArray()
        {
            

            StreamReader file = new StreamReader("wineList.csv");
            var lineCount = File.ReadAllLines("wineList.csv").Length;

            string[,] wineList = new string[lineCount,3];

            try
            {
                
                string inputString;

                wineFile = File.OpenText("WineList.csv");     //Open external file and prepare for reading

                // Load the array.
                for (int row = 0; row < lineCount; row++)
                {
                    inputString = wineFile.ReadLine();
                    var varString = inputString.Split(',');
                    for (int col = 0; col < 3; col++)
                    {
                        wineList[row, col] = varString[col];
                    }
                }

                Console.WriteLine(wineList[3962,1]);


            }

            catch
            {
                Console.WriteLine("Error reading file"); //Oops Bad read
                     
            }

            Console.WriteLine("array loaded");
           
            
        }

    }
}
