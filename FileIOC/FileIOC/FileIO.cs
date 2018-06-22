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