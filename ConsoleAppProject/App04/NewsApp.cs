using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App04
{
    /// <summary>
    /// This app will allow the user to add messages and photos
    /// to a list of posts.  Users can also display those posts
    /// in a variety of ways.
    /// <author>
    /// Sudath Nawagamuwage 27/03/2022
    /// </author>
    /// </summary>
    public class NewsApp
    {
        
        public NewsFeed NewsFeed { get; set; }

        //public string[] Choices =
        private void DisplayMenu(string display1)
        {
            string[] choices =
            {
            "Add Mesage Post",
            "Add Photo Post",
            "Display All Posts",
            "Display Posts by Author",
            "Remove Post",
            "Add Comment",
            "Like and Unlike Post",
            "Quit"
            };
            int choiceNo = ConsoleHelper.SelectChoice(choices);
            NewsIndex(choiceNo);
        }
        /// <summary>
        /// Prompt the user to select input marks, output mark, calculate satats
        /// calculate gradeProfile, output grade profile and input the marks
        /// </summary>
        public void NewsIndex(int choiceNo)
        {
            switch (choiceNo)
            {
                case 1:
                    AddMessagePost();
                    break;
                case 2:
                    AddPhotoPost();
                    break;
                case 3:
                    DisplayAll();
                    break;
                case 4:
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
        public void NewsFeedMenu()
        {
            ConsoleHelper.OutputHeading("\t\t Suadth Social Network");
            DisplayMenu("Please enter your choice > ");
        }

        public NewsApp()
        {
            NewsFeed = new NewsFeed();
        }

        //public void Run()
        //{
        //    AddMessagePost();
        //}
        /// <summary>
        /// Method for posting message in the news feed
        /// Asking for the author name and their message
        /// </summary>
        private void AddMessagePost()
        {
            ConsoleHelper.OutputHeading("\t\t Add Message");

            Console.Write(" Please enter the authors name > ");
            string author = Console.ReadLine();

            Console.Write(" Please enter the message > ");
            string message = Console.ReadLine();

            MessagePost post = new MessagePost(message, author);
            NewsFeed.Posts.Add(post);
            {
                Console.WriteLine();
                ConsoleHelper.OutputHeading("\t\t Suadth Social Network");
                DisplayMenu("\nPlease enter your choice > ");
            }
        }/// <summary>
         /// Method for posting image in the news feed
         /// Asking for the author name and their image and caption
         /// </summary>
        private void AddPhotoPost()
        {
            ConsoleHelper.OutputHeading("\t\t Add Photo");
           
            Console.Write(" Please enter the authors name > ");
            string author = Console.ReadLine();

            Console.Write(" Please enter the Image file name > ");
            string filename = Console.ReadLine();

            Console.Write(" Please enter the Image caption > ");
            string caption = Console.ReadLine();

            PhotoPost post = new PhotoPost(author,filename, caption);
            NewsFeed.Posts.Add(post);
            {
                Console.WriteLine();
                ConsoleHelper.OutputHeading("\t\t Suadth Social Network");
                DisplayMenu("\nPlease enter your choice > ");
            }
        }
        /// <summary>
        /// Ouputing all the messages and images
        /// on the news feed
        /// </summary>
        private void DisplayAll()
        {
            NewsFeed.Display();
            Console.WriteLine();
            ConsoleHelper.OutputHeading("\t\t Suadth Social Network");
            DisplayMenu("\nPlease enter your choice > ");
        }




    }
}