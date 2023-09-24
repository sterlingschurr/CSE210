using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> allOfMyNumbers = new List<int>();
        int inputNum = 1;

        while (inputNum != 0)
        {
            Console.Write("Gimme a number: ");
            string inputString = Console.ReadLine();
            inputNum = int.Parse(inputString);
            if (inputNum != 0)
                allOfMyNumbers.Add(inputNum);
        }
        int sumOfMyNum = 0;
        foreach (int i in allOfMyNumbers)
        {
            sumOfMyNum += i;
        }
        Console.WriteLine($"The total is {sumOfMyNum}");
        float average = ((float)sumOfMyNum) / allOfMyNumbers.Count;
        Console.WriteLine($"The average is {average}");

        int max = allOfMyNumbers[0];
        foreach (int j in allOfMyNumbers)
        {
            if (j > max)
                max = j;
        }
        Console.WriteLine($"The greatest of these is: {max}");
    }
}