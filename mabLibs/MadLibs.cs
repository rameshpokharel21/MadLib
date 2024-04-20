using System;
using System.Collections.Generic;

namespace mabLibs
{
    public class MadLibs
    {
        private Random random;

        public MadLibs()
        {
            random = new Random();
        }

        public void DisplayRandomMadLib(Dictionary<string, string> inputValues)
        {
            int madLibIndex = random.Next(3);

            if (madLibIndex == 0)
            {
                MadLibOne(inputValues);
            }
            else if (madLibIndex == 1)
            {
                MadLibTwo(inputValues);
            }
            else
            {
                MadLibThree(inputValues);
            }
        }

        private void MadLibOne(Dictionary<string, string> inputValues)
        {
            // Mad Lib One
            Console.WriteLine($"This weekend I am going camping with {inputValues["ProperNounPersonName"]}. I packed \n" +
               $"my lantern, sleeping bag, and {inputValues["Noun"]}. I am so {inputValues["AdjectiveFeeling"]} to {inputValues["Verb"]} in a \n" +
               $"tent. I am {inputValues["AdjectiveFeeling"]} we might see a {inputValues["Animal"]}, they are kind of dangerous. \n" +
               $"We are going to hike, fish, and {inputValues["Verb"]}. I have heard that the \n" +
               $"{inputValues["Color"]} lake is great for {inputValues["VerbEndingInIng"]}. Then we will {inputValues["AdverbEndingInLy"]} hike through \n" +
               $"the forest for {inputValues["Number"]} {inputValues["MeasureOfTime"]}. If I see a {inputValues["Color"]} {inputValues["Animal"]} \n" +
               $"while hiking, I am going to bring it home as a pet! At night we will \n" +
               $"tell {inputValues["Number"]} {inputValues["SillyWord"]} stories and roast {inputValues["Noun"]} around the \n" +
               $"campfire!!");
        }


        private void MadLibTwo(Dictionary<string, string> inputValues)
        {
            // Mad Lib Two
            Console.WriteLine($"It was about {inputValues["Number:"]} {inputValues["MeasureOfTime"]} ago when I came to the hospital in a {inputValues["ModeOfTransportation"]}.  \n" +
                $"The hospital is a/an {inputValues["Adjective"]} place, there are a lot of {inputValues["Adjective"]} {inputValues["Noun"]} here. \n" +
                $"There are nurses here who have {inputValues["Color"]} {inputValues["PartOfTheBody"]}. \n" +
                $"If someone wants to come into my room I told them that they have to {inputValues["Verb"]} first. \n" +
                $"I have decorated my room with {inputValues["Number"]} {inputValues["Noun"]}. \n" +
                $"Today a doctor came into my room and they were wearing a {inputValues["Noun"]} on their {inputValues["PartOfTheBody"]} .  \n" +
                $"I heard that all doctors {inputValues["Verb"]} {inputValues["Noun"]}   every day for breakfast.  \n" +
                $"The most {inputValues["Adjective"]} thing about being in the hospital is the {inputValues["SillyWord"]} {inputValues["Noun"]}! \n");
        }

        private void MadLibThree(Dictionary<string, string> inputValues)
        {
            Console.WriteLine($"Dear {inputValues["ProperNounPersonName"]}, \n" +
                "\n" +
                $"I am writing to you from a {inputValues["Adjective"]} castle in an enchanted forest. \n" +
                $"I found myself here one day after going for a ride on a {inputValues["Color"]} {inputValues["Animal"]} in {inputValues["Place"]}. \n" +
                $"There are {inputValues["Adjective"]} {inputValues["MagicalCreaturePlural"]} and {inputValues["Adjective"]} {inputValues["MagicalCreaturePlural"]} here! \n" +
                $"In the {inputValues["RoomInAHouse"]} there is a pool full of {inputValues["Noun"]}. \n" +
                $"I fall asleep each night on a {inputValues["Noun"]} of {inputValues["Noun"]} and dream of {inputValues["Adjective"]} {inputValues["NounPlural"]}. \n" +
                $"It feels as though I have lived here for {inputValues["Number"]} {inputValues["MeasureOfTime"]}. \n" +
                $"I hope one day you can visit, although the only way to get here now is {inputValues["VerbEndingInIng"]} on a {inputValues["Adjective"]} {inputValues["Noun"]}!! \n");
        }

    }
}
