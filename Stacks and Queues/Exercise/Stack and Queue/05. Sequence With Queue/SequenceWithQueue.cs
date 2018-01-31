using System;
using System.Collections.Generic;
using System.Linq;


public class SequenceWithQueue
{
    public static void Main()
    {
        var first = int.Parse(Console.ReadLine());
        var queue = new Queue<int>();
        var result = new List<int>();

        queue.Enqueue(first);
        result.Add(first);

        while (result.Count < 50)
        {
            int current = queue.Dequeue();

            queue.Enqueue(current + 1);
            queue.Enqueue(2 * current + 1);
            queue.Enqueue(current + 2);

            result.Add(current + 1);
            result.Add(2 * current + 1);
            result.Add(current + 2);

        }

        Console.WriteLine(string.Join(" ",result.Take(50)));
    }
}

