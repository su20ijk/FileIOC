using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FileIOC
{
    public class FIO
    {
        public static void DivThree(string filePath ,string path)
        {
            string outputNum = "";
            using (StreamReader sr = File.OpenText(filePath))
            {
                if (sr.ToString() != null)
                { 
                    string s = "";
                    do
                    {
                        s = sr.ReadLine();
                        int x = 0;
                        Int32.TryParse(s, out x);
                        if (x % 3 == 0) 
                        {
                            outputNum += x + "\n";
                        }
                    } while (s != null);
                }
            }
            using (StreamWriter file = new System.IO.StreamWriter(path+"/Results.txt"))
            {
                file.WriteLine(outputNum); 
            }
        }
    }
}
