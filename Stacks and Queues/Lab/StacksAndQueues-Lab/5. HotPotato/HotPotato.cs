﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class HotPotato
{
    public static void Main()
    {
        var children = Console.ReadLine().Split(' ');
        var tossLimit = int.Parse(Console.ReadLine());
        var queue = new Queue<string>(children);

        while (queue.Count!=1)
        {
            for (int tossCounter = 1; tossCounter < tossLimit; tossCounter++)
            {
                queue.Enqueue(queue.Dequeue());
            }

            Console.WriteLine($"Removed {queue.Dequeue()}");
        }

        Console.WriteLine($"Last is {queue.Dequeue()}");
    }
}

