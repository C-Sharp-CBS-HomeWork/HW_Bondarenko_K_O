using System;

namespace Task_21
{
    class Program
    {
        delegate int Srednee(int a, int b, int c);
        static void Main(string[] args)
        {
            int a = 5 , b = 5 , c = 5;

            Srednee srednee = delegate (int a, int b, int c)
            {
                return (a + b + c) / 3;
            };

            Console.WriteLine(srednee(a,b,c));

            Console.ReadKey();
        }
    }
}
