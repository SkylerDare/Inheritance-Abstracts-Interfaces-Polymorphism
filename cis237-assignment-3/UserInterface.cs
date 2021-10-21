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
    class UserInterface
    {
        //********************************************************************************************************************
        //Prompt and collect Jawa input
        //********************************************************************************************************************
        /// <summary>
        /// Prompts the Jawa for initial input to Add a droid, to print the list, or to end the program, with 1, 2, or 3
        /// </summary>
        /// <returns>user intput</returns>
        public int GetUserInput()
        {
            this.PrintMenu();

            string input = Console.ReadLine();

            while (input != "1" && input != "2" && input != "3")
            {
                this.PrintErrorMessage();
                this.PrintMenu();
                input = Console.ReadLine();
            }
            return Int32.Parse(input);
        }
        /// <summary>
        /// prompts the Jawa and collects input for the type of droid they want to add to the array
        /// </summary>
        /// <returns>droid type int</returns>
        public int GetDroidType()
        {
            this.PrintDroidTypeMenu();
            string input = Console.ReadLine();
            while (input != "1" && input != "2" && input != "3" && input != "4")
            {
                this.PrintErrorMessage();
                this.PrintDroidTypeMenu();
                input = Console.ReadLine();
            }
            return Int32.Parse(input);
        }
        /// <summary>
        /// Prompts the Jawa and collects input for the material of the droid they want to add to the array
        /// </summary>
        /// <returns>droid material string</returns>
        public string GetDroidMaterial()
        {
            string material = "";
            this.PrintDroidMaterialMenu();
            string input = Console.ReadLine();
            while (input != "1" && input != "2" && input != "3")
            {
                this.PrintErrorMessage();
                this.PrintDroidMaterialMenu();
                input = Console.ReadLine();
            }
            if (input == "1")
            {
                material = "Aluminum";
            }
            if (input == "2")
            {
                material = "Titanium";
            }
            if (input == "3")
            {
                material = "Steel";
            }
            return material;
        }
        /// <summary>
        /// Prompts the Jawa and collects input for the color of droid they want to add to the array
        /// </summary>
        /// <returns>droid color string</returns>
        public string GetDroidColor()
        {
            string color = "";
            this.PrintDroidColorMenu();
            string input = Console.ReadLine();
            while (input != "1" && input != "2" && input != "3")
            {
                this.PrintErrorMessage();
                this.PrintDroidColorMenu();
                input = Console.ReadLine();
            }
            if (input == "1")
            {
                color = "Red";
            }
            if (input == "2")
            {
                color = "Blue";
            }
            if (input == "3")
            {
                color = "Unpainted";
            }
            return color;
        }
        /// <summary>
        /// Prompts the Jawa and collects input for the number of languages included for the droid they want to add to the array
        /// </summary>
        /// <returns>number of languages int</returns>
        public int GetLanguageInt()
        {
            int choice = 0;
            while (choice <= 0)
            {
                Console.WriteLine("How many languages do you want the Droid to know? Cost: $55.00 per language");
                string input = Console.ReadLine();
                choice = ValidateInt(input);
                if (choice <= 0)
                {
                    this.PrintErrorMessage();
                    Console.WriteLine("Input a Positive number");
                }
            }
            return choice;
        }
        /// <summary>
        /// Prompts the Jawa and collects input for the number of ships included for the droid they want to add to the array
        /// </summary>
        /// <returns>number of ships int</returns>
        public int GetShipInt()
        {
            int choice = 0;
            while (choice <= 0)
            {
                Console.WriteLine("How many Ships do you want the Droid to be compatible with? Cost: $50.00 per ship");
                string input = Console.ReadLine();
                choice = ValidateInt(input);
                if (choice <= 0)
                {
                    this.PrintErrorMessage();
                    Console.WriteLine("Input a Positive number");
                }
            }
            return choice;
        }
        /// <summary>
        /// Prompts the Jawa and collects input if they want the toolbox addon for the droid they want to add to the array
        /// </summary>
        /// <returns>toolbox boolean true or false</returns>
        public bool GetToolboxBoolean()
        {
            bool choice = false;
            Console.WriteLine("Do you want the Toolbox addon? Cost: $25.00");
            this.PrintBooleanMenu();
            string input = Console.ReadLine();
            while (input != "1" && input != "2")
            {
                this.PrintErrorMessage();
                Console.WriteLine("Do you want the Toolbox addon? Cost: $25.00");
                this.PrintBooleanMenu();
                input = Console.ReadLine();
            }
            if (input == "1")
            {
                choice = true;
            }
            if (input == "2")
            {
                choice = false;
            }
            return choice;
        }
        /// <summary>
        ///  Prompts the Jawa and collects input if they want the Computer Connection addon for the droid they want to add to the array
        /// </summary>
        /// <returns>Computer Connection boolean true or false</returns>
        public bool GetComputerBoolean()
        {
            bool choice = false;
            Console.WriteLine("Do you want the Computer Connection addon? Cost: $40.00");
            this.PrintBooleanMenu();
            string input = Console.ReadLine();
            while (input != "1" && input != "2")
            {
                this.PrintErrorMessage();
                Console.WriteLine("Do you want the Computer Connection addon? Cost: $40.00");
                this.PrintBooleanMenu();
                input = Console.ReadLine();
            }
            if (input == "1")
            {
                choice = true;
            }
            if (input == "2")
            {
                choice = false;
            }
            return choice;
        }
        /// <summary>
        ///  Prompts the Jawa and collects input if they want the Arm addon for the droid they want to add to the array
        /// </summary>
        /// <returns>Arm boolean true or false</returns>
        public bool GetArmBoolean()
        {
            bool choice = false;
            Console.WriteLine("Do you want the Arm addon? Cost: $30.00");
            this.PrintBooleanMenu();
            string input = Console.ReadLine();
            while (input != "1" && input != "2")
            {
                this.PrintErrorMessage();
                Console.WriteLine("Do you want the Arm addon? Cost: $30.00");
                this.PrintBooleanMenu();
                input = Console.ReadLine();
            }
            if (input == "1")
            {
                choice = true;
            }
            if (input == "2")
            {
                choice = false;
            }
            return choice;
        }
        /// <summary>
        ///  Prompts the Jawa and collects input if they want the Trash Compactor addon for the droid they want to add to the array
        /// </summary>
        /// <returns>Trash Compactor boolean true or false</returns>
        public bool GetTrashBoolean()
        {
            bool choice = false;
            Console.WriteLine("Do you want the Trash Compactor addon? Cost: $85.00");
            this.PrintBooleanMenu();
            string input = Console.ReadLine();
            while (input != "1" && input != "2")
            {
                this.PrintErrorMessage();
                Console.WriteLine("Do you want the Trash Compactor addon? Cost: $85.00");
                this.PrintBooleanMenu();
                input = Console.ReadLine();
            }
            if (input == "1")
            {
                choice = true;
            }
            if (input == "2")
            {
                choice = false;
            }
            return choice;
        }
        /// <summary>
        ///  Prompts the Jawa and collects input if they want the Vaccum addon for the droid they want to add to the array
        /// </summary>
        /// <returns>Vacuum boolean true or false</returns>
        public bool GetVacuumBoolean()
        {
            bool choice = false;
            Console.WriteLine("Do you want the Vacuum addon? Cost: $100.00");
            this.PrintBooleanMenu();
            string input = Console.ReadLine();
            while (input != "1" && input != "2")
            {
                this.PrintErrorMessage();
                Console.WriteLine("Do you want the Vacuum addon? Cost: $100.00");
                this.PrintBooleanMenu();
                input = Console.ReadLine();
            }
            if (input == "1")
            {
                choice = true;
            }
            if (input == "2")
            {
                choice = false;
            }
            return choice;
        }
        /// <summary>
        ///  Prompts the Jawa and collects input if they want the Fire Extinguisher addon for the droid they want to add to the array
        /// </summary>
        /// <returns>Fire Extinguisher boolean true or false</returns>
        public bool GetFireBoolean()
        {
            bool choice = false;
            Console.WriteLine("Do you want the Fire Extinguisher addon? Cost: $65.00");
            this.PrintBooleanMenu();
            string input = Console.ReadLine();
            while (input != "1" && input != "2")
            {
                this.PrintErrorMessage();
                Console.WriteLine("Do you want the Fire Extinguisher addon? Cost: $65.00");
                this.PrintBooleanMenu();
                input = Console.ReadLine();
            }
            if (input == "1")
            {
                choice = true;
            }
            if (input == "2")
            {
                choice = false;
            }
            return choice;
        }

        //********************************************************************************************************************
        //Validation
        //********************************************************************************************************************
        /// <summary>
        /// accepts a string input and validates that it can be parsed to an Int32, returns -1 if it fails
        /// </summary>
        /// <param name="number">the input number</param>
        /// <returns>the validated input or -1</returns>
        private int ValidateInt(string number)
        {
            try
            {
                return Int32.Parse(number);
            }
            catch
            {
                number = "-1";
                return Int32.Parse(number);
            }
        }
        //********************************************************************************************************************
        //Selection Menus
        //********************************************************************************************************************
        /// <summary>
        /// Prints the initial menu for the Jawa
        /// </summary>
        private void PrintMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add a new Droid");
            Console.WriteLine("2. Print Droid List");
            Console.WriteLine("3. Exit");
        }
        /// <summary>
        /// Prints the Droid Type selection menu
        /// </summary>
        private void PrintDroidTypeMenu()
        {
            Console.WriteLine("What type of Droid do you want to add?");
            Console.WriteLine("1. Protocol Droid    Cost: $200.00");
            Console.WriteLine("2. Utility Droid     Cost: $350.00");
            Console.WriteLine("3. Janitor Droid     Cost: $350.00");
            Console.WriteLine("4. Astromech Droid   Cost: $350.00");
        }
        /// <summary>
        /// Prints the Droid Material selection menu
        /// </summary>
        private void PrintDroidMaterialMenu()
        {
            Console.WriteLine("What Droid material do you want?");
            Console.WriteLine("1. Aluminum   Cost: $75.00");
            Console.WriteLine("2. Titanium   Cost: $200.00");
            Console.WriteLine("3. Steel      Cost: $120.00");
        }
        /// <summary>
        /// Prints the Droid Color selection menu
        /// </summary>
        private void PrintDroidColorMenu()
        {
            Console.WriteLine("What color Droid do you want?");
            Console.WriteLine("1. Red");
            Console.WriteLine("2. Blue");
            Console.WriteLine("3. Unpainted");
        }
        /// <summary>
        /// Prints the Boolean selection menu
        /// </summary>
        private void PrintBooleanMenu()
        {
            Console.WriteLine("Enter 1 for Yes, or enter 2 for No");
        }
        //********************************************************************************************************************
        //Print The Array
        //********************************************************************************************************************
        /// <summary>
        /// Prompts and printst the contents of the array
        /// </summary>
        /// <param name="outputList"></param>
        public void PrintList(string outputList)
        {
            Console.WriteLine("Printing the List");
            Console.WriteLine();
            Console.WriteLine(outputList);
        }
        //********************************************************************************************************************
        //Error Messages
        //********************************************************************************************************************
        /// <summary>
        /// Prints an error message for any incorrect selection input
        /// </summary>
        private void PrintErrorMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("This is not a valid entry");
            Console.WriteLine("Please make a valid choice");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
