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
            DistanceUnits.Feet.ToString(),
            DistanceUnits.Metres.ToString(),
            DistanceUnits.Miles.ToString(),
        };

        private double fromDistance;
        private double toDistance;

        private DistanceUnits fromUnit;
        private DistanceUnits toUnit;

        /// <summary>
        /// Set a constructer to set the default value. 
        /// </summary>
        public DistanceConverter()
        {
            fromUnit = DistanceUnits.Miles;
            toUnit = DistanceUnits.Feet;

        }

        /// <summary>
        /// class diagram method
        /// </summary>
        public DistanceUnits DistanceUnits
        {
            get => default;
            set
            {
            }
        }
        
        /// <summary>
        /// In this method ask the user to input the didtance and distance unit and 
        /// calculate the sane distance in unnit.
        /// </summary>
        public void ConvertDistance()
        {
            ConsoleHelper.OutputHeading("Distance Converter");
            fromUnit = SelectUnit("from");
            toUnit = SelectUnit("to");
            

            Console.WriteLine($"\n Converting {fromUnit} to {toUnit}");

            fromDistance = ConsoleHelper.InputNumber($" Please enter the number of {fromUnit} >");

            CalculateDistance();

            OutputDestance();
        }

        /// <summary>
        /// Prompt the users to select the distance their setected
        /// </summary>
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

        /// <summary>
        /// Prompt the user to select feet, Metres and Miles
        /// for entering their choice of destance
        /// </summary>
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
        /// Output a message for distance the users who are
        /// seleceted 
        /// </summary>
        private void OutputDestance()
        {
            Console.WriteLine($"\n { fromDistance} { fromUnit} " +
                $" is { toDistance} { toUnit} !\n");
        }
      }   
}
