using System;

using System.Collections.Generic;

using System.IO;

using System.Linq;

using System.Reflection;

using System.Threading.Tasks;



namespace FileIOC
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("please enter the name of the input file:");
            string inputFileName = Console.ReadLine();
            var inPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            inPath += "/" + inputFileName + ".txt";
            Console.WriteLine("please enter the name of the output file:");
            string outFileName = Console.ReadLine();
            var outPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            outPath += "/" + outFileName + ".txt";
            string[] lines = System.IO.File.ReadAllLines(inPath);
            System.IO.StreamWriter file = new System.IO.StreamWriter(outPath);
            FileIO x = new FileIO();
            Console.WriteLine("1-List\n2-sum\n3-even\n4-odd\n5-fifth\n6-div by three");
            string option = Console.ReadLine();
            int intTemp = Convert.ToInt32(option);
            switch (intTemp)
            {
                case 1:

                    break;

                case 2:

                    break;

                case 3:

                    break;

                case 4:

                    x.odds(lines, file);

                    break;

                case 5:

                    break;

                case 6:

                    break;

                default:

                    break;

            }

        }

    }

}
