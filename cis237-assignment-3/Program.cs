using System;

namespace cis237_assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BufferHeight = Int16.MaxValue - 1;
            Console.WindowHeight = 40;
            Console.WindowWidth = 140;
            UserInterface ui = new UserInterface();
            DroidCollection droid = new DroidCollection();

            int choice = ui.GetUserInput();

            while (choice != 3)
            {
                if (choice == 1)
                {
                    droid.AddDroid(ui);
                }
                if (choice == 2)
                {
                    string outputString = "";
                    droid.PrintDroids(ui, outputString);
                }
                choice = ui.GetUserInput();
            }
        }
    }
}
