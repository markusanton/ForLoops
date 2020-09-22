using System;

namespace BottleSong
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 99;
            for (i = 99; i > 0; i--)
            {
                Console.WriteLine($"{i} bottles of beer on the wall, {i} bottles of beer.");
                Console.WriteLine($"Take one down, pass it around, {i - 1} bottles of beer on the wall.");
            }
            Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer.");
        }
    }
}
