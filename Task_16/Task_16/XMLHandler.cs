using System;
using System.Collections.Generic;
using System.Text;

namespace Task_16_2
{
    class XMLHandler : AbstractHandler
    {
        override public void Open()
        {
            Console.WriteLine("XML файл открыт");
        }
        override public void Create()
        {
            Console.WriteLine("XML файл создан");
        }
        override public void Chenge()
        {
            Console.WriteLine("XML файл изменен");
        }
        override public void Save()
        {
            Console.WriteLine("XML файл сохранен");
        }
    }
}
