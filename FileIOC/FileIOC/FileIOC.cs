using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace FileIOC
{
    public class FileIOC
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("please enter the name of the file:");
            string fileName = Console.ReadLine();
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var filePath = path + "/" + fileName + ".txt";
            string[] lines = System.IO.File.ReadAllLines(filePath);
            FIO.DivThree(filePath, path);
            Console.ReadKey();
        }
    }
}