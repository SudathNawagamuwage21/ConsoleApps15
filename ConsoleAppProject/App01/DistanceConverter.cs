using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This class allows the user to convert distances measured and 
    /// in one unit of distance into another unit of distance 
    /// It will convert a distance measured in miles into the same distance measured in feet.
    /// </summary>
    /// <author>
    /// Sudath Nawagamuwage version 0.1
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        private double miles;
        private double feet;
        /// <summary>
        /// 
        /// </summary>
        public void Run()
        {
            OutputHeadding();
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        private void OutputHeadding()
        {
            Console.WriteLine("\n ---------------------------------");
            Console.WriteLine("     Convert Miles to Feet         ");
            Console.WriteLine("     by Sudath Nawagamuwage           ");
            Console.WriteLine(" ---------------------------------\n");
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
        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet! ");
        }
    }
}
