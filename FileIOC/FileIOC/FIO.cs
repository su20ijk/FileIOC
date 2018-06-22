using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FileIOC
{
    public class FIO
    {
        public static void DivThree(string[] lines, StreamWriter file)
        {
            string outputNum = "";
            for (int i=0; i<lines.Length;i++)
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