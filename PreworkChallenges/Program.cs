using System;

namespace PreworkChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // ChallengeOne();
            //ChallengeTwo();
            //Console.WriteLine(ChallengeThree(new int[] { 1, 3, 2 }));
            int[,] myArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
            Console.WriteLine(string.Join(",", ChallengeFour(myArray)));
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

        static int[] ChallengeFour(int[,] numArr)
        {
            int[] result = new int[numArr.GetLength(0)];

            for (int i = 0; i < numArr.GetLength(0); i++)
            {
                int rowSum = 0;
                for (int j = 0; j < numArr.GetLength(1); j++)
                {
                    rowSum += numArr[i, j];
                }
                result[i] = rowSum;
            }

            return result;
        }
    }
}
