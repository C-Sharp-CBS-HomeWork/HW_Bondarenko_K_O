using System;
using System.Collections.Generic;
using System.Text;

namespace Task_15_4
{
    class DocumentWorker
    {
        virtual public void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }

        virtual public void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }

        virtual public void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }
}
