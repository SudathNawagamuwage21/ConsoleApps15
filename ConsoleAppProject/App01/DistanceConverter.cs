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

        public const string FEET = "feet";
        public const string METRES = "metres";
        public const string MILES = "miles";

        private double fromDistance;
        private double toDistance;

        private string fromUnit;
        private string toUnit;

        //public DistanceConverter()
        //{
        //    fromUnit = MILES;
        //    toUnit = FEET;
        //}

        public void ConvertDistance()
        {
            OutputHeadding();

            fromUnit = SelectUnit("Please select the from distamce unit > ");

            toUnit = SelectUnit("Please select the to distance unit > ");

            Console.WriteLine($"\n Converting {fromUnit} to {toUnit}");

            fromDistance = InputDistance($"Please enter the number of {fromUnit} >");
            
            //CalculateFeet();

            OutputDestance();
        }

        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);

            return ExecuteChoice(choice);

        }

        private static string ExecuteChoice(string choice)
        {
            if (choice.Equals("1"))
            {
                return FEET;
            }
            else if (choice.Equals("2"))
            {
                return METRES;
            }
            else if (choice.Equals("3"))
            {
                return MILES;
            }
            return null;
        }

        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine(prompt);
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METRES}");
            Console.WriteLine($" 3. {MILES}");

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
        }

        private void OutputHeadding()
        {
            Console.WriteLine("\n ---------------------------------");
            Console.WriteLine("       Distance Converter         ");
            Console.WriteLine("     by Sudath Nawagamuwage           ");
            Console.WriteLine(" ---------------------------------\n");
        }

        /// <summary>
        /// Prompt the user to enter the distance in miles
        /// Input number as a double number
        /// </summary>        
        private double InputDistance(string prompt)
        {
            Console.WriteLine(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
            // miles = ConsoleHelper.InputNumber("Please enter the number of miles >");
        }
       
        private void OutputDestance ()
        {
            Console.WriteLine($"{ fromDistance} { fromUnit} " +
                $"is {toDistance} { toUnit} !");  
        }

    }   
}
