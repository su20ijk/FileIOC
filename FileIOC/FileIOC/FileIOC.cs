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
            Console.WriteLine(path);
            Console.WriteLine("What is the file name?");
            string filename = Console.ReadLine();
            path += "\\" + filename + ".txt";
            string[] lines = File.ReadAllLines(path);
            for (int i = 6; i < lines.Length + 1; i += 5)
            {
                int Num;
                var x = lines.GetValue(i);
                bool isNum = int.TryParse(x.ToString(), out Num);
                if (isNum == true)
                {
                    Console.WriteLine(Num);
                }     
            }
            Console.ReadKey();
        }
    }
}