using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileIOC
{
    public static class VanessaEveryFifth
    {
        public static string[] fifth(string[] numbers)
        {
            int counter = 0;
            string[] answer = new string[numbers.Length % 5];
            for (int i = 4; i < numbers.Length; i += 5)
            {
                answer[counter] = numbers[i];
                counter++;
            }
            return answer;
        }
    }
}
