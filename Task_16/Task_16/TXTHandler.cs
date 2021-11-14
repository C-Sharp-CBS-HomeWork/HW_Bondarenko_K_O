using System;
using System.Collections.Generic;
using System.Text;

namespace Task_16_2
{
    class TXTHandler : AbstractHandler
    {
        override public void Open()
        {
            Console.WriteLine("TXT файл открыт");
        }
        override public void Create()
        {
            Console.WriteLine("TXT файл создан");
        }
        override public void Chenge()
        {
            Console.WriteLine("TXT файл изменен");
        }
        override public void Save()
        {
            Console.WriteLine("TXT файл сохранен");
        }
    }
}
