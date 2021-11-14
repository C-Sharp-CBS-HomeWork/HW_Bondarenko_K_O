using System;
using System.Collections.Generic;
using System.Text;

namespace Task_15_4
{
    class ExpertDocumentWorker : ProDocumentWorker
    {
        override public void EditDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
}
