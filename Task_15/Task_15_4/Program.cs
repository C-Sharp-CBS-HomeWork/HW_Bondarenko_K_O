using System;

namespace Task_15_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string strKey = "";
            strKey = Console.ReadLine();
            int i = 0;
            int key = 0;
            bool flaf = true;

            if (strKey != "")
            {
                while (i < strKey.Length)
                {
                    if (char.IsWhiteSpace(strKey[i]))
                    {                       
                        flaf = false;
                        break;
                    }                        
                    i++;
                }
                if (flaf)
                    key = int.Parse(strKey);
                else
                    strKey = "";
            }            

            

            if (strKey == "")
            {
                DocumentWorker documentWorker = new DocumentWorker();
                documentWorker.OpenDocument();
                documentWorker.EditDocument();
                documentWorker.SaveDocument();
            }
            else if ((key == 1)|(key == 2))
            {
                if (key == 1)
                {
                    DocumentWorker documentWorker = new ProDocumentWorker();
                    documentWorker.OpenDocument();
                    documentWorker.EditDocument();
                    documentWorker.SaveDocument();
                }
                if (key == 2)
                {
                    DocumentWorker documentWorker = new ExpertDocumentWorker();
                    documentWorker.OpenDocument();
                    documentWorker.EditDocument();
                    documentWorker.SaveDocument();
                }
            }            
        }
    }
}
