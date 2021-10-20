using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment_3
{
    abstract class Droid : IDroid
    {
        protected string material;
        protected string color;
        //decimal baseCost;
        //decimal totalCost;

        public string Material
        {
            get { return material; }
            set { material = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public abstract decimal BaseCost { get; }
        public abstract decimal TotalCost { get; set; }
        public abstract string HasAddon { get; }

        public override string ToString()
        {
            return $"Material: {Material} Color: {Color} ";
        }

        public abstract void CalculateTotalCost();


        public Droid(string Material, string Color)
        {
            this.Material = Material;
            this.Color = Color;
        }
    }
}
