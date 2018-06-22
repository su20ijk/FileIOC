using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace FileIOC
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("please enter the name of the input file:");
            string inputFileName = Console.ReadLine();
            var inPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            inPath += "/" + inputFileName + ".txt";
            Console.WriteLine("please enter the name of the output file:");
            string outFileName = Console.ReadLine();
            var outPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            outPath += "/" + outFileName + ".txt";
            string[] lines = System.IO.File.ReadAllLines(inPath);
            StreamWriter file = new StreamWriter(outPath);
            FileIO x = new FileIO();
            FileIO.Odds(lines, file);
            FileIO.DivThree(lines, file);
        }
    }
}
