using System;
using System.Collections.Generic;


public class Program
{
    public static void Main()
    {

        var input = int.Parse(Console.ReadLine());
        var fibonacciStack = new Stack<long>();
        var numberToPush = 0;

        for (int counter = 0; counter < input; counter++)
        {
            if (counter <= 2)
            {
                fibonacciStack.Push(numberToPush);
                numberToPush++;
            }
            else if (counter > 2)
            {
                long currentNumber = fibonacciStack.Pop();
                long prevNumber = fibonacciStack.Peek();
                fibonacciStack.Push(currentNumber);
                fibonacciStack.Push(currentNumber + prevNumber);
            }


        }

        Console.WriteLine(fibonacciStack.Peek());
    }
}

