using System;

namespace Task_17_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива: ");
            int N = int.Parse(Console.ReadLine());

            Random random = new Random();

            int[] vs = new int[N];

            for (int i = 0; i <= vs.Length -1; i++)
            {
                vs[i] = random.Next(0, 10);
            }

            int MaxVs(int [] vs)
            {
                int max = vs[0];
                for (int i = 1; i<=vs.Length - 1; i++)
                {
                    if (vs[i] > max)
                    {
                        max = vs[i];
                    }
                }
                return max;
            }

            int MinVs(int[] vs)
            {
                int min = vs[0];
                for (int i = 1; i <= vs.Length -1 ; i++)
                {
                    if (vs[i] < min)
                    {
                        min = vs[i];
                    }
                }
                return min;
            }

            int Sum(int [] vs)
            {
                int sum = 0;
                for(int i = 0; i<=vs.Length - 1; i++)
                {
                    sum += vs[i];
                }
                return sum;
            }

            double SrAR (int [] vs)
            {
                double res = (double)Sum(vs) / vs.Length;
                return res;
            }

            void NotChet(int [] vs)
            {
                for(int i = 0;i <= vs.Length -1; i++)
                {
                    if(vs[i] % 2 != 0)
                    {
                        Console.Write(vs[i] + " ");
                    }
                }
            }

            Console.Write("Созданный массив: ");

            for (int i = 0; i <= vs.Length - 1; i++)
            {
                Console.Write(vs[i] + " ");
            }

            Console.WriteLine("");

            Console.WriteLine("Максимальное значение массива: " + MaxVs(vs));
            Console.WriteLine("Минимальное значение массива: " + MinVs(vs));
            Console.WriteLine("Сумма всех элементов массива: " + Sum(vs));
            Console.WriteLine("среднее арифметическое всех элементов массива: " + SrAR(vs));

            Console.WriteLine("");
            Console.Write("Все нечетные числа массива: ");
            NotChet(vs);

            Console.ReadKey();
        }
    }
}
