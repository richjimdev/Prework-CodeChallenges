using System;

namespace PreworkChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //ChallengeOne();
            //ChallengeTwo();
            Console.WriteLine($"Testing [1, 3, 2]. Answer: {ChallengeThree(new int[] { 1, 3, 2 })}");
            Console.WriteLine($"Testing [0, 0, 0, 0]. Answer: {ChallengeThree(new int[] { 0, 0, 0, 0 })}");
            Console.WriteLine($"Testing [4, 5, 6]. Answer: {ChallengeThree(new int[] { 4, 5, 6 })}");
            Console.WriteLine($"Testing [0, 2, -2]. Answer: {ChallengeThree(new int[] { 0, 2, -2 })}");
            Console.ReadLine();
        }

        static void ChallengeOne()
        {
            Random rng = new Random();
            int[] randArray = { rng.Next(1, 10),
                rng.Next(1, 10),
                rng.Next(1, 10),
                rng.Next(1, 10),
                rng.Next(1, 10) };

            string arrToString = string.Join(", ", randArray);
            Console.WriteLine($"Select a number from this list: {arrToString}");

            int choice = Int32.Parse(Console.ReadLine());

            int count = 0;
            foreach (int num in randArray)
            {
                if (num == choice)
                    count++;
            }

            Console.WriteLine($"Your score is { choice * count }");

        }

        static void ChallengeTwo()
        {
            Console.WriteLine("Input a year to check if it's a leap year:");
            int year = Int32.Parse(Console.ReadLine());
            string incorrect = "This is not a leap year";
            string correct = "This is a leap year";
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                        Console.WriteLine(correct);
                    else
                        Console.WriteLine(incorrect);
                }
                else
                    Console.WriteLine(correct);
            } else
                Console.WriteLine(incorrect);
        }

        static string ChallengeThree(int[] arr)
        {
            int sum = 0;
            int product = 1;
            foreach (int num in arr)
            {
                if (num < 0) return "no";
                sum += num;
                product *= num;
            }
            if (sum == product) return "yes";
            return "no";
        }
    }
}
