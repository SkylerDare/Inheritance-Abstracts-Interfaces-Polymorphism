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
    abstract class Droid : IDroid
    {
        //*******************************************************
        // Attributes/Variables/Backing Fields
        //*******************************************************
        protected string material;
        protected string color;
        decimal materialCost;

        //*******************************************************
        // Properties
        //*******************************************************
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

        public decimal MaterialCost
        {
            get { return materialCost; }
            set { materialCost = CalculateMaterialCost(); }
        }

        public abstract decimal BaseCost { get; }
        public abstract decimal TotalCost { get; set; }
        public abstract string HasAddon { get; }

        //*******************************************************
        //Methods
        //*******************************************************
        /// <summary>
        /// Formats the output string for the print list option
        /// </summary>
        /// <returns>formatted output string</returns>
        public override string ToString()
        {
            return $"Material: |{Material}| Color: |{Color}| ";
        }
        /// <summary>
        /// abstract method for calculating total cost
        /// </summary>
        public abstract void CalculateTotalCost();
        /// <summary>
        /// method for collecting the material cost for total cost in lower classes
        /// </summary>
        /// <returns>material cost</returns>
        public decimal CalculateMaterialCost()
        {
            if (this.Material == "Aluminum")
            {
                materialCost += 75.00m;
            }
            if (this.Material == "Titanium")
            {
                materialCost += 200.00m;
            }
            if (this.Material == "Steel")
            {
                materialCost += 120.00m;
            }
            return materialCost;
        }
        //*******************************************************
        //Constructors
        //*******************************************************
        public Droid(string Material, string Color)
        {
            this.Material = Material;
            this.Color = Color;
        }
    }
}
