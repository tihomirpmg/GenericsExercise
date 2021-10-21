using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._GenericSwapMethodStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var boxes = new List<Box<string>>();

            Console.Write("Insert the number of strings you want to input: ");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert the strings:");

            for (int i = 0; i < count; i++)
            {
                string value = Console.ReadLine();
                boxes.Add(new Box<string>(value));
            }
            Console.Write("Insert the indexes of strings you want to swap: ");
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
