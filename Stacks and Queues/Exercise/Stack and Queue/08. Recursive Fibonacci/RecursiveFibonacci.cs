using System;


public class RecursiveFibonacci
{
    public static void Main()
    {
        var wantedFibonacci = int.Parse(Console.ReadLine());
        long prevNumber = 1;
        long number = 1;
        long currentNumber = 0;

        if (wantedFibonacci.Equals(1)|| wantedFibonacci.Equals(2))
        {
            Console.WriteLine(1);
            return;
        }
        
        for (int counter = 2; counter < wantedFibonacci; counter++)
        {
            currentNumber = prevNumber + number;
            prevNumber = number;
            number = currentNumber;
            

        }

        Console.WriteLine(currentNumber);
    }
}

