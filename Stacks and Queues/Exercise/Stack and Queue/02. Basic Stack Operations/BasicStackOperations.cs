using System;
using System.Collections.Generic;
using System.Linq;


public class BasicStackOperations
{
    public static void Main()
    {
        var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
            .ToArray();

        var elementsToPush = input[0];
        var popsElement = input[1];
        var target = input[2];

        var element = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var stack = new Stack<int>();

        for (int pushCounter = 0; pushCounter < elementsToPush; pushCounter++)
        {
            stack.Push(element[pushCounter]);
        }

        for (int popCounter = 0; popCounter < popsElement; popCounter++)
        {
            stack.Pop();
        }

        if (stack.Contains(target))
        {
            Console.WriteLine(true);
        }
        else if (stack.Count == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            Console.WriteLine(stack.Min());
        }

    }
}

