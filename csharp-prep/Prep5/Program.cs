using System;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
	{
		DisplayWelcome();
		string userName = PromptUserName();
		int userNumber = FavNumber();
        int SquaredNumber = SquareNumber(userNumber);
        DisplayAll(userName, SquaredNumber);
	}

	static void DisplayWelcome()
	{
		Console.WriteLine("Welcome to the Program!");
	}
	
	//--------User name--------
	
	static string PromptUserName()
	{
		Console.WriteLine("What is your name");
		string userName = Console.ReadLine();
        return userName;
	}
	//--------User Number----------
	static int FavNumber()
	{
		Console.WriteLine("What is your favorite number?");
		//string userNumber = Console.ReadLine();
		int number = int.Parse(Console.ReadLine());

        return number;
	}
    //-------Square----------

    static int SquareNumber(int number)
    {
        int square = number * number;

        return square;
    }

    //---------All------------

    static void DisplayAll(string userName, int square)
    {
        Console.WriteLine($"Brother {userName} the square of your number is {square}");
    }
	
	//Callings
	
}