using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FileIOC
{
    public class VanessaEveryFifth
    {
        public static void Fifth(string[] lines, System.IO.StreamWriter file)
        {
            int counter = 0;
            string[] answer = new string[lines.Length % 5];
            for (int i = 4; i < lines.Length; i += 5)
            {
                answer[counter] = lines[i];
                counter++;
            }
            file.WriteLine("Every fifth number:");
            foreach (string i in answer)
            {
                file.WriteLine(i);
            }
            file.Close();
        }
    }
}
