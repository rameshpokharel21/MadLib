using System;
using System.Collections.Generic;

namespace mabLibs;

     class Program
    {
        static void Main(string[] args)
        {
            // UserInput to get values
            UserInput userInput = new UserInput();

            // Gets input as dict
            Dictionary<string, string> inputValues = userInput.GetInputValues();

            // Create the MadLibs class
            MadLibs madLibs = new MadLibs(inputValues);
            
            //method to display random Lib with values
            madLibs.DisplayRandomMadLib();
            

        
            
        }
    }

