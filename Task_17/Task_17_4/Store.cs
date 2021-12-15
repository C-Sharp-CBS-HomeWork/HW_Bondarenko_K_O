using System;
using System.Collections.Generic;
using System.Text;

namespace Task_17_4
{
    class Store
    {
        private string[] key = new string[2];
        private Article[] value = new Article[2];

        public Store()
        {
            key[0] = ""; value[0] = new Article();
            key[1] = ""; value[1] = new Article();           
        }
   
        public void Add()
        {
            for (int i =0; i < key.Length; i++)
            {
                Console.WriteLine("Введите имя товара");
                value[i].Name = Console.ReadLine();
                key[i] = value[i].Name;

                Console.WriteLine("Введите цену");
                value[i].Price = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите имя магазина");
                value[i].StorName = Console.ReadLine();
            }           
        }

        public string this[string index] 
        {
            get
            {
                for(int i =0; i < key.Length; i++)
                {
                    if(key[i] == index)
                    {
                        return key[i] + "-" + value[i].StorName + "-" + value[i].Price;
                    }
                }

                return string.Format("{0} - нет такого товара.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + value[index].StorName + "-" + value[index].Price;
                else
                    return "Попытка обращения за пределы массива.";
            }
        }
    }
}
