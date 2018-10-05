using System;

namespace PreworkChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            ChallengeOne();
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
                {
                    count++;
                }
            }

            Console.WriteLine($"Your score is { choice * count }");
            Console.ReadLine();
        }
    }
}
