﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMangement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var storageService = new JsonFileStorage();
            var bookManager = new BookManager(storageService);
            bookManager.Run();
        }

    }
}
