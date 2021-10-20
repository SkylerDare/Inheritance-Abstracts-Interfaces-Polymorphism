using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment_3
{
    class UtilityDroid : Droid
    {
        decimal totalCost;
        string hasAddon;
        bool toolbox;
        bool computerConnection;
        bool arm;

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

        public override void CalculateTotalCost()
        {
            totalCost = 0;
            hasAddon = "";
            if (this.Toolbox)
            {
                hasAddon += "|Toolbox| ";
                totalCost += 25.00m;
            }
            if (this.ComputerConnection)
            {
                hasAddon += "|Computer Connection| ";
                totalCost += 40.00m;
            }
            if (this.Arm)
            {
                hasAddon += "|Arm| ";
                totalCost += 30.00m;
            }
            totalCost += BaseCost;
            return;
        }

        public override string ToString()
        {
            return $"{base.ToString()}Addons: {HasAddon} Total Cost: {TotalCost.ToString("C")} ";
        }

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
