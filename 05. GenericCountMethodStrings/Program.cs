using System;
using System.Collections.Generic;

namespace _05._GenericCountMethodStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box<string>> boxes = new List<Box<string>>();
            Console.Write("Insert an integer: ");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert the strings you will compare to:");
            for (int i = 0; i < count; i++)
            {
                string value = Console.ReadLine();

                boxes.Add(new Box<string>(value));
            }
            Console.Write("Type the string you want to compare with: ");
            string element = Console.ReadLine();
            Console.WriteLine(CountGreater(boxes, element) + " bigger elements!");
        }
        static int CountGreater<T>(IEnumerable<Box<T>> collect, T element) where T : IComparable<T>
        {
            int counter = 0;

            foreach (var item in collect)
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
