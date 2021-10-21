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
    class AstromechDroid : UtilityDroid
    {
        //*******************************************************
        // Attributes/Variables/Backing Fields
        //*******************************************************
        bool fireExtinguisher;
        int numberShips;
        decimal totalCost;
        string hasAddon;
        const decimal COST_PER_SHIP = 50.00m;

        //*******************************************************
        //Properties
        //*******************************************************
        public bool FireExtinguisher
        {
            get { return fireExtinguisher; }
            set { fireExtinguisher = value; }
        }

        public int NumberShips
        {
            get { return numberShips; }
            set { numberShips = value; }
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
            if (this.FireExtinguisher)
            {
                hasAddon += "|Fire Extinguisher| ";
                TotalCost += 65.00m;
            }
            hasAddon += "Number of Ships: ";
            TotalCost += (numberShips * COST_PER_SHIP) + base.TotalCost;
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
        public AstromechDroid(string Material, string Color,
                              bool Toolbox, bool ComputerConnection, bool Arm,
                              bool FireExtinguisher, int NumberShips):
                              base(Material, Color, Toolbox, ComputerConnection, Arm)
        {
            this.FireExtinguisher = FireExtinguisher;
            this.NumberShips = NumberShips;
            CalculateTotalCost();
        }
    }
}
