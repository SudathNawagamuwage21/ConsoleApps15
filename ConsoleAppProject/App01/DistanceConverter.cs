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
       
        public void MilesToiFeet()
        {
            OutputHeadding(" converting miles to feet ");
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }
        public void FeetToMiles()
        {
            OutputHeadding(" converting feet to miles ");
            InputFeet();
            CalculateMiles();
            OutputMiles();
        }
        public void MilesToMetres()
        {
            OutputHeadding(" converting miles to metres ");
            InputMetres();
            CalculateMetres();
            OutputMetres();
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
            Console.WriteLine("Please enter the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
            
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
