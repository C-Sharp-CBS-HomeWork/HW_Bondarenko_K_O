using System;

namespace Task_18_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vs = new int[4];

            Random random = new Random();

            for (int i = 0; i < vs.Length - 1; i++)
            {
                vs[i] = random.Next(0, 10);
            }

            Console.Write("неотсортированый массив: ");
            for (int i = 0; i < vs.Length; i++)
            {
                Console.Write(vs[i] + " ");
            }

            Console.WriteLine("");
            Console.WriteLine("");

            vs.SortInt();

            Console.Write("отсортированый массив: ");
            for (int i = 0; i < vs.Length; i++)
            {
                Console.Write(vs[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
