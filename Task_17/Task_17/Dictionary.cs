using System;
using System.Collections.Generic;
using System.Text;

namespace Task_17
{
    class Dictionary
    {
        private string[] key = new string[10];
        private string[] value = new string[10];

        public Dictionary()
        {
            key[0] = "книга"; value[0] = "book";
            key[1] = "ручка"; value[1] = "pen";
            key[2] = "солнце"; value[2] = "sun";
            key[3] = "яблоко"; value[3] = "apple";
            key[4] = "стол"; value[4] = "table";
            key[5] = "book"; value[5] = "книга";
            key[6] = "pen"; value[6] = "ручка";
            key[7] = "sun"; value[7] = "сонце";
            key[8] = "apple"; value[8] = "яблуко";
            key[9] = "table"; value[9] = "стіл";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                    if (key[i] == index)
                    {
                        for (int j = 0; j < key.Length; j++)
                        {
                            if (key[j] == value[i])
                                return key[i] + " - " + value[i] + " - " + value[j];
                        }
                    }


                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + value[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }
    }
}
