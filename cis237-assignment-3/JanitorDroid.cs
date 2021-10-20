using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment_3
{
    class JanitorDroid : UtilityDroid
    {
        bool trashCompactor;
        bool vacuum;
        decimal totalCost;
        string hasAddon;

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

        public override void CalculateTotalCost()
        {
            totalCost = 0;
            hasAddon = "";
            base.CalculateTotalCost();
            hasAddon += base.HasAddon;
            if (this.TrashCompactor)
            {
                hasAddon += "|Trash Compactor| ";
                totalCost += 85.00m;
            }
            if (this.Vacuum)
            {
                hasAddon += "|Vacuum| ";
                totalCost += 100.00m;
            }
            totalCost += base.TotalCost;
            return;
        }

        public override string ToString()
        {
            return base.ToString();
        }

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
