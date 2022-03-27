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

        public string[] Choices =
        {
            "Add Mesage Post",
            "Add Photo Post",
            "Display All Posts"
        };

        public NewsApp()
        {
            NewsFeed = new NewsFeed();
        }

        public void Run()
        {
            AddMessagePost();
        }

        private void AddMessagePost()
        {
            ConsoleHelper.OutputHeading("Add Message");

            Console.Write(" Please enter the authors name > ");
            string author = Console.ReadLine();

            Console.Write(" Please enter the message > ");
            string message = Console.ReadLine();

            MessagePost post = new MessagePost(message, author);
            NewsFeed.Posts.Add(post);

        }
    }
}