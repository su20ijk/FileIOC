using System;

public class odds
{
	public odds()
	{
        Console.WriteLine("please enter the name of the file:");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        int[] num = new int[lines.Length];
        for (int i = 0; i < num.Length; i++)
        {
            num[i] = Convert.ToInt32(lines[i]);
        }
        for (int i = 1; i < lines.Length; i += 2)
        {
            Console.Write(num[i] + ", "); 
        }
        Console.ReadKey();

    }
}
