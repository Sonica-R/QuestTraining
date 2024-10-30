﻿using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Core;
using log4net.Layout;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
    internal class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            //BasicConfigurator.Configure();
            //log.Info("Entering to application");
            ConfigureLogging();

            log.Info("Application started");
            try
            {
                Console.Write("Num 1: ");
                int i = int.Parse(Console.ReadLine());
                Console.Write("Numm 2: ");
                int j = int.Parse(Console.ReadLine());
                int sum = i + j;
                Console.WriteLine(sum);
            }
            catch (Exception e)
            {

                log.Error(e.StackTrace);
            }
        }

        private static void ConfigureLogging()
        {
            var repository = LogManager.GetRepository();
            var layout = new PatternLayout
            {
                ConversionPattern = "%date [%thread] %-5level %logger - %message%newline"
            };
            layout.ActivateOptions();

            var consoleAppender = new ConsoleAppender
            {
                Layout = layout,
                Threshold = Level.Info
            };

            var errorFileAppender = new FileAppender
            {
                File = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "error.log"),
                AppendToFile = true,
                Layout = layout,
                Threshold = Level.Error
            };
            BasicConfigurator.Configure(repository, consoleAppender, errorFileAppender);
        }
    }
}