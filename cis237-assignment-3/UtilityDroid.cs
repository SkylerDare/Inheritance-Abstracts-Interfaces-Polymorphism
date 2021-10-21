//Skyler Dare
//CIS237
//10/22/21
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment_3
{
    class UtilityDroid : Droid
    {
        //*******************************************************
        // Attributes/Variables/Backing Fields
        //*******************************************************
        decimal totalCost;
        string hasAddon;
        bool toolbox;
        bool computerConnection;
        bool arm;
        //*******************************************************
        //Properties
        //*******************************************************
        public bool Toolbox
        {
            get { return toolbox; }
            set { toolbox = value; }
        }

        public bool ComputerConnection
        {
            get { return computerConnection; }
            set { computerConnection = value; }
        }

        public bool Arm
        {
            get { return arm; }
            set { arm = value; }
        }

        public override decimal TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }

        public override string HasAddon
        {
            get { return hasAddon; }
        }

        public override decimal BaseCost
        {
            get { return 350.00m; }
        }
        //*******************************************************
        //Methods
        //*******************************************************
        /// <summary>
        /// calculates total cost for a Utility Droid, checks to see what addons were selected and adds to total cost
        /// it also adds the option to a string for output
        /// </summary>
        public override void CalculateTotalCost()
        {
            TotalCost = 0;
            hasAddon = "";
            CalculateMaterialCost();
            if (this.Toolbox)
            {
                hasAddon += "|Toolbox| ";
                TotalCost += 25.00m;
            }
            if (this.ComputerConnection)
            {
                hasAddon += "|Computer Connection| ";
                TotalCost += 40.00m;
            }
            if (this.Arm)
            {
                hasAddon += "|Arm| ";
                TotalCost += 30.00m;
            }
            TotalCost += BaseCost + MaterialCost;
            return;
        }
        /// <summary>
        /// Formats the output string for the print list option
        /// </summary>
        /// <returns>formatted output string</returns>
        public override string ToString()
        {
            return $"{base.ToString()}Addons: {HasAddon} Total Cost: |{TotalCost.ToString("C")}| ";
        }
        //*******************************************************
        //Constructors
        //*******************************************************
        public UtilityDroid(string Material, string Color, 
                            bool Toolbox, bool ComputerConnection, bool Arm) : 
                            base(Material, Color)
        {
            this.Toolbox = Toolbox;
            this.ComputerConnection = ComputerConnection;
            this.Arm = Arm;
            CalculateTotalCost();
        }
    }
}
