using System;

namespace _02._GenericBoxofInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert the number of integers you want to input: ");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert the integers:");

            for (int i = 0; i < count; i++)
            {
                int value = int.Parse(Console.ReadLine());
                var box = new Box<int>(value);

                Console.WriteLine(box);
            }
        }
    }
}
