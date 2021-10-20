using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment_3
{
    class AstromechDroid : UtilityDroid
    {
        bool fireExtinguisher;
        int numberShips;
        decimal totalCost;
        string hasAddon;
        const decimal COST_PER_SHIP = 50.00m;

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

        public override void CalculateTotalCost()
        {
            totalCost = 0;
            hasAddon = "";
            base.CalculateTotalCost();
            hasAddon += base.HasAddon;
            if (this.FireExtinguisher)
            {
                hasAddon += "|Fire Extinguisher| ";
                totalCost += 65.00m;
            }
            hasAddon += "Number of Ships: ";
            totalCost += (numberShips * COST_PER_SHIP) + base.TotalCost;
            return;
        }

        public override string ToString()
        {
            return base.ToString();
        }

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
