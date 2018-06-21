using System;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;

namespace FileIOC
{
    public class EveryFifth
    {
        public static void Main(string[] args)
        {
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            Console.WriteLine("What is the file name?");
            string filename = Console.ReadLine();
            path += "\\" + filename + ".txt";
            string[] lines = File.ReadAllLines(path);
            //possible menu for each part of the problem

            //if they choose Vanessa
            string[] result = VanessaEveryFifth.fifth(lines);
            Console.WriteLine();
            //Write to file


            
        }
    }
}