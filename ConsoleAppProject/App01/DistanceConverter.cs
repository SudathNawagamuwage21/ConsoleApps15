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

        public const string FEET = "Feet";

        public const string METRES = "Metres";
        
        public const string MILES = "Metres";

        public double FromDistance { get; set; }
        public double ToDistance { get; set; }

        public DistanceUnits FromUnit { get; set; }
        public DistanceUnits ToUnit { get; set; }

        /// <summary>
        /// Set a constructer to set the default value. 
        /// </summary>
        public DistanceConverter()
        {
            FromUnit = DistanceUnits.Miles;
            ToUnit = DistanceUnits.Feet;
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
            ConsoleHelper.OutputHeading("\t \tDistance Converter");
            FromUnit = SelectUnit("from");
            ToUnit = SelectUnit("to");
            
            Console.WriteLine($"\n Converting {FromUnit} to {ToUnit}");

            FromDistance = ConsoleHelper.InputNumber($" Please enter the number of {FromUnit} >");

            CalculateDistance();

            OutputDestance();
        }

        /// <summary>
        /// Prompt the users to select the distance their setected
        /// </summary>
        private DistanceUnits SelectUnit(string toOrFrom)
        {
            Console.WriteLine($" Please select the {toOrFrom} distance unit > ");
            Console.WriteLine();
            int choice = ConsoleHelper.SelectChoice(UnitChoices);
            return ExecuteChoice(choice);
        }

        /// <summary>
        /// Caculating the distance form unit value.
        /// </summary>
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
         public void CalculateDistance()
        {
            if (FromUnit == DistanceUnits.Miles & ToUnit == DistanceUnits.Feet)
            {
                ToDistance = FromDistance * FEET_IN_MILES;
            }
            else if (FromUnit == DistanceUnits.Feet & ToUnit == DistanceUnits.Miles)
            {
                ToDistance = FromDistance / FEET_IN_MILES;
            }
            else if (FromUnit == DistanceUnits.Miles & ToUnit == DistanceUnits.Metres)
            {
                ToDistance = FromDistance * METRES_IN_MILES;
            }
            else if (FromUnit == DistanceUnits.Metres & ToUnit == DistanceUnits.Miles)
            {
                ToDistance = FromDistance / METRES_IN_MILES;
            }
            else if (FromUnit == DistanceUnits.Metres & ToUnit == DistanceUnits.Feet)
            {
                ToDistance = FromDistance * FEET_IN_METRES;
            }
            else if (FromUnit == DistanceUnits.Feet & ToUnit == DistanceUnits.Metres)
            {
                ToDistance = FromDistance / FEET_IN_METRES;
            }
        }
        /// <summary>
        /// Output a message for distance the users who are
        /// seleceted 
        /// </summary>
        private void OutputDestance()
        {
            Console.WriteLine($"\n { FromDistance} { FromUnit} " +
                $" is { ToDistance} { ToUnit} !\n");
        }
      }   
}
