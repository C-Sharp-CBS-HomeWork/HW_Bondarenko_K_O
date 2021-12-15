using System;

namespace Task_19_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            int train_number_find;
            Train[] trains = new Train[8];
            
            for (int i = 0; i < trains.Length; i++)
            {
                Console.Write("Введите номер поезда: ");
                trains[i].Train_number = int.Parse(Console.ReadLine());                

                Console.Write("Введите пункт назначения: ");
                trains[i].Destination = Console.ReadLine();

                Console.Write("Введите время оправления(YYYY/MM/DD hh:mm): "); // 5/1/2008 8:30:52
                trains[i].Departure_time = DateTime.Parse(Console.ReadLine());

                Console.Clear();
            }

            Console.Write("Введите номер поезда для поиска: ");
            train_number_find = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 0; i< trains.Length; i++)
            {
                if (train_number_find == trains[i].Train_number)
                {
                    Console.WriteLine("номер поезда: " + trains[i].Train_number);
                    Console.WriteLine("пункт назначения: " + trains[i].Destination);
                    Console.WriteLine("время оправления: " + trains[i].Departure_time);
                    flag = true;
                }

                if (i == trains.Length - 1 & flag == false)
                {
                    Console.WriteLine("Таких поездов нет!");
                }
            }    
        }
    }

    struct Train
    {
        private string destination;
        private int train_number;
        private DateTime departure_time;

        public string Destination
        {
            get
            {
                return destination;
            }

            set
            {
                destination = value;
            }
        }

        public int Train_number
        {
            get
            {
                return train_number;
            }

            set
            {
                train_number = value;
            }
        }

        public DateTime Departure_time
        {
            get
            {
                return departure_time;
            }

            set
            {
                departure_time = value;
            }
        }
    }
}
