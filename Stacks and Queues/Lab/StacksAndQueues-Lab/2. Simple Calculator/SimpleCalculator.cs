using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class SimpleCalculator
{
    public static void Main()
    {
        var input = Console.ReadLine().Split(' ').Reverse();
       // var elements = input.Split(' ');
        var stack = new Stack<string>(input);

       /* for (int counter = elements.Length-1; counter >= 0; counter--)
        {
         
            stack.Push(elements[counter]);
            
        }*/

        while (stack.Count>1)
        {
            var leftOperand = int.Parse(stack.Pop());
            var operation = stack.Pop();
            var rightOperand = int.Parse(stack.Pop());

            switch (operation)
            {
                case "+":
                    stack.Push((leftOperand+rightOperand).ToString());
                    break;
                case "-":
                    stack.Push((leftOperand - rightOperand).ToString());
                    break;
            }
        }

        Console.WriteLine(stack.Pop());


    }
}

