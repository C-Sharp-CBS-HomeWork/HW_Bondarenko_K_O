using System;

namespace Task_21_2
{
    class Program
    {
        delegate int MyDel(int a, int b); 
        static void Main(string[] args)
        {
            int a = 5; int b = 12;

            MyDel myDelPL = (a, b) => a + b;
            MyDel myDelMIN = (a, b) => a - b;
            MyDel myDelUMN = (a, b) => a * b;
            MyDel myDelRAZ = (a, b) => a / b;

            Console.WriteLine(myDelPL(a, b));
            Console.WriteLine(myDelMIN(a, b));
            Console.WriteLine(myDelUMN(a, b));
            if ((a != 0) || (b != 0))
                Console.WriteLine(myDelRAZ(b , a));

            Console.ReadKey();
        }
    }
}
