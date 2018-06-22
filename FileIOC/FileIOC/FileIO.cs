using System;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;

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
            VanessaEveryFifth.Fifth(lines);
            
        }
    }
}