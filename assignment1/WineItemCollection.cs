using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItemCollection 
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

       


        //public WineItemCollection(string print)
        //{
        //    printarray();
        //}


       


            //foreach (string wineID in CSVProcessorClass.wineList)
            //            {
            //                if (wineID != null)
            //                {
            //                    //allOutput += wine.ToString() + " " + wine.YearlySalary() + Environment.NewLine;
            //                }
            //            }
            //for (int row = 0; row < 3960; row++)
            //{
            //    Console.Write("{0,6}{1,60}{2,20}", wineList[row, 0], wineList[row, 1], wineList[row, 2]);
            //    Console.WriteLine();
            //}
      
        
    }
}
