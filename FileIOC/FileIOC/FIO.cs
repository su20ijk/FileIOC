using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileIOC
{
    public class FIO
    {

        string fileName = Console.ReadLine();
            using (StreamReader sr = File.OpenText("D:\\repo\\FileIOC\\FileIOC\\FileIOC\\" + fileName + ".txt"))
            {
                if (sr.ToString() != null)
                {

                    string s = "";
                    do
                    {
                        s = sr.ReadLine();
                        int x = 0;
    Int32.TryParse(s, out x);
                        sum += x;
                    } while (s != null);
                }
            }

            using (StreamWriter file = new System.IO.StreamWriter("D:\\repo\\FileIOC\\FileIOC\\FileIOC\\Results.txt"))
            {
                file.WriteLine(sum); 
            }

    }
}
