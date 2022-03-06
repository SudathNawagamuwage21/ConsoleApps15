using ConsoleAppProject.Helpers;
using System;
using System.Text;

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

        public double Centimetres { get; set; }

        // Imperial Details

        public int Inches { get; set; }
        public int Feet { get; set; }
        public int Pounds { get; set; }
        public int Stones { get; set; }

        public UnitSystem UnitSystem
        {
            get => default;
        }

        private double metres;
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
                CalculateMetricBMI();
            }
            else
            {
                InputImperialDetails();
                CalculateImperialBMI();

                //Index = Pounds * 703 / (Inches * Inches);
            }
            Console.WriteLine(GetHealthMessage());
            Console.WriteLine(GetBameMessage());

            //OutputHealthMessage();
        }

        /// <summary>
        /// Calulate the Imperial
        /// </summary>
        public void CalculateImperialBMI()
        {
            Inches += Feet * InchesInFeet;
            Pounds += Stones * PoundsInStones;

            Index = (double) Pounds * 703 / (Inches * Inches);
        }

        /// <summary>
        /// Calulate the Metric
        /// </summary>
        public void CalculateMetricBMI()
        {
            metres = (double)Centimetres / 100;
            Index =  Kilograms / (metres * metres);
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
            Console.WriteLine(" Enter your height to nearrest feet and inches ");
            Console.WriteLine();

            Feet = (int)ConsoleHelper.InputNumber("\n Enter your height in feet > ");
            Inches = (int)ConsoleHelper.InputNumber(" Enter your height in inches > ");
            
            Console.WriteLine();
            Console.WriteLine(" Enter your weight to the nearest stones and pounds");
            Console.WriteLine();

            Stones = (int)ConsoleHelper.InputNumber(" Enter your weight in stones > ");
            Pounds = (int)ConsoleHelper.InputNumber(" Enter your weight in pounds > ");
                 
        }

        /// <summary>
        /// Input the users height in meteres and their
        /// weight in kilograms
        /// </summary>
        private void InputMetricDetails()
        {
            Centimetres = (int)ConsoleHelper.InputNumber(" \n Enter your height in centimetres > ");

            metres = (double)Centimetres / 100;

            Kilograms = ConsoleHelper.InputNumber(" Enter your weight in kilograms > ");
            Console.WriteLine();
        }

        /// <summary>
        /// output the users MBI and their weight category 
        /// from underweight to obese
        /// </summary>
        public string GetHealthMessage()
        {
            StringBuilder massage = new StringBuilder("\n");

            if (Index < UnderWeight)
            {
                massage.Append($" Your BMI is {Index:0.00}, " +
                    $"You are underweight! ");
            }
            else if (Index <= NormalRange)
            {
                massage.Append($" Your BMI is {Index:0.00}, " +
                    $"You are in the normal range! ");
            }
            else if (Index <= OverWeight)
            {
                massage.Append($" Your BMI is {Index:0.00}, " +
                    $"You are overweight! ");
            }
            else if (Index <= ObeseLevel1)
            {
                massage.Append($" Your BMI is {Index:0.00}, " +
                    $"You are obese class I ");
            }
            else if (Index <= ObeseLevel2)
            {
                massage.Append($" Your BMI is {Index:0.00}, " +
                    $"You are obese class II ");
            }
            else if (Index >= ObeseLevel3)
            {
                massage.Append($" Your BMI is {Index:0.00}, " +
                    $"You are obese class III ");
            }

            return massage.ToString();
        }
        /// <summary>
        /// Output a message for BAME users who are
        /// at higher risk
        /// </summary>
        public string GetBameMessage()
        {
            StringBuilder massage = new StringBuilder("\n");

            massage.Append(" If you are Black, Asian or other minority");
            massage.Append(" ethnic groups, you have a higher risk");
            massage.Append("\n");
            massage.Append("\t Adults 23.0 or more are at increased risk");
            massage.Append("\t Adults 27.5 or more are at high risk");
            
            return massage.ToString();
        }

        public UnitSystem UnitSystem1
        {
            get => default;
            set
            {
            }
        }
    }

}
