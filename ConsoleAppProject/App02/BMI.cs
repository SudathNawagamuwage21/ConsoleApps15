using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Two unit systems measuring weight and height
    /// </summary>
    public enum UnitSystem
    {
        Metric,
        Imperial
    }
    /// <summary>
    /// This class contains for the calculating 
    /// the use's MBI (Body Mass Index) using
    /// imprial or metric Units
    /// </summary>
    /// <author>
    /// Sudath nawagamuwage version 0.1
    /// </author>
    public class BMI
    {
        public const double UnderWeight = 18.5;
        public const double NormalRange = 24.9;
        public const double OverWeight = 29.9;

        public const double ObeseLevel1 = 34.9;
        public const double ObeseLevel2 = 39.9;
        public const double ObeseLevel3 = 40.0;

        public const int InchesInFeet = 12;
        public const int PoundsInStones = 14;

        private double index;

        // Metric Details

        private double kilograms;
        private double metres;

        // Imperial Details

        private double pounds;
        private int inches;

        /// <summary>
        /// Prompt the user to select Imperial or Matric units.
        /// Input the user's height and weight and then calculate 
        /// their MBI value. Output which weight catergory they fall into
        /// </summary>
        public void CalculaterIndex()
        {
            ConsoleHelper.OutputHeading("     Body Mass Index Calculator");
            UnitSystem unitSystem = SelectUnits();

            if (unitSystem == UnitSystem.Metric)
            {
                InputMetricDetails();
                index = kilograms / (metres * metres);
            }
            else
            {
                InputImperialDetails();
                index = pounds * 703 / (inches * inches);
            }

            OutputHealthMessage();
        }
        
        /// <summary>
        /// Prompt the user to select imperial or metric units
        /// for entering their weight and height
        /// </summary>
        private UnitSystem SelectUnits()
        {
            string[] choices = new[]
            {
                "Metric Units",
                "Imperial Units"
            };
            int choice = ConsoleHelper.SelectChoice(choices);

            if (choice == 1)
            {
                return UnitSystem.Metric;
            }
            else return UnitSystem.Imperial;
        }

        /// <summary>
        /// /// Input the users hight in feet and inches 
        /// and their weight in stones and pounds
        /// </summary>
        private void InputImperialDetails()
        {
            Console.WriteLine(
                " Enter your height in feet and inches ");
            double feet = ConsoleHelper.InputNumber(
                "\n Enter your height in feet > ");
            inches = (int)ConsoleHelper.InputNumber(
                " Enter your height in inches > ");

            inches += (int)feet * InchesInFeet;

            Console.WriteLine(
                " Enter your weight in stones and pounds");
            double stones = ConsoleHelper.InputNumber(
                " Enter your weight in stones > ");
            pounds = ConsoleHelper.InputNumber(
                " Enter your weight in pounds > ");

            pounds += stones * PoundsInStones;
        }

        /// <summary>
        /// Input the users height in meteres and their
        /// weight in kilograms
        /// </summary>
        private void InputMetricDetails()
        {
            metres = ConsoleHelper.InputNumber(
                 " \n Enter your height in metres > ");

            kilograms = ConsoleHelper.InputNumber(
                " Enter your weight in kilograms > ");
        }

        /// <summary>
        /// output the users MBI and their weight category 
        /// from underweight to obese
        /// </summary>
        private void OutputHealthMessage()
        {
            if (index < UnderWeight)
            {
                Console.WriteLine($" Your BMI is {index}, " +
                    $"You are underweight! ");
            }
            else if (index <= NormalRange)
            {
                Console.WriteLine($" Your BMI is {index}, " +
                    $"You are in the normal range! ");
            }
            else if (index <= OverWeight)
            {
                Console.WriteLine($" Your BMI is {index}, " +
                    $"You are overweight! ");
            }

            OutputBameMessage();
        }
        /// <summary>
        /// Output a message for BAME users who are
        /// at higher risk
        /// </summary>
        private void OutputBameMessage()
        {
            Console.WriteLine();
            Console.WriteLine(
                " If you are Black, Asian or other minority");
            Console.WriteLine(
                " ethnic groups, you have a higher risk");
            Console.WriteLine();
            Console.WriteLine(
                "\t Adults 23.0 or more are at increased risk");
            Console.WriteLine(
                "\t Adults 27.5 or more are at high risk");
            Console.WriteLine();
        }
    }

}
