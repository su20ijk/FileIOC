using System;

public class Class1
{
	public Class1()
	{
        Console.WriteLine("please enter the name of the file:");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        int[] nums = 
        int sum = 0;
        for (int i = 1; i < lines.Length; i += 2)
        {
            sum += nums[i]; 
        }

    }
}
