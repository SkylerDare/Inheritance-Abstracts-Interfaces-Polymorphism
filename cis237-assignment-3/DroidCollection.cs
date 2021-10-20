using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment_3
{
    class DroidCollection
    {
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
