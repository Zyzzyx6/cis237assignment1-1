using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItemCollection : CSVProcessorClass 
    {

        //***************
        //Backing Fields
        //***************
        private string _wineID;
        private string _description;
        private string _pack;


        //***************
        //Properties
        //***************
        //Why the hell did I create these. Late night insomnia and coding is embarassing
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

      
        //***************
        //Constructor
        //***************
        public WineItemCollection(string wineID, string description, string pack)
        {
            this._wineID = wineID;
            this._description = description;
            this._pack = pack;

        }


        public WineItemCollection(string process) //Process CSV file into 2d array called wineList
        {
            if (process == "process")
            {
                CSVProcessorClass csvProcess = new CSVProcessorClass();
            }
            else
            {
                addWineToArray();
            }
        }

        

        public WineItemCollection()
        {
            //do nothing
        }



        //*************************
        //Methods
        //************************* 

        public override string ToString()
        {
            return this._wineID + "     " + this._description + "     " + this._pack;
        }


        public void printFullArray()
        {
            int wineListSize = wineList.GetLength(0);
                //Loops through and prints full array
            for (int row = 0; row < wineListSize; row++)
            {
                if (wineList != null)
                {

                    Console.Write("{0,6}{1,60}{2,20}", wineList[row, 0], wineList[row, 1], wineList[row, 2]);
                    Console.WriteLine();
                }
                
            }

            Console.WriteLine(wineList.GetLength(0));
            
        }

        public void addWineToArray()
        {
            string wineIDInput;
            string wineDescriptionInput;
            string winePackInput;
            Console.WriteLine("Enter WineId Number: ");
            wineIDInput = Console.ReadLine();


            Console.WriteLine("Enter wine description");
            wineDescriptionInput = Console.ReadLine();

            Console.WriteLine("Enter pack type");
            winePackInput = Console.ReadLine();

                 
            
            int newRow = wineList.GetLength(0) + 1;

            ResizeArray(ref wineList, 3, newRow);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine();

            int insertRow = wineList.GetLength(0) - 1;

            wineList[insertRow, 0] = wineIDInput.ToString();
            wineList[insertRow, 1] = wineDescriptionInput.ToString();
            wineList[insertRow, 2] = winePackInput.ToString();

            printFullArray();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Wine Added");
            Console.WriteLine();

        }


        private void ResizeArray(ref string[,] original, int cols, int rows)
        {
            string[,] wineList = new string[rows, cols];
            Array.Copy(original, wineList, original.Length);
            original = wineList;
        }

    }
}
