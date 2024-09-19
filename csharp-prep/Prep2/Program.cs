using System;

class Program
{
    static void Main(string[] args)
    {
		Console.Write("What is your grade porcentage?");
		string x = Console.ReadLine();
		int grade = int.Parce(x);
				
		
		if (grade >= 90)
		{
			Console.WriteLine("Your grade is A");
			Console.WriteLine("Congratilations, you passed the course!");
		}
		else (grade >= 80)
		{
			Console.WriteLine("Your grade is B");
			Console.WriteLine("Congratilations, you passed the course!");
		}
		else (grade >= 70)
		{
			Console.WriteLine("Your grade is C");
			Console.WriteLine("Congratilations, you passed the course!");
		}
		else (grade >= 60)
		{
			Console.WriteLine("Your grade is D");
		}
		else if (grade > 60)
		{
			Console.WriteLine("Your grate than F");
		}
		else
		{
			Console.WriteLine("Please enter a valid grade");
		}
		
	}
}