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
    class ProtocolDroid : Droid
    {
        //*******************************************************
        // Attributes/Variables/Backing Fields
        //*******************************************************
        int numberLanguages;
        decimal totalCost;
        const decimal COST_PER_LANGUAGE = 55.00m;

        //*******************************************************
        //Properties
        //*******************************************************
        public int NumberLanguages
        {
            get { return numberLanguages; }
            set { numberLanguages = value; }
        }
        public override string HasAddon
        {
            get { return ""; }
        }

        public override decimal BaseCost
        {
            get { return 200.00m; }
        }

        public override decimal TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }
        //*******************************************************
        //Methods
        //*******************************************************
        /// <summary>
        /// collectes material cost and then calculates total cost for a protocol droid
        /// </summary>
        public override void CalculateTotalCost()
        {
            CalculateMaterialCost();
            TotalCost += (numberLanguages * COST_PER_LANGUAGE) + BaseCost + MaterialCost;
        }
        /// <summary>
        /// Formats the output string for the print list option
        /// </summary>
        /// <returns>formatted output string</returns>
        public override string ToString()
        {
            return $"{base.ToString()}Languages: |{NumberLanguages}| Total Cost: |{TotalCost.ToString("C")}| ";
        }
        //*******************************************************
        //Constructors
        //*******************************************************
        public ProtocolDroid(string Material, string Color, 
                             int NumberLanguages) : 
                             base(Material, Color)
        {
            this.NumberLanguages = NumberLanguages;
            CalculateTotalCost();
        }
    }
}
