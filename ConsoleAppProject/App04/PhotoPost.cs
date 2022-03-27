using System;
using System.Collections.Generic;


namespace ConsoleAppProject.App04
{
    ///<summary>
    /// This class stores information about a post in a social network. 
    /// The main part of the post consists of a photo and a caption. 
    /// Other data, such as author and time, are also stored.
    ///</summary>
    /// <author>
    /// Michael Kölling and David J. Barnes
    /// @version 0.1
    /// Modified by : Sudath Nawagamuwage 227/03/2022 
    /// </author>
    public class PhotoPost : Post
    {
        // the name of the image file
        public String Filename { get; set; }

        // a one line image caption
        public String Caption { get; set; }

        ///<summary>
        /// Constructor for objects of class PhotoPost.
        ///</summary>
        /// <param name="author">
        /// The username of the author of this post.
        /// </param>
        /// <param name="caption">
        /// A caption for the image.
        /// </param>
        /// <param name="filename">
        /// The filename of the image in this post.
        /// </param>
        public PhotoPost(String author, String filename, String caption) : base(author)
        {
            this.Filename = filename;
            this.Caption = caption;
        }
    }
}
© 2022 GitHub, Inc.