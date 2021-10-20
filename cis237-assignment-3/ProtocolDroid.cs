using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment_3
{
    class ProtocolDroid : Droid
    {
        int numberLanguages;
        decimal totalCost;
        const decimal COST_PER_LANGUAGE = 55.00m;
        

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
            get { return 500.00m; }
        }

        public override decimal TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }

        public override void CalculateTotalCost()
        {
            
            totalCost += (numberLanguages * COST_PER_LANGUAGE) + BaseCost;
        }

        public override string ToString()
        {
            return $"{base.ToString()}Languages: {NumberLanguages} Total Cost: {TotalCost.ToString("C")} ";
        }

        public ProtocolDroid(string Material, string Color, 
                             int NumberLanguages) : 
                             base(Material, Color)
        {
            this.NumberLanguages = NumberLanguages;
            CalculateTotalCost();
        }
    }
}
