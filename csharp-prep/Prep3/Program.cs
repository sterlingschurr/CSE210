using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        bool didjaGetIt = false;

        do
        {
            Console.WriteLine("Guess a number");
            int guess = int.Parse(Console.ReadLine());

            if (guess > number)
                Console.WriteLine("Too high");
            else if (guess < number)
                Console.WriteLine("Too low");
            else if (guess == number)
                didjaGetIt = true;
        } while (!didjaGetIt);
        Console.WriteLine("You got it! You win nothing.");

    }
}