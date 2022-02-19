using ConsoleAppProject.Helpers;
using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This class allows the user to convert distances measured and 
    /// in one unit of distance into another unit of distance calculate and
    /// output will display.
    /// 
    /// </summary>
    /// <author>
    /// Sudath Nawagamuwage version 0.1
    /// </author>
    public class DistanceConverter
    {
        public const double FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        public const double FEET_IN_METRES = 3.28084;

        public string [] UnitChoices = {
            DistanceUnits.Miles.ToString(), 
            DistanceUnits.Metres.ToString(), 
            DistanceUnits.Feet.ToString(),
        };


        //public const string FEET = "feet";
        //public const string METRES = "metres";
        //public const string MILES = "miles";

        private double fromDistance;
        private double toDistance;

        private DistanceUnits fromUnit;
        private DistanceUnits toUnit;

        //private string fromUnit;
        //private string toUnit;

        /// <summary>
        /// Set a constructer to set the default value. 
        /// </summary>
        public DistanceConverter()
        {
            fromUnit = DistanceUnits.Miles;
            toUnit = DistanceUnits.Feet;

            //fromUnit = MILES;
            //toUnit = FEET;
        }

        /// <summary>
        /// In this method ask the user to input the didtance and distance unit and 
        /// calculate the sane distance in unnit.
        /// </summary>
        public void ConvertDistance()
        {
            ConsoleHelper.OutputHeading("Distance Converter");
            toUnit = SelectUnit("to");
            fromUnit = SelectUnit("from");

            Console.WriteLine($"\n Converting {fromUnit} to {toUnit}");

            fromDistance = ConsoleHelper.InputNumber($" Please enter the number of {fromUnit} >");

            //fromDistance = InputDistance($" Please enter the number of {fromUnit} >");

            CalculateDistance();

            OutputDestance();
        }

        private DistanceUnits SelectUnit(string toOrFrom)
        {
            Console.WriteLine($" Please select the {toOrFrom} distamce unit > ");
            int choice = ConsoleHelper.SelectChoice(UnitChoices);
            return ExecuteChoice(choice);
        }

        /// <summary>
        /// Caculating the distance form unit value.
        /// </summary>
        private void CalculateDistance()
        {
            if (fromUnit == DistanceUnits.Miles & toUnit == DistanceUnits.Feet)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if (fromUnit == DistanceUnits.Feet & toUnit == DistanceUnits.Miles)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
            //if (fromUnit == MILES & toUnit == FEET)
            //{
            //    toDistance = fromDistance * FEET_IN_MILES;
            //}
            //else if (fromUnit == FEET & toUnit == MILES)
            //{
            //    toDistance = fromDistance / FEET_IN_MILES;
            //}
            //else if (fromUnit == MILES & toUnit == METRES)
            //{
            //    toDistance = fromDistance * METRES_IN_MILES;
            //}
            //else if (fromUnit == METRES & toUnit == MILES)
            //{
            //    toDistance = fromDistance / METRES_IN_MILES;
            //}
            //else if (fromUnit == METRES & toUnit == FEET)
            //{
            //    toDistance = fromDistance * FEET_IN_METRES;
            //}
            //else if (fromUnit == FEET & toUnit == METRES)
            //{
            //    toDistance = fromDistance / FEET_IN_METRES;
            //}
        }

        /// <summary>
        /// 
        /// 
        /// </summary>
        //private string SelectUnit(string prompt)
        //{
        //   // string choice = DisplayChoices(prompt);
        //    string unit = ExecuteChoice(choice);
        //    Console.WriteLine($"\n You have chosen {unit}");
        //    return unit;
        //}
        //private static string ExecuteChoice(string choice)
        //{
        //    switch (choice)
        //    {
        //        case "1": unit = DistanceUnits.Feet; break;
        //        case "2": unit = DistanceUnits.Metres; break;
        //        case "3": unit = DistanceUnits.Miles; break;
        //        default: unit = DistanceUnits.NoUnit; break;
        //    }
        //    if (unit == DistanceUnits.NoUnit)
        //    {
        //        Console.WriteLine("Invalid Choice");
        //        Console.WriteLine("Must be digit i to 3");
        //    }
        //    return unit;

        //}
        private static DistanceUnits ExecuteChoice(int choice)
        {
            string unit = "INVALID CHOISE";

            if (choice == 1)
            {
                return DistanceUnits.Feet;
            }
            else if (choice == 2)
            {
                return DistanceUnits.Metres;
            }
            else if (choice == 3)
            {
                return DistanceUnits.Miles;
            }

            Console.WriteLine($"\n You have chosen {unit}");
            return DistanceUnits.NoUnit;

            // return null;
        }

        /// <summary>
        /// Display the menu of distance and then prompt
        /// user to select one and return it.
        /// </summary>
        //private DistanceUnits SelectUnit(string prompt)
        //{
        //    Console.ForegroundColor = ConsoleColor.Yellow;

        //    Console.WriteLine();
        //    Console.WriteLine($" 1. {DistanceUnits.Feet}");
        //    Console.WriteLine($" 2. {DistanceUnits.Metres}");
        //    Console.WriteLine($" 3. {DistanceUnits.Miles}");
        //    Console.WriteLine();

        //    Console.Write(prompt);
        //    string choice = Console.ReadLine();
        //    return ExecuteChoice(choice);
            
        //}

        /// <summary>
        /// Prompt the user to enter the distance in unit value
        /// Input number as a double number.
        /// </summary>        
        //private double InputDistance(string prompt)
        //{
        //    Console.WriteLine(prompt);
        //    string value = Console.ReadLine();
        //    return Convert.ToDouble(value);
        //    // miles = ConsoleHelper.InputNumber("Please enter the number of miles >");
        //}
        private void OutputDestance()
        {
            Console.WriteLine($"\n { fromDistance} { fromUnit} " +
                $" is { toDistance} { toUnit} !\n");
        }
        /// <summary>
        /// Output the short discription of the apllication and 
        /// print the name of the author.
        /// </summary>
        //private void OutputHeading()
        //{
        //    Console.ForegroundColor = ConsoleColor.Green;

        //    Console.WriteLine("\n ---------------------------------");
        //    Console.WriteLine("       Distance Converter         ");
        //    Console.WriteLine("     by Sudath Nawagamuwage           ");
        //    Console.WriteLine(" ---------------------------------\n");
        //}
    }   
}
