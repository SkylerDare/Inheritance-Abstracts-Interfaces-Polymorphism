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
    class JanitorDroid : UtilityDroid
    {
        //*******************************************************
        // Attributes/Variables/Backing Fields
        //*******************************************************
        bool trashCompactor;
        bool vacuum;
        decimal totalCost;
        string hasAddon;

        //*******************************************************
        //Properties
        //*******************************************************
        public bool TrashCompactor
        {
            get { return trashCompactor; }
            set { trashCompactor = value; }
        }

        public bool Vacuum
        {
            get { return vacuum; }
            set { vacuum = value; }
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
            base.CalculateTotalCost();
            hasAddon += base.HasAddon;
            if (this.TrashCompactor)
            {
                hasAddon += "|Trash Compactor| ";
                TotalCost += 85.00m;
            }
            if (this.Vacuum)
            {
                hasAddon += "|Vacuum| ";
                TotalCost += 100.00m;
            }
            TotalCost += base.TotalCost;
            return;
        }
        /// <summary>
        /// Formats the output string for the print list option
        /// </summary>
        /// <returns>formatted output string</returns>
        public override string ToString()
        {
            return base.ToString();
        }
        //*******************************************************
        //Constructors
        //*******************************************************
        public JanitorDroid(string Material, string Color, 
                            bool Toolbox, bool ComputerConnection, bool Arm, 
                            bool TrashCompactor, bool Vacuum) :
                            base (Material, Color, Toolbox, ComputerConnection, Arm)
        {
            this.TrashCompactor = TrashCompactor;
            this.Vacuum = Vacuum;
            CalculateTotalCost();
        }
    }
}
