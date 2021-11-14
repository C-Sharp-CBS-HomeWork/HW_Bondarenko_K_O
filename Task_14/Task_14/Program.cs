using System;

namespace Task_14
{
    class Program
    {
        static void Main(string[] args)
        {    
            Converter converter = new Converter(0.038, 0.033, 2.66);

            for (int i = 0 , count = 0; i <= 0; i++)
            {
                Console.Write("Введите количество гривен: ");
                double grn = double.Parse(Console.ReadLine());

                Console.WriteLine("Для конвертации валюты в ДОЛ нажмите 1, в ЕВРО нажмите 2, в Рубль нажмите 3");
                Console.WriteLine(converter.ConvertFromGrn(grn, int.Parse(Console.ReadLine()))); 

                Console.WriteLine("Выберите валюту из которой конвертируете в Гривну нажав соответствующую цифру: 1 - Доллар, 2 - Евро, 3 - Рубль");
                count = int.Parse(Console.ReadLine());

                if (count == 1)
                {
                    Console.Write("Введите колличестов Долларов ");
                    Console.WriteLine(converter.ConvertUsdToGrn(double.Parse(Console.ReadLine())));
                }
                else if(count == 2)
                {
                    Console.Write("Введите колличество Евро ");
                    Console.WriteLine(converter.ConvertEurToGrn(double.Parse(Console.ReadLine())));
                }
                else if(count == 3)
                {
                    Console.Write("Введите количество Рублей ");
                    Console.WriteLine(converter.ConvertRubToGrn(double.Parse(Console.ReadLine()))); 
                }

                Console.WriteLine("если хотите повтторить нажмите 1");
                if (int.Parse(Console.ReadLine()) == 1)
                    i -= 1;
            }

            Console.ReadKey();
        }
    }
}
