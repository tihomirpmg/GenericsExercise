using System;
using System.Collections.Generic;

namespace _06._GenericCountMethodDoubles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box<double>> boxes = new List<Box<double>>();

            Console.Write("Insert an integer: ");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert the doubles you will compare to:");

            for (int i = 0; i < count; i++)
            {
                double value = double.Parse(Console.ReadLine());

                boxes.Add(new Box<double>(value));
            }
            Console.Write("Type the string you want to compare with: ");
            double element = double.Parse(Console.ReadLine());
            Console.WriteLine(CountGreater(boxes, element) + " bigger elements!");
        }

        static int CountGreater<T>(IEnumerable<Box<T>> collection, T element) where T : IComparable<T>
        {
            int counter = 0;

            foreach (var item in collection)
            {
                if (item.CompareTo(element) > 0)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
