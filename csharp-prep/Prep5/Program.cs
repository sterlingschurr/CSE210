using System;

class Program
{
    static void Main(string[] args)
    {

        sayHello();

        string userName = askForYourName();
        int favoriteNumber = favNumber();
        int squareNum = squareANumber(favoriteNumber);
        displayResult(userName, squareNum);
    }

    static void sayHello()
    {
        Console.WriteLine("Hello there!");
    }

    static string askForYourName()
    {
        Console.Write("What is your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int favNumber()
    {
        Console.Write("Waht is your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int squareANumber(int input)
    {
        int numToBeSquared = input * input;
        return numToBeSquared;
    }

    static void displayResult(string name, int square)
    {
        Console.WriteLine($"{name}, your number is {square}");
    }
}
