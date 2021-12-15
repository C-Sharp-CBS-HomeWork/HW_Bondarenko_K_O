using System;

namespace Task_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("Best_model", 10000 , "Podval");

            notebook.Note_Show();

            Console.ReadKey();
        }
    }

    struct Notebook 
    {
        private string model;
        private int prize;
        private string manufacturer;

        public Notebook(string model, int prize, string manufacturer)
        {
            this.model = model;
            this.prize = prize;
            this.manufacturer = manufacturer;
        }

        public void Note_Show()
        {
            Console.WriteLine("model: " + model);
            Console.WriteLine("prize: " + prize);
            Console.WriteLine("manufacturer: " + manufacturer);
        }
    }
}
