﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EchoNestLib.BObject
{
    /// <summary>
    /// Internal class representing an artist
    /// </summary>
    public class Artist
    {
        /// <summary>
        /// The constructor instatiates all the object properties
        /// We do it here instead of inline becaus we may want to do particular logic
        /// </summary>
        public Artist()
        {
            this.Biographies = new List<string>();
            this.Video = new List<string>();
            this.Images = new List<string>();
            this.Reviews = new List<string>();
            this.News = new List<string>();
        }

       
        /// <summary>
        /// Artist name
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _name;

        
        /// <summary>
        /// Artist Echo Nest ID
        /// </summary>
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _id;

        
        /// <summary>
        /// Familiarity of the artist
        /// </summary>
        public double Familiarity
        {
            get { return _familiarity; }
            set { _familiarity = value; }
        }
        private double _familiarity;

       
        /// <summary>
        /// How much is this band hot
        /// </summary>
        public double Hotness
        {
            get { return _hotness; }
            set { _hotness = value; }
        }
        private double _hotness;

        
        /// <summary>
        /// List of biographies
        /// </summary>
        public List<string> Biographies
        {
            get { return _biographies; }
            set { _biographies = value; }
        }
        List<string> _biographies;

        /// <summary>
        /// List of video
        /// </summary>
        public List<string> Video
        {
            get { return _video; }
            set { _video = value; }
        }
        List<string> _video;

        /// <summary>
        /// List of images
        /// </summary>
        public List<string> Images
        {
            get { return _images; }
            set { _images = value; }
        }
        List<string> _images;

        /// <summary>
        /// List of news
        /// </summary>
        public List<string> News
        {
            get { return _news; }
            set { _news = value; }
        }
        List<string> _news;

        /// <summary>
        /// List of reviews
        /// </summary>
        public List<string> Reviews
        {
            get { return _reviews; }
            set { _reviews = value; }
        }
        List<string> _reviews;
    }
}
