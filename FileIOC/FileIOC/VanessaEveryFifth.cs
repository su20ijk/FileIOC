using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileIOC
{
    public static class VanessaEveryFifth
    {
        public static void fifth(string[] lines, System.IO.Stream.Writer File)
        {
            int counter = 0;
            string[] answer = new string[lines.Length % 5];
            for (int i = 4; i < lines.Length; i += 5)
            {
                answer[counter] = lines[i];
                counter++;
            }
            Console.WriteLine("Every fifth number:");
            foreach (string i in answer)
            {
                Console.WriteLine(i);
            }
        }
    }
}
