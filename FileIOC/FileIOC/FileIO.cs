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
        public static void DivThree(string[] lines, StreamWriter file)
        {
            string outputNum = "";
            for (int i = 0; i < lines.Length; i++)
            {
                Int32.TryParse(lines[i], out int x);
                if (x % 3 == 0)
                {
                    outputNum += x + "\n";
                }
            }
            using (file)
            {
                file.WriteLine(outputNum);
            }
        }
    }
}