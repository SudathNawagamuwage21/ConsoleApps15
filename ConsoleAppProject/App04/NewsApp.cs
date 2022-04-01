using System;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App04
{
    /// <summary>
    /// This Social Network app will allow the user to add messages and photos
    /// to a list of posts.  Users can also display those posts
    /// in a variety of ways.
    /// <author>
    /// Sudath Nawagamuwage 27/03/2022
    /// </author>
    /// </summary>
    public class NewsApp
    {

        private NewsFeed news = new NewsFeed();

        /// <summary>
        /// This didplay menu for user to select the choices
        /// </summary>
        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading("\t\t Sudath's News Feed");

            Console.ForegroundColor = ConsoleColor.Blue;

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
        /// Method for add like to the post
        /// </summary>
        private void LikePosts()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Method for add comment to the post
        /// </summary>
        private void AddComment()
        {
            ConsoleHelper.OutputTitle("Add a comment to a Post");
            int id = (int)ConsoleHelper.InputNumber("Please enter the post id > ", 1, Post.GetNumberOfPosts());
            
            Console.WriteLine("Enter the comment you want to add > ");
            string comment = Console.ReadLine();
            news.AddPostComment(id, comment);
        }

        /// <summary>
        /// Method for display post by date
        /// </summary>
        private void DisplayByDate()
        {
            Console.WriteLine("Enter the date of post you want to display > ");
            string date = Console.ReadLine();
            
            ConsoleHelper.OutputTitle($"Posts from the {date}");
            news.FindDate(date);
        }

        /// <summary>
        /// Method for display post by author
        /// </summary>
        private void DisplayByAuthor()
        {
            Console.WriteLine("Enter the name of user you want to display > ");
            string author = Console.ReadLine();
            
            ConsoleHelper.OutputTitle($"Posts by {author}");
            news.DisplayAuthorPost(author);
        }

        /// <summary>
        /// Method for display the all the post
        /// </summary>
        private void DisplayAll()
        {
            news.Display();
        }

        /// <summary>
        /// Method for removing the posted massages in the news feed
       /// </summary>
        private void RemovePost()
        {
            ConsoleHelper.OutputTitle($"Removing a Post");

            int id = (int)ConsoleHelper.InputNumber("Please enter the post id > ", 1, Post.GetNumberOfPosts());

            news.RemovePost(id);
        }

        /// <summary>
        /// Method for posting image in the news feed
        /// Asking for the author name and their image and caption
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
             news.AddPhotoPost(post);

             ConsoleHelper.OutputTitle("You have just posted this image:");
             post.Display();
        }

        /// <summary>
        /// Method for posting massage in the news feed
        /// Asking for the author name and their massage
        /// </summary>
        private void PostMessage()
        {
            ConsoleHelper.OutputTitle("Posting an Message");
           
            string author = InputName();

            Console.WriteLine("Please enter your Message > ");
            string message = Console.ReadLine();

            MessagePost post = new MessagePost(author, message);
            news.AddMessagePost(post);

            ConsoleHelper.OutputTitle("You have just posted this message:");
            post.Display();
        }

        /// <summary>
        /// Method for input the aurthor name
        /// </summary>
        private string InputName()
        {
            Console.Write("Please enter your name > ");
            string author = Console.ReadLine();
            
            return author;
        }
      
    }
}
