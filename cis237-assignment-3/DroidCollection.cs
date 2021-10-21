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
    class DroidCollection
    {
        //*******************************************************
        // Variables
        //*******************************************************
        Droid[] droids = new Droid[100];
        int index = 0;
        int type = 0;
        string material = "";
        string color = "";
        int number = 0;
        bool choiceOne = false;
        bool choiceTwo = false;
        bool choiceThree = false;
        bool choiceFour = false;
        bool choiceFive = false;
        /// <summary>
        /// Add Droid allows the Jawa to enter information about the Droid they want to add to the list.
        /// It prompts them to select from a preset selection list to add information about their Droid.
        /// Once all of the relevant information is entered, the program then determines what type of Droid it is
        /// and assigns all of the information to a new instance of that type. 
        /// </summary>
        /// <param name="ui">Instance of User Interface class</param>
        public void AddDroid(UserInterface ui)
        {
            type = ui.GetDroidType();
            if (type == 1)
            {
                material = ui.GetDroidMaterial();
                color = ui.GetDroidColor();
                number = ui.GetLanguageInt();
                droids[index] = new ProtocolDroid
                        (material,
                         color,
                         number);
                index++;
            }
            if (type == 2)
            {
                material = ui.GetDroidMaterial();
                color = ui.GetDroidColor();
                choiceOne = ui.GetToolboxBoolean();
                choiceTwo = ui.GetComputerBoolean();
                choiceThree = ui.GetArmBoolean();
                droids[index] = new UtilityDroid
                        (material,
                         color,
                         choiceOne,
                         choiceTwo,
                         choiceThree);
                index++;
            }
            if (type == 3)
            {
                material = ui.GetDroidMaterial();
                color = ui.GetDroidColor();
                choiceOne = ui.GetToolboxBoolean();
                choiceTwo = ui.GetComputerBoolean();
                choiceThree = ui.GetArmBoolean();
                choiceFour = ui.GetTrashBoolean();
                choiceFive = ui.GetVacuumBoolean();
                droids[index] = new JanitorDroid
                        (material,
                         color,
                         choiceOne,
                         choiceTwo,
                         choiceThree,
                         choiceFour,
                         choiceFive);
                index++;
            }
            if (type == 4)
            {
                material = ui.GetDroidMaterial();
                color = ui.GetDroidColor();
                choiceOne = ui.GetToolboxBoolean();
                choiceTwo = ui.GetComputerBoolean();
                choiceThree = ui.GetArmBoolean();
                choiceFour = ui.GetFireBoolean();
                number = ui.GetShipInt();
                droids[index] = new AstromechDroid
                        (material,
                         color,
                         choiceOne,
                         choiceTwo,
                         choiceThree,
                         choiceFour,
                         number);
                index++;
            }
        }
        //*******************************************************
        // Constructors
        //*******************************************************
        /// <summary>
        /// The Print Droids method loops through the array and outputs the contents to a string.
        /// </summary>
        /// <param name="ui">Instance of User Interface class</param>
        /// <param name="outputString">The string to be output, holds the contents of the array</param>
        public void PrintDroids(UserInterface ui, string outputString)
        {
            foreach (Droid droid in droids)
            {
                if (droid != null)
                {
                    outputString += droid.ToString() + Environment.NewLine;
                }
            }
            ui.PrintList(outputString);
        }
    }
}
