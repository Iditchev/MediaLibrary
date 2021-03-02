﻿using System;
using NLog.Web;
using System.IO;
using System.Collections.Generic;

namespace MediaLibrary
{
    class Program
    {
        //create static instance of logger
        private static NLog.Logger logger = NLog.Web.NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
        static void Main(string[] args)
        {
            string movieFilePath = Directory.GetCurrentDirectory() + "\\movies.csv";
            logger.Info("Program started");

             MovieFile movieFile = new MovieFile(movieFilePath);

             string choice = "";
            do
            {
                // display choices to user
                Console.WriteLine("1) Add Movie");
                Console.WriteLine("2) Display All Movies");
                Console.WriteLine("Enter to quit");
                // input selection
                choice = Console.ReadLine();
                
                logger.Info("User choice: {Choice}", choice);

              // Movie movie = new Movie
             // {
             //     mediaId = 123,
             //     title = "Greatest Movie Ever, The (2020)",
             //     director = "Jeff Grissom",
             //     // timespan (hours, minutes, seconds)
             //     runningTime = new TimeSpan(2, 21, 23),
             //     genres = { "Comedy", "Romance" }
             // };

             // Console.WriteLine(movie.Display());

             // Album album = new Album
             // {
             //     mediaId = 321,
             //     title = "Greatest Album Ever, The (2020)",
             //     artist = "Jeff's Awesome Band",
             //     recordLabel = "Universal Music Group",
             //     genres = { "Rock" }
             // };
             // Console.WriteLine(album.Display());

             // Book book = new Book
             // {
             //     mediaId = 111,
             //     title = "Super Cool Book",
             //     author = "Jeff Grissom",
             //     pageCount = 101,
             //     publisher = "",
             //     genres = { "Suspense", "Mystery" }
             // };
             // Console.WriteLine(book.Display());

             string scrubbedFile = FileScrubber.ScrubMovies("movies.csv");
             logger.Info(scrubbedFile);

            logger.Info("Program ended");
        }
    }
}
