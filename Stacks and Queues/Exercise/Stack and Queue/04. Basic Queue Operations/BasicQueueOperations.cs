using System;
using System.Collections.Generic;
using System.Linq;


public class BasicQueueOperations
{
    public static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var enqueueElements = input[0];
        var dequeueElements = input[1];
        var target = input[2];

        var queue = new Queue<int>();

        for (int queueCounter = 0; queueCounter < enqueueElements; queueCounter++)
        {
            queue.Enqueue(elements[queueCounter]);
        }

        for (int dequeueCounter = 0; dequeueCounter < dequeueElements; dequeueCounter++)
        {
            queue.Dequeue();
        }

        if (queue.Contains(target))
        {
            Console.WriteLine("true");
        }else if (queue.Count == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            Console.WriteLine(queue.Min());
        }
    }
}
