using System;
using System.Collections.Generic;
using System.Text;

namespace Task_14_4
{
    class Invoice
    {
        readonly int  account;
        readonly string customer;
        readonly string provider;
        string article;
        int quantity;

        public Invoice()
        {
            account = 10024;
            customer = "Вася";
            provider = "Вилка";
        }

        public void Res()
        {
            Console.WriteLine("Выберите товар: ");
            Console.WriteLine("1 - Ведро");
            Console.WriteLine("2 - Большой адронный коллайдер");
            int tovar = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество товара: ");
            quantity = int.Parse(Console.ReadLine());

            double prize = 0;
            double NDS;
             
            if (tovar == 1)
            {
                article = "Ведро";
                prize = 10;
            }
            if (tovar == 2)
            {
                article = "Большой адронный коллайдер";
                prize = 1000000;
            }

            Console.WriteLine("Выберите формат вывода: ");
            Console.WriteLine("1 - С НДС");
            Console.WriteLine("2 - Без НДС");
            int count = int.Parse(Console.ReadLine());

            if (count == 1)
            {
                Console.Clear();
                Console.WriteLine("покупатель " + customer);
                Console.WriteLine("поставщик " + provider);
                Console.WriteLine("изделие " + article);
                Console.WriteLine("количество " + quantity);
                NDS = prize * 0.1;
                Console.WriteLine("Цена за единицу " + prize);
                Console.WriteLine("NDS " + NDS);
                Console.WriteLine("Сумма к оплате " + ((prize * quantity) + (NDS * quantity)));
            }
            if (count == 2)
            {
                Console.Clear();
                Console.WriteLine("покупатель " + customer);
                Console.WriteLine("поставщик " + provider);
                Console.WriteLine("изделие " + article);
                Console.WriteLine("количество " + quantity);
                Console.WriteLine("Цена за единицу " + prize);                
                Console.WriteLine("Сумма к оплате " + prize * quantity);
            }
        }
    }
}
