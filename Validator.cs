using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotLab
{
    public static class Validator
    {
        public static int GetValidCarSelection(int maxSelection)
        {
            int selection = -1;
            bool isValidInput = false;

            do
            {
                Console.Write("Which car would you like?  ");
                string input = Console.ReadLine();

                try
                {
                    if (int.TryParse(input, out selection))
                    {
                        selection--; // Subtract 1 to get the selected car's index

                        if (selection >= 0 && selection < maxSelection)
                        {
                            isValidInput = true; // Valid selection
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid car number.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid car number.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid car number.");
                }
            } while (!isValidInput);

            return selection;
        }

        public static bool ShouldContinue()
        {
            bool isValidResponse = false;
            bool shouldContinue = false;

            do
            {
                Console.Write("Do you want to continue (yes/no): ");
                string response = Console.ReadLine().Trim().ToLower();

                if (response == "yes")
                {
                    shouldContinue = true;
                    isValidResponse = true;
                }
                else if (response == "no")
                {
                    shouldContinue = false;
                    isValidResponse = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                }
            } while (!isValidResponse);

            return shouldContinue;
        }
    }
}