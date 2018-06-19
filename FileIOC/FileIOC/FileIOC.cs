using System;
using System.IO;
using System.Reflection;

namespace FileIOC
{
    public class FileIOC
    {
        public static void Main(string[] args)
        {
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            Console.WriteLine(path);
            Console.WriteLine("What is the file name?");
            string filename = Console.ReadLine();
            path += "\\" + filename + ".txt";
            Console.WriteLine(path);
            string[] lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);  //display the first number in the text file as an example
            for (int i = 6; i < lines.Length + 1; i += 5)
                    {
                        var x = lines.GetValue(i);
                        if (x.Equals(1) || x.Equals(2) || x.Equals(3) || x.Equals(4) || x.Equals(5) || x.Equals(6) || x.Equals(7) || x.Equals(8) || x.Equals(9))
                        {
                            Console.WriteLine(x);
                        }     
                    }
            Console.ReadKey();
        }
    }
}