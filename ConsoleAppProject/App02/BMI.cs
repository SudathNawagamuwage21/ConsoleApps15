using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject.App02
{
    
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

        public double Index { get; set; }

        // Metric Details

        public double Kilograms { get; set; }
        public double Metres { get; set; }
        public double Feet { get; set; }

        // Imperial Details

        public double Pounds { get; set; }
        public int Inches { get; set; }

        /// <summary>
        /// Prompt the user to select Imperial or Matric units.
        /// Input the user's height and weight and then calculate 
        /// their MBI value. Output which weight catergory they fall into
        /// </summary>
        public void CalculaterIndex()
        {
            ConsoleHelper.OutputHeading("\t\tBody Mass Index Calculator");
            UnitSystem unitSystem = SelectUnits();

            if (unitSystem == UnitSystem.Metric)
            {
                InputMetricDetails();
                Index = Kilograms / (Metres * Metres);
            }
            else
            {
                InputImperialDetails();
                Index = Pounds * 703 / (Inches * Inches);
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
                " Enter your height to nearrest feet and inches ");
            double Feet = ConsoleHelper.InputNumber(
                "\n Enter your height in feet > ");
            Inches = (int)ConsoleHelper.InputNumber(
                " Enter your height in inches > ");
            Console.WriteLine();

            Inches += (int)Feet * InchesInFeet;

            Console.WriteLine(
                " Enter your weight to the nearest stones and pounds");
            double stones = ConsoleHelper.InputNumber(
                " Enter your weight in stones > ");
            Pounds = ConsoleHelper.InputNumber(
                " Enter your weight in pounds > ");
            Console.WriteLine();

            Pounds += stones * PoundsInStones;
        }

        /// <summary>
        /// Input the users height in meteres and their
        /// weight in kilograms
        /// </summary>
        private void InputMetricDetails()
        {
            Metres = ConsoleHelper.InputNumber(
                 " \n Enter your height in metres > ");

            Kilograms = ConsoleHelper.InputNumber(
                " Enter your weight in kilograms > ");
            Console.WriteLine();
        }

        /// <summary>
        /// output the users MBI and their weight category 
        /// from underweight to obese
        /// </summary>
        public void OutputHealthMessage()
        {
            if (Index < UnderWeight)
            {
                Console.WriteLine($" Your BMI is {Index}, " +
                    $"You are underweight! ");
            }
            else if (Index <= NormalRange)
            {
                Console.WriteLine($" Your BMI is {Index}, " +
                    $"You are in the normal range! ");
            }
            else if (Index <= OverWeight)
            {
                Console.WriteLine($" Your BMI is {Index}, " +
                    $"You are overweight! ");
            }
            else if (Index <= ObeseLevel1)
            {
                Console.WriteLine($" Your BMI is {Index}, " +
                    $"You are obese class I ");
            }
            else if (Index <= ObeseLevel2)
            {
                Console.WriteLine($" Your BMI is {Index}, " +
                    $"You are obese class II ");
            }
            else if (Index <= ObeseLevel3)
            {
                Console.WriteLine($" Your BMI is {Index}, " +
                    $"You are obese class III ");

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
