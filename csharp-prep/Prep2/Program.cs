    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your grade porcentage?");
            string x = Console.ReadLine();
            int grade = int.Parse(x);

            string letter = "";
                    
            
            if (grade >= 90)
            {
                letter = "A";
            }
            else if (grade >= 80)
            {
                letter = "B";
            }
            else if (grade >= 70)
            {
                letter = "C";
            }
            else if(grade >= 60)
            {
                letter = "D";
            }
            else 
            {
                letter = "F";
            }

            Console.WriteLine($"Your grade is {letter}");

            if (grade >= 70)
            {
                Console.WriteLine("You passed!");
            }
            else
            {
                Console.WriteLine("You did not passed, keep trying");
            }
            
        }
    }