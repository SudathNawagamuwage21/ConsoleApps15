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

        private double miles;
        private double feet;
        private double metres;

        /// <summary>
        /// 
        /// </summary>
       
        public void MilesToFeet()
        {
            OutputHeadding(" Converting Miles to Feet ");
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }
        public void FeetToMiles()
        {
            OutputHeadding(" Converting Feet to Miles ");
            InputFeet();
            CalculateMiles();
            OutputMiles();
        }
        public void MilesToMetres()
        {
            OutputHeadding(" Converting Miles to Metres ");
            InputMetres();
            CalculateMetres();
            OutputMetres();
        }
        private int InputChoices()

        {
            Console.WriteLine(" Enter the choices");
            Console.WriteLine(" 1.Miles  ");
            Console.WriteLine(" 2.Feet  ");
            Console.WriteLine(" 3.Metres ");

            int value = (int)ConsoleHelper.InputNumber("enter your choices > ", 1, 3);

            if (value == 1)
            {
                return 1;
            }
            else if (value == 2)
            {
                return 2;
            }
            else if (value == 3)
            {
                return 3;
            }
            else
            {
               return 0;
            }

        }
        private void OutputHeadding( string prompt)
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
        private void InputMiles ()
        {
            //Console.WriteLine("Please enter the number of miles > ");
            //string value = Console.ReadLine();
            //miles = Convert.ToDouble(value);
            miles = ConsoleHelper.InputNumber("Please enter the number of miles >");
        }
        private void InputFeet()
        {
            Console.WriteLine("Please enter the number of feet > ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);


        }
        private void InputMetres()
        {
            Console.WriteLine("Please enter the number of metres > ");
            string value = Console.ReadLine();
            metres = Convert.ToDouble(value);

        }

        /// <summary>
        /// 
        /// </summary>

        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }
        /// <summary>
        /// 
        /// </summary>

        private void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES;
        }

        /// <summary>
        /// 
        /// </summary>

        private void CalculateMetres()
        {
            metres = miles * METRES_IN_MILES;
        }

        /// <summary>
        /// 
        /// </summary>
        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet! ");
        }
        /// <summary>
        /// 
        /// </summary>
        private void OutputMiles()
        {
            Console.WriteLine(feet + " feet is " + miles + " miles! ");
        }
        /// <summary>
        /// 
        /// </summary>
        private void OutputMetres()
        {
            Console.WriteLine(miles + " miles is " + metres + " metres! ");
        }
    }   
}
