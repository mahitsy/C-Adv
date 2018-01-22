using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class TrafficJam
{
    public static void Main()
    {
        var carsPerGreenLight = int.Parse(Console.ReadLine());
        var car = Console.ReadLine();
        var carsQueue = new Queue<string>();
        var carCounter = 0;

        while (car != "end")
        {


            if (car == "green")
            {
                var carCanPass = Math.Min(carsPerGreenLight, carsQueue.Count);
                for (int counter = 0; counter < carCanPass; counter++)
                {
                    Console.WriteLine($"{carsQueue.Dequeue()} passed!");
                    carCounter++;
                }
            }
            else
            {
                carsQueue.Enqueue(car); 

            }

            car = Console.ReadLine();

        }

        Console.WriteLine("{0} cars passed the crossroads.", carCounter);
    }
}

