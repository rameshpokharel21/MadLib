using System;
using System.Collections.Generic;
using System.Text;

namespace mabLibs;

    public class MadLibs
    {
        
        public Dictionary<string, string> InputValues{get; set;}

        public MadLibs(Dictionary<string, string> inputValues)
        {
    
            InputValues = inputValues;

        }


        public void DisplayRandomMadLib()
        {
            Random random = new Random();
            int madLibIndex = random.Next(3);

            if (madLibIndex == 0)
            {
                MadLibOne();
            }
            else if (madLibIndex == 1)
            {
                MadLibTwo();
            }
            else
            {
                MadLibThree();
            }
        }

        // Mad Lib One
        //uses raw string literals
        private void MadLibOne()
        {
            
            Console.WriteLine(
                $"""
                    ---------------------------------------------------------------------------------------------------

                    This weekend I am going camping with {InputValues["ProperNounPersonName"]}. I packed
                    my lantern, sleeping bag, and {InputValues["Noun"]}. I am so {InputValues["AdjectiveFeeling"]} to {InputValues["Verb"]} in a
                    tent. I am {InputValues["AdjectiveFeeling"]} we might see a {InputValues["Animal"]}, they are kind of dangerous.
                    We are going to hike, fish, and {InputValues["Verb"]}. I have heard that the
                    {InputValues["Color"]} lake is great for {InputValues["VerbEndingInIng"]}. Then we will {InputValues["AdverbEndingInLy"]} hike through
                    the forest for {InputValues["Number"]} {InputValues["MeasureOfTime"]}. If I see a {InputValues["Color"]} {InputValues["Animal"]}
                    while hiking, I am going to bring it home as a pet! At night we will
                    tell {InputValues["Number"]} {InputValues["SillyWord"]} stories and roast {InputValues["Noun"]} around the
                    campfire!!
                    
                    --------------------------------------------------------------------------------------------------
                """
            );
        }

        //uses StringBuilder
        private void MadLibTwo()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("\n-----------------------------------------------------------------------------------");
            builder.AppendFormat($"It was about {InputValues["Number"]} {InputValues["MeasureOfTime"]} ago when I came to the hospital in a {InputValues["ModeOfTransportation"]}.  \n");
            builder.AppendFormat($"The hospital is a/an {InputValues["Adjective"]} place, there are a lot of {InputValues["Adjective"]} {InputValues["Noun"]} here. \n");
            builder.AppendFormat($"There are nurses here who have {InputValues["Color"]} {InputValues["PartOfTheBody"]}. \n");
            builder.AppendFormat($"If someone wants to come into my room I told them that they have to {InputValues["Verb"]} first. \n");
            builder.AppendFormat($"I have decorated my room with {InputValues["Number"]} {InputValues["Noun"]}. \n");
            builder.AppendFormat($"Today a doctor came into my room and they were wearing a {InputValues["Noun"]} on their {InputValues["PartOfTheBody"]} .  \n");
            builder.AppendFormat($"I heard that all doctors {InputValues["Verb"]} {InputValues["Noun"]}   every day for breakfast.  \n");
            builder.AppendFormat($"The most {InputValues["Adjective"]} thing about being in the hospital is the {InputValues["SillyWord"]} {InputValues["Noun"]}! \n");
            builder.AppendLine("\n-----------------------------------------------------------------------------------");
            Console.WriteLine(builder.ToString());
        }

        
        private void MadLibThree()
        {
            Console.WriteLine(
                $"""
                    -------------------------------------------------------------------------------------------------

                    Dear {InputValues["ProperNounPersonName"]},
                    
                    I am writing to you from a {InputValues["Adjective"]} castle in an enchanted forest.
                    I found myself here one day after going for a ride on a {InputValues["Color"]} {InputValues["Animal"]} in {InputValues["Place"]}.
                    There are {InputValues["Adjective"]} {InputValues["MagicalCreaturePlural"]} and {InputValues["Adjective"]} {InputValues["MagicalCreaturePlural"]} here!
                    In the {InputValues["RoomInAHouse"]} there is a pool full of {InputValues["Noun"]}.
                    I fall asleep each night on a {InputValues["Noun"]} of {InputValues["Noun"]} and dream of {InputValues["Adjective"]} {InputValues["NounPlural"]}.
                    It feels as though I have lived here for {InputValues["Number"]} {InputValues["MeasureOfTime"]}.
                    I hope one day you can visit, although the only way to get here now is {InputValues["VerbEndingInIng"]} on a {InputValues["Adjective"]} {InputValues["Noun"]}!!

                    --------------------------------------------------------------------------------------------------
                """
                );
        }

    }

