using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Sudath Nawagamuwage 05/02/2022
    /// </summary>
    public static class Program
    {
        private static DistanceConverter Converter = new DistanceConverter();

        private static BMI calculator = new BMI();
        
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            ConsoleHelper.OutputHeading("BNU CO453 Applications Programming 2021-2022!");
            Console.WriteLine();
            Console.Beep();
            
            string[] choices = { "Distance Converter", "BMI Calculator", "Quit" };
            int choiceNo = ConsoleHelper.SelectChoice(choices);

            if (choiceNo == 1)
            {
                Converter.ConvertDistance();
            }
            else if (choiceNo == 2)
            {
               calculator.CalculaterIndex();
            }
           // else Console.WriteLine("Invalid Choice!");
         }
    }
}
