using System;
using System.Collections.Generic;

namespace mabLibs
{
    public class UserInput
    {
        public Dictionary<string, string> GetInputValues()
        {
            Dictionary<string, string> inputValues = new Dictionary<string, string>();

            // Define keys
            Dictionary<string, string> prompts = new Dictionary<string, string>
            {
                { "Proper Noun (Person’s Name):", "ProperNounPersonName" },
                { "Noun:", "Noun" },
                { "Adjective (Feeling):", "AdjectiveFeeling" },
                { "Verb:", "Verb" },
                { "Adjective:", "Adjective" },
                { "Animal:", "Animal" },
                { "Color:", "Color" },
                { "Verb (ending in ing):", "VerbEndingInIng" },
                { "Adverb (ending in ly):", "AdverbEndingInLy" },
                { "Number:", "Number" },
                { "Measure of Time:", "MeasureOfTime" },
                { "Silly Word:", "SillyWord" },
                { "Mode of Transportation:", "ModeOfTransportation" },
                { "Part of the Body:", "PartOfTheBody" },
                { "Magical Creature (Plural):", "MagicalCreaturePlural" },
                { "Place:", "Place" },
                { "Room in a House:", "RoomInAHouse" },
                { "Noun (Plural):", "NounPlural" }
            };

            // user input using defined libs
            foreach (var prompt in prompts)
            {
                PromptInput(prompt.Key, prompt.Value, inputValues);
            }

            return inputValues;
        }

        // prompt input and add to dict
        private void PromptInput(string promptMessage, string key, Dictionary<string, string> inputValues)
        {
            Console.WriteLine(promptMessage);
            string input = Console.ReadLine();

            // Check null or empty
            if (!string.IsNullOrEmpty(input))
            {
                inputValues.Add(key, input);
            }
            else
            {
                Console.WriteLine("Input cannot be null or empty. Please try again.");
                PromptInput(promptMessage, key, inputValues); // Prompt the user again
            }
        }
    }
}
