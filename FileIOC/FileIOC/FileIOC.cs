using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace FileIOC
{
    public class FileIOC
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("send me your file location");
            String location = Console.ReadLine();
            System.IO.StreamReader myFile = new System.IO.StreamReader(location);
            string myString = myFile.ReadToEnd();
            String[] num1 = myString.Split(" ");
            int[] num2 = new int[num1.Length];
            for (int i = 0; i < num1.Length; i++)
            {
                num2[i] = Convert.ToInt32(num1[i]);
            }
            int sum = 0;
            for (int i = 0; i < num1.Length; i++)
            {
                sum += num2[i];
                Console.Write(num2[i] + " ");
            }
            Console.WriteLine("sum: " + sum);
            Console.ReadKey();

        }
    }
}