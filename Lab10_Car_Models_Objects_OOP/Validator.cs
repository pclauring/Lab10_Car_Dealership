using System;

namespace Lab10_Car_Models_Objects_OOP
{
    class Validator
    {
        public static int GetValidSelection(string prompt, int menuItemNumber)
        {
            bool success = false;
            int selection = 0;
            while (!success)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                success = int.TryParse(input, out selection);

                if (selection > menuItemNumber || selection < 1)
                {
                    Console.Write($"Not a valid input... ");
                    success = false;
                }
            }
            return selection;
        }

        public static bool GetYesorNo()
        {
            bool valid = true;
            bool repeat = true;
            while (valid)
            {
                string answer = Console.ReadLine().ToLower();
                if (answer == "y" || answer == "yes")
                {
                    valid = false;
                    repeat = true;
                }
                else if (answer == "n" || answer == "no")

                {
                    valid = false;
                    repeat = false;
                }
                else
                {
                    Console.Write("Did not enter a valid input. Please enter (Y/N): ");
                }
            }

            return repeat;
        }
    }
}
