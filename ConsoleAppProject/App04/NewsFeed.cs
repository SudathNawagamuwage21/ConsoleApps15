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
        public List<Post> Posts { get; set; }

        ///<summary>
        /// Construct an empty news feed.
        ///</summary>
        public NewsFeed()
        {
            Posts = new List<Post>();
        }


        ///<summary>
        /// Add a text post to the news feed.
        /// 
        /// @param text  The text post to be added.
        ///</summary>
        public void AddPost(Post post)
        {
            Posts.Add(post);
        }


        ///<summary>
        /// Show the news feed. Currently: print the news feed details to the
        /// terminal. (To do: replace this later with display in web browser.)
        ///</summary>
        public void Display()
        {
            // display all text posts
            foreach (Post post in Posts)
            {
                post.Display();
                Console.WriteLine();   // empty line between posts
            }

        }
    }

}
