﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace FileIOC
{
    public class FileIO
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Please enter the name of the file:");
            string fileName = Console.ReadLine();
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            path += "/" + fileName + ".txt";
            string[] lines = System.IO.File.ReadAllLines(path);
            
            Console.ReadKey();

        }
    }
}