using System;
using System.Collections.Generic;
using System.Text;

namespace Task_15_2
{
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Study - Bad");
        }

        public override void Read()
        {
            Console.WriteLine("Read - Bad");
        }

        public override void Write()
        {
            Console.WriteLine("Write - Bad");
        }

        public override void Relax()
        {
            Console.WriteLine("Relax - Bad");
        }
    }
}
