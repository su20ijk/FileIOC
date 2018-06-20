using System;

public class Class1
{
	public Class1()
	{
        Console.WriteLine("please enter the name of the file:");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        int[] num = new int[lines.Length];
        for (int i = 0; i < num.Length; i++)
        {
            num[i] = Convert.ToInt32(lines[i]);
        }
        int sum = 0;
        for (int i = 1; i < lines.Length; i += 2)
        {
            Console.WriteLine(num[i] + ", "); 
        }
        

    }
}
