using System;
using System.IO;

namespace FileIOC
{
    public class FileIOC
    {
        public static void Main(string[] args)
        {
            string filename = Console.ReadLine();
                    if (filename.Length > 5)
                    {
                        for (int i = 0; i < filename.Length + 1; i += 5)
                        {
                            string x = filename.Remove(i);
                            if (x.Equals(1) || x.Equals(2) || x.Equals(3) || x.Equals(4) || x.Equals(5) || x.Equals(6) || x.Equals(7) || x.Equals(8) || x.Equals(9))
                                Console.WriteLine(x);
                        }
                    }
                    else
                    {
                        Console.WriteLine("The file size isn't large enough to display a fifth variable.");
                    }
                    Console.Read();
                
        }
    }
}