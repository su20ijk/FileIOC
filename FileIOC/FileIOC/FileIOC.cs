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
            path += "/" + fileName + ".txt";
            string[] lines = System.IO.File.ReadAllLines(path);
            int[] num = new int[lines.Length];
            for (int i = 0; i <lines.Length; i++)
            {
                num[i] = Convert.ToInt32(lines[i]);
            }
            Console.WriteLine("Sum:");
            int sum = 0;
            foreach (int x in num)
            { 
                sum+=x;
            }
            Console.WriteLine(sum);
            Console.WriteLine();
            Console.WriteLine("Numbers in file:");
            foreach (int x in num)
            { 
                Console.WriteLine(x);
            }
            Console.ReadKey();

        }
    }
}