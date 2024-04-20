using System;
using System.Collections.Generic;

namespace mabLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            // UserInput to get values
            UserInput userInput = new UserInput();

            // Gets input as dict
            Dictionary<string, string> inputValues = userInput.GetInputValues();

            // Create the MadLibs class
            MadLibs madLibs = new MadLibs();

            //method to display random Lib with values
            madLibs.DisplayRandomMadLib(inputValues);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

            Console.Clear();
        }
    }
}
