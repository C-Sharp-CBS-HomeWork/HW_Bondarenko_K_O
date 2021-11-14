using System;

namespace Task_16_2
{
    class Program
    {
        static void Main(string[] args)
        {
            TXTHandler tXT = new TXTHandler();
            tXT.Create();
            tXT.Open();
            tXT.Chenge();
            tXT.Save();
            Console.WriteLine("");

            DOCHandler dOC = new DOCHandler();
            dOC.Create();
            dOC.Open();
            dOC.Chenge();
            dOC.Save();
            Console.WriteLine("");

            XMLHandler xML = new XMLHandler();
            xML.Create();
            xML.Open();
            xML.Chenge();
            xML.Save();
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
