﻿using System;

namespace BackwardsString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            for (int i = name.Length - 1; i >=0; i--)
            {
                Console.WriteLine(name[i]);
            }
        }
    }
}
