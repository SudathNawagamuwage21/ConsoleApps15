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
        
        /// <summary>
        /// 
        /// </summary>
        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading("\t\t Sudath's News Feed");

            string[] choices = new string[]
            {
                "Post Message",
                "Post Image",
                "Remove Post",
                "Display All Posts",
                "Display Posts by Author",
                "Display Posts by Date",
                "Add Comment to Post",
                "Like/Unlike Post",
                "Quit"
            };

            bool wantToQuit = false;
            do
            {
                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choice)
                {
                    case 1:
                        PostMessage();
                        break;
                    case 2:
                        PostImage();
                        break;
                    case 3:
                        RemovePost();
                        break;
                    case 4:
                        DisplayAll();
                        break;
                    case 5:
                        DisplayByAuthor();
                        break;
                    case 6:
                        DisplayByDate();
                        break;
                    case 7:
                        AddComment();
                        break;
                    case 8:
                        LikePosts();
                        break;
                    case 9:
                        wantToQuit = true;
                        break;
                }
            }
            while (!wantToQuit);
        }

        /// <summary>
        /// 
        /// </summary>
        private void LikePosts()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        private void AddComment()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        private void DisplayByDate()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        private void DisplayByAuthor()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        private void DisplayAll()
        {
            NewsFeed.Display();
        }

        private void RemovePost()
        {
            ConsoleHelper.OutputTitle("Removing a Post");

            int id = (int)ConsoleHelper.InputNumber("Please enter the post id > ", 1, Post.GetNumberOfPosts());

            NewsFeed.RemovePost(id);
        }

        /// <summary>
        /// 
        /// </summary>
        private void PostImage()
        {
             ConsoleHelper.OutputTitle("Posting an Image/Photo");
             string author = InputName();

             Console.WriteLine("Please enter your image file name > ");
             string filename = Console.ReadLine();

             Console.WriteLine("Please enter your image caption > ");
             string caption = Console.ReadLine();

             PhotoPost post = new PhotoPost(author, filename, caption);
             NewsFeed.AddPhotoPost(post);

             ConsoleHelper.OutputTitle("You have just posted this image:");
             post.Display();
          

        }

        /// <summary>
        /// 
        /// </summary>
        private void PostMessage()
        {
            ConsoleHelper.OutputTitle("Posting an Message");
            string author = InputName();

            Console.WriteLine("Please enter your Message > ");
            string message = Console.ReadLine();

            MessagePost post = new MessagePost(author, message);
            NewsFeed.AddMessagePost(post);

            ConsoleHelper.OutputTitle("You have just posted this message:");
            post.Display();
        }

        /// <summary>
        /// 
        /// </summary>
        private string InputName()
        {
            Console.Write("Please enter your name > ");
            string author = Console.ReadLine();
            return author;
        }

        /// <summary>
        /// 
        /// </summary>
        public NewsApp()
        {
            NewsFeed = new NewsFeed();
        }
    }
}
