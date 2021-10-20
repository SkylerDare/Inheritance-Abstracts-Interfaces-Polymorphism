using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment_3
{
    class UserInterface
    {
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
            int type = Int32.Parse(input);
            return type;
        }
        
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

        public int GetLanguageInt()
        {
            int choice = 0;
            while (choice <= 0)
            {
                Console.WriteLine("How many languages do you want the Droid to know?");
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
        public int GetShipInt()
        {
            int choice = 0;
            while (choice <= 0)
            {
                Console.WriteLine("How many Ships do you want the Droid to be compatible with?");
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

        private void PrintMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add a new Droid");
            Console.WriteLine("2. Print Droid List");
            Console.WriteLine("3. Exit");
        }

        private void PrintDroidTypeMenu()
        {
            Console.WriteLine("What type of Droid do you want to add?");
            Console.WriteLine("1. Protocol Droid");
            Console.WriteLine("2. Utility Droid");
            Console.WriteLine("3. Janitor Droid");
            Console.WriteLine("4. Astromech Droid");
        }

        private void PrintDroidMaterialMenu()
        {
            Console.WriteLine("What Droid material do you want?");
            Console.WriteLine("1. Aluminum");
            Console.WriteLine("2. Titanium");
            Console.WriteLine("3. Steel");
        }

        private void PrintDroidColorMenu()
        {
            Console.WriteLine("What color Droid do you want?");
            Console.WriteLine("1. Red");
            Console.WriteLine("2. Blue");
            Console.WriteLine("3. Unpainted");
        }

        private void PrintBooleanMenu()
        {
            Console.WriteLine("Enter 1 for Yes, or enter 2 for No");
        }

        public void PrintList(string outputList)
        {
            Console.WriteLine("Printing the List");
            Console.WriteLine();
            Console.WriteLine(outputList);
        }

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
