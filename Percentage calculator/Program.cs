using System;

namespace Percentage_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int Maximum;
            int userScore;
            double Result;

            Console.WriteLine("what is the maximum score?");
            Maximum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is your score?");
            userScore = Int32.Parse(Console.ReadLine());
            Result = (userScore * 100) / Maximum;

            Console.WriteLine($"You scored {Result}%. ");
            if (userScore >= 90)
            {
                Console.WriteLine($"You scored {userScore},you got 5");
            } 
            else if (userScore >= 80)
            {
                Console.WriteLine($"You scored {userScore},you got 4");
            }
            else if (userScore >= 61)
            {
                Console.WriteLine($"You scored {userScore}, you got 3");
            }
            else
            {
                Console.WriteLine($"You scored {userScore},you got 2 ");
            }
            

        }
    }
}
