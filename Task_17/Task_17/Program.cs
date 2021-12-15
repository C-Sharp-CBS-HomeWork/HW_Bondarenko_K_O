﻿using System;

namespace Task_17
{
    class Program
    {
        static void Main(string[] args)
        {            
            Dictionary dictionary = new Dictionary();

            Console.WriteLine(dictionary["книга"]);
            Console.WriteLine(dictionary["дом"]);
            Console.WriteLine(dictionary["ручка"]);
            Console.WriteLine(dictionary["стол"]);
            Console.WriteLine(dictionary["карандаш"]);
            Console.WriteLine(dictionary["яблоко"]);
            Console.WriteLine(dictionary["солнце"]);

            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(dictionary[i]);
            }

            Console.ReadKey();
        }
    }
}
