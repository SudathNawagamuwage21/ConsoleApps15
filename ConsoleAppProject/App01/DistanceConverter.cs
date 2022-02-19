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

        public string[] UnitChoices = {
            DistanceUnits.Miles.ToString(),
            DistanceUnits.Metres.ToString(),
            DistanceUnits.Feet.ToString(),
        };

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

            CalculateDistance();

            OutputDestance();
        }

        private DistanceUnits SelectUnit(string toOrFrom)
        {
            Console.WriteLine($" Please select the {toOrFrom} distamce unit > ");
            Console.WriteLine();
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
            else if (fromUnit == DistanceUnits.Miles & toUnit == DistanceUnits.Metres)
            {
                toDistance = fromDistance * METRES_IN_MILES;
            }
            else if (fromUnit == DistanceUnits.Metres & toUnit == DistanceUnits.Miles)
            {
                toDistance = fromDistance / METRES_IN_MILES;
            }
            else if (fromUnit == DistanceUnits.Metres & toUnit == DistanceUnits.Feet)
            {
                toDistance = fromDistance * FEET_IN_METRES;
            }
            else if (fromUnit == DistanceUnits.Feet & toUnit == DistanceUnits.Metres)
            {
                toDistance = fromDistance / FEET_IN_METRES;
            }
        }

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

        private void OutputDestance()
        {
            Console.WriteLine($"\n { fromDistance} { fromUnit} " +
                $" is { toDistance} { toUnit} !\n");
        }
      }   
}
