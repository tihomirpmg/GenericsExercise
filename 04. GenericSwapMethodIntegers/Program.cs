using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._GenericSwapMethodIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            var boxes = new List<Box<int>>();

            Console.Write("Insert the number of integers you want to input: ");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert the integers:");

            for (int i = 0; i < count; i++)
            {
                int value = int.Parse(Console.ReadLine());
                boxes.Add(new Box<int>(value));
            }
            Console.Write("Insert the indexes of integers you want to swap: ");
            int[] indices = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Swap(boxes, indices[0], indices[1]);

            foreach (var box in boxes)
            {
                Console.WriteLine(box);
            }
        }
        static void Swap<T>(IList<Box<T>> list, int index1, int index2)
        {
            Box<T> temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }
    }
}
