using System;

namespace Task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();

            address.Country = "Советский Союз";
            address.City = "Ленинград";
            address.Index = 187015;
            address.Street = "3-я улица Строителей";
            address.House = 25;
            address.Apartment = 12;

            Console.WriteLine("Страна " + address.Country);
            Console.WriteLine("Город " + address.City);
            Console.WriteLine("Почтовый индекс " + address.Index);
            Console.WriteLine("Улица " + address.Street);
            Console.WriteLine("дом №" + address.House);
            Console.WriteLine("квартира №" + address.Apartment);

            Console.ReadKey();
        }
    }
}
