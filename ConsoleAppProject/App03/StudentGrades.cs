using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// This application will allow a tutor to enter a single mark of each of
    /// a list of students and it will convert that mark into a grade. 
    /// </summary>
    /// <author>
    /// Sudath nawagamuwage version 0.1
    /// </author>
    public class StudentGrades
    {
        //Constants
        public const int HighestMark = 100;
        public const int LowestGradeA = 70;
        public const int LowestGradeB = 60;
        public const int LowestGradeC = 50;
        public const int LowestGradeD = 40;
        public const int LowestMark = 0;
       
        //properties
        public string[] Students { get; set; }
        public int[] Marks { get; set; }
        public int[] GradeProfile { get; set; }
        public double Mean { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }
        public string StudentClass { get; set; }


        //Attributes

        ///<summary>
        ///Class Constructor called when an object
        ///is created and sets up an array of students
        ///</summary>

        public StudentGrades()
        {
            Students = new string[]
            {
                 "Sudath", "Tania", "Saveyth", "Niveith", "Kiveith",
                "Rosahan", "Matin", "Michelle", "Natasha", "Jack"
            };

            GradeProfile = new int[(int)Grades.A + 1];
             Marks = new int[Students.Length];
            
            // Testing for maks arrys
            //Marks = new int[]
            //{ 
            //    80, 55, 45, 70, 75, 65, 70, 66, 60, 55, 55
            //};

        }

        /// <summary>
        /// Input a mark between 0 - 100 for 
        /// each student and store it in the Marks array.
        /// </summary>
        public void InputMarks()
        {
            ConsoleHelper.OutputHeading1("\t\tPlease enter a mark for each student");
            for (int i = 0; i < Students.Length; i++)
            {
                Marks[i] = (int)ConsoleHelper.InputNumber($"Enter {Students[i]} marks: ", LowestMark, HighestMark);
            }

            Console.WriteLine();
            ConsoleHelper.OutputHeading("\t\t Student Marks System");
            DisplayMenu("\nPlease enter your choice > ");
        }

        /// <summary>
        /// List all the student and display their
        /// name and current mark.
        /// </summary>
        public void OutputMarks()
        {
            ConsoleHelper.OutputHeading1("\t\tThe each Student Marks");

            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine($"Student Name: {Students[i]} \tStudent Mark: {Marks[i]}\t" +
                    $"Student Grade: {ConvertToGrade(Marks[i])}\tStudent Class: {StudentClass}\t");
            }
            Console.WriteLine();
            ConsoleHelper.OutputHeading("\t\t Student Marks System");
            DisplayMenu("\n\nPlease enter your choice > ");
        }

        /// <summary>
        /// Convert a student mark to a grade
        /// from F(fail) to A (First Class)
        /// </summary>
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= LowestMark && mark < LowestGradeD)
            {
                StudentClass = "Referred";
                return Grades.F;
            }
            else if (mark >= LowestGradeD && mark < LowestGradeC)
            {
                StudentClass = "BSc(Hons) Third Class";
                return Grades.D;
            }
            else if (mark >= LowestGradeC && mark < LowestGradeB)
            {
                StudentClass = "BSc(Hons) Lower Second";
                return Grades.C;
            }
            else if (mark >= LowestGradeB && mark < LowestGradeA)
            {
                StudentClass = "BSc(Hons) Upper Second";
                return Grades.B;
            }
            else if (mark >= LowestGradeA && mark <= HighestMark)
            {
                StudentClass = "BSc(Hons) First Class";
                return Grades.A;
            }
            else
            {
                return Grades.F;
            }
        }

        /// <summary>
        /// Calculate and display the minimum, maximum
        /// and mean mark for all the students.
        /// </summary>
        public void CalculateStats()
        {
            Minimum = Marks[0];
            Maximum = Marks[0];

            double total = 0;

            foreach (int mark in Marks)
            {
                total += mark;

                if (mark > Maximum)
                {
                    Maximum = mark;
                }
                else if (mark < Minimum)
                {
                    Minimum = mark;
                }
               
            }

            Mean = total / Marks.Length;

            ConsoleHelper.OutputHeading1("The Student Mean Mark, Minimum Mark and Maximum Mark");
            Console.WriteLine($"Mean Mark: {Mean}\nMinimum Mark: {Minimum}\nMaximum Mark:{Maximum}");
            Console.WriteLine();
            ConsoleHelper.OutputHeading("\t\t Student Marks System");
            DisplayMenu("\n\nPlease enter your choice > ");
        }

        /// <summary>
        /// Calculate  Grade profile of students 
        /// </summary>
        public void CalculateGradeProfile()
        {
            for (int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }

            foreach (int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }
        }

        /// <summary>
        /// Output the resul of grade profile 
        /// </summary>
        public void OutputGradeProfile()
        {
            Grades grade = Grades.D;
            Console.WriteLine();
            ConsoleHelper.OutputHeading1("\t\tThe Student Grade Profile");
            foreach (int count in GradeProfile)
            {
                int percentage = count * 100 / Marks.Length;
                Console.WriteLine($"Grade {grade}\t {percentage}%\t Count {count}");
                grade++;
                
            }

            Console.WriteLine();
            ConsoleHelper.OutputHeading("\t\t Student Marks System");
            DisplayMenu("\n\nPlease enter your choice > ");
        }

        /// <summary>
        /// Prompt the user to select their choice
        /// </summary>
        private void DisplayMenu(string display)
        {
            string[] choices =
            {
                "Input Marks",
                "Ouput Marks",
                "Output Stats",
                "Ouput Grade Profile",
                "Quit"
            };
            int choiceNo = ConsoleHelper.SelectChoice(choices);
            GradeIndex(choiceNo);

        }

        /// <summary>
        /// Prompt the user to select input marks, output mark, calculate satats
        /// calculate gradeProfile, output grade profile and input the marks
         /// </summary>
        public void GradeIndex(int choiceNo)
        {
            switch (choiceNo)
            {
                case 1:
                    InputMarks();
                    break;
                case 2:
                    OutputMarks();
                    break;
                case 3:
                    CalculateStats();
                    break;
                case 4:
                    CalculateGradeProfile();
                    OutputGradeProfile();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    DisplayMenu("Please enter your choice > ");
                    break;
            }
        }

        /// <summary>
        /// Ouput the heading and 
        /// display the menu
        /// </summary>
        public void StudentGradesMenu()
        {
            ConsoleHelper.OutputHeading("\t\t Student Marks System");
            DisplayMenu("Please enter your choice > ");
        }

    }
}
