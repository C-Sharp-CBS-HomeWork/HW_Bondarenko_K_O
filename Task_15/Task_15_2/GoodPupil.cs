using System;
using System.Collections.Generic;
using System.Text;

namespace Task_15_2
{
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Study - Good");
        }

        public override void Read()
        {
            Console.WriteLine("Read - Good");
        }

        public override void Write()
        {
            Console.WriteLine("Write - Good");
        }

        public override void Relax()
        {
            Console.WriteLine("Relax - Good");
        }
    }
}
