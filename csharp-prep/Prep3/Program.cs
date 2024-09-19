using System;
					
public class Program
{
	public static void Main()
	{
        Console.WriteLine("Hello! We are going to play to guess the number, let's start.");

        Random randomGenerator = new Random();
        int num = randomGenerator.Next(1, 101);

        int guess;

        
        do
		{
		Console.Write("What is your guess?"); 
		string number2 = Console.ReadLine();
		guess = int.Parse(number2);	

		if (guess < num)
		{
			Console.WriteLine("Greater");
		}
			
		else if (guess > num)
		{
			Console.WriteLine("Lower");
		}
		}	while (guess != num);

        if (guess == num)
        {
            Console.WriteLine("You did it!");
        }
			
	}
}