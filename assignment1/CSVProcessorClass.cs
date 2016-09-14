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
        
        public CSVProcessorClass()
        {

             loadWineArray();
          
        }

   


        public void loadWineArray()
        {

            StreamReader file = new StreamReader("wineList.csv");
            var lineCount = File.ReadAllLines("wineList.csv").Length;

            wineList = new string[lineCount, 3];

            try
            {

                string inputString;

                file = File.OpenText("WineList.csv");     //Open external file and prepare for reading

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

                
            }

            catch
            {
                Console.WriteLine("Error reading file"); //Oops Bad read

            }

            file.Close();



            Console.Clear();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Wine List Loaded");
            //Console.WriteLine();
            //return;
        }



        public void printFullArray()
        {

            for (int row = 0; row < 3963; row++)
            {
                if (wineList != null)
                { 
                Console.Write("{0,6}{1,60}{2,20}", wineList[row, 0], wineList[row, 1], wineList[row, 2]);
                Console.WriteLine();
                }
            }



        }







    }

    }

