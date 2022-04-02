using ConsoleAppProject.Helpers;
using System;
using System.Collections.Generic;


namespace ConsoleAppProject.App04
{
    ///<summary>
    /// The NewsFeed class stores news posts for the news feed in a social network 
    /// application.
    /// 
    /// Display of the posts is currently simulated by printing the details to the
    /// terminal. (Later, this should display in a browser.)
    /// 
    /// This version does not save the data to disk, and it does not provide any
    /// search or ordering functions.
    ///</summary>
    ///<author>
    ///  Michael Kölling and David J. Barnes
    ///  Modified by Sudath Nawagamuwage 27/03/2022
    ///  version 0.1
    ///</author> 
    public class NewsFeed
    {
        public const string AUTHOR = "Sudath";
        

        private readonly List<Post> posts; 

        ///<summary>
        /// Construct an empty news feed.
        ///</summary>
        public NewsFeed()
        {   
            posts = new List<Post>();

            MessagePost post = new MessagePost(AUTHOR, "I Like Visual Studio 2021");
            AddMessagePost(post);

            PhotoPost photoPost = new PhotoPost(AUTHOR, "Photo1.jpg", "Visual Studio 2021");
            AddPhotoPost(photoPost);
         
        }
                       
        ///<summary>
        /// Add a Photo post to the news feed.
        /// @param text  The Photo post to be added.
        ///</summary>
        public void AddMessagePost(MessagePost message)
        {
            posts.Add(message);
        }

        ///<summary>
        /// Add a Photo to this post.
        /// The new photo to add.
        /// </summary>
        public void AddPhotoPost(PhotoPost photo)
        {
            posts.Add(photo);
        }

        /// <summary>
        /// Display the author with output the post
        /// </summary>
        public void DisplayAuthorPost(string author)
        {
            foreach (Post post in posts)
            {
                if (post.Username == author)
                {
                    post.Display();
                }
            }
        }

        /// <summary>
        /// Display the Date with output the post
        /// </summary>
        public void FindDate(string date)
        {
            foreach (Post post in posts)
            {
                if (post.Timestamp.ToLongDateString().Contains(date))
                {
                    post.Display();
                }
            }
        }

        /// <summary>
        /// Add comment to the post
        /// </summary>
        public void AddPostComment(int id, string text)
        {
            Post post = FindPost(id);

            if (post == null)
            {
                Console.WriteLine($"\nPost with ID: {id} does not exist!\n");
            }
            else
            {
                Console.WriteLine($"\nThe comment have been added to post {id}!\n");
                post.AddComment(text);
                post.Display();
            }
        }

        /// <summary>
        /// Add like to the post
        /// </summary>
        public void LikePost(int id)
        {
            Post post = FindPost(id);

            if (post == null)
            {
                Console.WriteLine($"\nPost with ID: {id} does not exist!\n");
            }
            else
            {
                Console.WriteLine($"\nYou have liked the the post {id}!\n");
                post.Like();
                post.Display();
            }
        }

        /// <summary>
        /// Add Unlike to the post
        /// </summary>
        public void UnlikePost(int id)
        {
            Post post = FindPost(id);

            if (post == null)
            {
                Console.WriteLine($"\nPost with ID: {id} does not exist!\n");
            }
            else
            {
                Console.WriteLine($"\nYou have unliked the the post {id}!\n");
                post.Unlike();
                post.Display();
            }
        }

        /// <summary>
        /// Removeing the all the new post by id
        /// </summary>
        public void RemovePost(int id)
        {
            Post post = FindPost(id);

            if (post == null)
            {
                Console.WriteLine($" \nPost with ID: {id} does not exist!\n");
            }
            else
            {
                Console.WriteLine($" \nThe following Post {id} has been removed!\n");
                              
                posts.Remove(post);
                post.Display();
            }
        }

        /// <summary>
        /// Find the post
        /// </summary>
        public Post FindPost(int id)
        {
            foreach (Post post in posts)
            {
                if (post.PostId == id)
                {
                    return post;
                }
            }

            return null;
        }
        ///<summary>
        /// Show the news feed. Currently: print the news feed details to the
        /// terminal. (To do: replace this later with display in web browser.)
        ///</summary>
        public void Display()
        {
            ConsoleHelper.OutputTitle("Display All Posts");

            // display all text posts
            foreach (Post post in posts)
            {
                post.Display();
                Console.WriteLine();   // empty line between posts
            }
        }
    }

}
