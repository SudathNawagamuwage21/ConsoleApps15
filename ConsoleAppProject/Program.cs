using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
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
        public static NewsApp NewsApp
        {
            get => default;
            set
            {
            }
        }

        // private static DistanceConverter Converter = new DistanceConverter();

        // private static BMI calculator = new BMI();

        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            ConsoleHelper.OutputHeading("BNU CO453 Applications Programming 2021-2022!");
            Console.WriteLine();
            Console.Beep();

            string[] choices = { "App01: Distance Converter", "App02: BMI Calculator", "App03: Student Grades", "App04: Social Network", "Quit" };
            int choiceNo = ConsoleHelper.SelectChoice(choices);

            switch (choiceNo)
            {
                case 1:
                    DistanceConverter converter = new DistanceConverter();
                    converter.ConvertDistance();
                    break;
                case 2:
                    BMI calculator = new BMI();
                    calculator.CalculaterIndex();
                    break;
                case 3:
                    StudentGrades grades = new StudentGrades();
                    grades.StudentGradesMenu();
                    break;
                case 4:
                    NewsApp socialApp = new NewsApp();
                    socialApp.DisplayMenu();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }
        }
    }
}