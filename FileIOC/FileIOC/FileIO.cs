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
        public void sum(string[] lines, System.IO.StreamWriter file)
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

        public void writeAll(string[] lines, System.IO.StreamWriter file)
        {
            file.WriteLine("Numbers in file:");
            foreach (string x in lines)
            {
                file.WriteLine(x);
            }
            file.Close();
        public void odds(string[] lines, System.IO.StreamWriter file)
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
}
    }
