using System;
using System.Collections.Generic;
using System.Text;

namespace Task_16_2
{
    class DOCHandler : AbstractHandler
    {
        override public void Open()
        {
            Console.WriteLine("DOC файл открыт");
        }
        override public void Create()
        {
            Console.WriteLine("DOC файл создан");
        }
        override public void Chenge()
        {
            Console.WriteLine("DOC файл изменен");
        }
        override public void Save()
        {
            Console.WriteLine("DOC файл сохранен");
        }
    }
}
