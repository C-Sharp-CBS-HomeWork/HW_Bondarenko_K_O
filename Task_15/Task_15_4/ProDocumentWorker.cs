using System;
using System.Collections.Generic;
using System.Text;

namespace Task_15_4
{
    class ProDocumentWorker : DocumentWorker
    {
        override public void OpenDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }

        override public void EditDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате");
        }

        override public void SaveDocument()
        {
            Console.WriteLine("сохранение в остальных форматах доступно в версии Эксперт");
        }
    }
}
