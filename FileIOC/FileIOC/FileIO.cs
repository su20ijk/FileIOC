using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace FileIOC
{
    public class FileIO
    {
        public static void Sum(string[] lines, System.IO.StreamWriter file)
        {
            int[] num = new int[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                num[i] = Convert.ToInt32(lines[i]);
            }
            file.WriteLine("Sum:");
            int sum = 0;
            foreach (int x in num)
            {
                sum += x;
            }
            file.WriteLine(sum);
            file.Close();
        }

        public static void WriteAll(string[] lines, System.IO.StreamWriter file)
        {
            file.WriteLine("Numbers in file:");
            foreach (string x in lines)
            {
                file.WriteLine(x);
            }
            file.Close();
        }

        public static void Odds(string[] lines, System.IO.StreamWriter file)
        {
            int[] nums = new int[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                nums[i] = int.Parse(lines[i]);
                if ((nums[i] - 1) % 2 == 0)
                {
                    file.WriteLine(nums[i]);
                }
            }
            file.Close();
        }
        public static void Evens(string[] lines, System.IO.StreamWriter file) 
        {
            foreach(string line in lines)
            {
                int temp = Int32.Parse(line);
                if (temp % 2 == 0)
                {
                file.WriteLine(line);
                }
            }
            file.Close();
        }
}
    }
