using System;
using System.Collections.Generic;
using System.Linq;
					
public class Program
{
	public static void Main()
	{
		List<int> numbers = new List<int>();
       
		
		Console.WriteLine("Enter a list of numbers, type 0 when finished.");
		
		while (true)
		{
			string userInput = Console.ReadLine();
			int userNumber = int.Parse(userInput);
			
			if (userNumber == 0)
			{
				break;
			}
			
			numbers.Add(userNumber);
		}
		foreach (int number in numbers)
		{
			Console.WriteLine($"The numbers that you entered were: {number}");
		}
		
		
		int sum = numbers.Sum();
		double average = numbers.Average();
		int max = numbers.Max();
		int min = numbers.Min();
		
		Console.WriteLine($"The sum of all numbers is: {sum}");
		Console.WriteLine($"The Average is: {average}");
		Console.WriteLine($"The lagest number is: {max}");
		Console.WriteLine($"The minimun number is: {min}");
		
	}
}