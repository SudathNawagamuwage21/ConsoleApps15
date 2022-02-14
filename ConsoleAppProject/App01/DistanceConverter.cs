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

        public const string FEET = "feet";
        public const string METRES = "metres";
        public const string MILES = "miles";

        private double fromDistance;
        private double toDistance;

        private string fromUnit;
        private string toUnit;

        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
        }


        /// <summary>
        /// 
        /// </summary>

        public void ConvertDistance()
        {
            fromUnit = SelectUnit("Please select the from distamce unit > ");
            toUnit = SelectUnit("Please select the to distance unit > ")

            OutputHeadding($"Converting {fromUnit} to {toUnit}");

            fromDistance = InputDistance($"Please enter the number of {fromUnit} >");
            
            //CalculateFeet();

            OutputDestance();
        }

        private string SelectUnit(string prompt)
        {
            Console.WriteLine(prompt);
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METRES}");
            Console.WriteLine($" 3. {MILES}");

            Console.Write(prompt);
            string choice = Console.ReadLine();

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

        //public void FeetToMiles()
        //{
        //    OutputHeadding(" Converting Feet to Miles ");

        //    feet = InputDistance("Please enter the number of feet >");
        //    CalculateMiles();
        //    OutputDestance(feet, nameof(feet), miles, nameof(miles));
        //}
        //public void MilesToMetres()
        //{
        //    OutputHeadding(" Converting Miles to Metres ");

        //    miles = InputDistance("Please enter the number of miles >");
        //    CalculateMetres();
        //    OutputDestance(miles, nameof(miles), metres, nameof(metres));
        //}
        //private int InputChoices()

        //{
        //    Console.WriteLine(" Enter the choices");
        //    Console.WriteLine(" 1.Miles  ");
        //    Console.WriteLine(" 2.Feet  ");
        //    Console.WriteLine(" 3.Metres ");

        //    int value = (int)ConsoleHelper.InputNumber("enter your choices > ", 1, 3);

        //    if (value == 1)
        //    {
        //        return 1;
        //    }
        //    else if (value == 2)
        //    {
        //        return 2;
        //    }
        //    else if (value == 3)
        //    {
        //        return 3;
        //    }
        //    else
        //    {
        //       return 0;
        //    }

        //}
        private void OutputHeadding(string prompt)
        {
            Console.WriteLine("\n ---------------------------------");
            Console.WriteLine("       Distance Converter         ");
            Console.WriteLine("     by Sudath Nawagamuwage           ");
            Console.WriteLine(" ---------------------------------\n");

            Console.WriteLine(prompt);
            Console.WriteLine();


        }

        /// <summary>
        /// Prompt the user to enter the distance in miles
        /// Input number as a double number
        /// </summary>        
        private double InputDistance(string prompt)
        {
            //Console.WriteLine("Please enter the number of miles > ");
            Console.WriteLine(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
            // miles = ConsoleHelper.InputNumber("Please enter the number of miles >");
        }
        //private void InputFeet()
        //{
        //    Console.WriteLine("Please enter the number of feet > ");
        //    string value = Console.ReadLine();
        //    feet = Convert.ToDouble(value);


        //}
        //private void InputMetres()
        //{
        //    Console.WriteLine("Please enter the number of metres > ");
        //    string value = Console.ReadLine();
        //    metres = Convert.ToDouble(value);

        //}

        /// <summary>
        /// 
        /// </summary>

        //private void CalculateFeet()
        //{
        //    feet = miles * FEET_IN_MILES;
        //}
        ///// <summary>
        ///// 
        ///// </summary>

        //private void CalculateMiles()
        //{
        //    miles = feet / FEET_IN_MILES;
        //}

        ///// <summary>
        ///// 
        ///// </summary>

        //private void CalculateMetres()
        //{
        //    metres = miles * METRES_IN_MILES;
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        //private void OutputFeet()
        //{
        //    Console.WriteLine(miles + " miles is " + feet + " feet! ");
        //}
        ///// <summary>
        ///// 
        ///// </summary>
        //private void OutputMiles()
        //{
        //    Console.WriteLine(feet + " feet is " + miles + " miles! ");
        //}
        ///// <summary>
        ///// 
        ///// </summary>
        //private void OutputMetres()
        //{
        //    Console.WriteLine(miles + " miles is " + metres + " metres! ");
        //}
        private void OutputDestance ()
        {
            Console.WriteLine($"{ fromDistance} { fromUnit} " +
                $"is {toDistance} { toUnit} !");  
        }

    }   
}
