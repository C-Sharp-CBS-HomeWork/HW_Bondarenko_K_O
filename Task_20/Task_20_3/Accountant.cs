using System;
using System.Collections.Generic;
using System.Text;

namespace Task_20_3
{
    class Accountant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            if ((int)worker < hours)
            {
                Console.WriteLine("Премия положена");
                return true;
            }
            else
            {
                Console.WriteLine("Премия не положена");
                return false;
            }
        }
    }
}
