using System;

namespace _1.GenericBoxOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert the number of strings you want to input: ");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert the strings:");

            for (int i = 0; i < count; i++)
            {
                string value = Console.ReadLine();
                Box<string> box = new Box<string>(value);
                Console.WriteLine(box);
            }
        }
    }
}
