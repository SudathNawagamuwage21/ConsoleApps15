﻿using ConsoleAppProject.Helpers;
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
        public const string AUTHOR1 = "Sudath";
        public List<Post> posts { get; set; }

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

            MessagePost post1 = new MessagePost(AUTHOR1, "I Like Visual Studio 2022");
            AddMessagePost(post);

            PhotoPost photoPost1 = new PhotoPost(AUTHOR1, "Photo2.jpg", "Visual Studio 2022");
            AddPhotoPost(photoPost);
        }
                       
        ///<summary>
        /// Add a Photo post to the news feed.
        /// 
        /// @param text  The Photo post to be added.
        ///</summary>
        public void AddMessagePost(MessagePost message)
        {
            posts.Add(message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="photo"></param>
        public void AddPhotoPost(PhotoPost photo)
        {
            posts.Add(photo);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void RemovePost(int id)
        {
            Post post = FindPost(id);

            if (post == null)
            {
                Console.WriteLine($"\nPost with ID: {id} does not exist!\n");
            }
            else
            {
                Console.WriteLine($"\nThe following Post {id} has been removed!\n");

                if (post is MessagePost mp)
                {
                    mp.Display();
                }
                else if (post is PhotoPost pp)
                {
                    pp.Display();
                }

                posts.Remove(post);
                post.Display();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Post FindPost(int id)
        {
            ConsoleHelper.OutputTitle("Display All Posts");

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
            // display all text posts
            foreach (Post post in posts)
            {
                post.Display();
                Console.WriteLine();   // empty line between posts
            }
        }
    }

}
