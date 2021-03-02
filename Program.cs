using System;
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
            logger.Info("Program started");

            Console.WriteLine("Hello World!");

            logger.Info("Program ended");
        }
    }
}
