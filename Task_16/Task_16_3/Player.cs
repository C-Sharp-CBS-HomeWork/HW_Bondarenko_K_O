using System;
using System.Collections.Generic;
using System.Text;

namespace Task_16_3
{
    class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Play");
        }
        public void Pause()
        {
            Console.WriteLine("Pause");
        }
        public void Stop()
        {
            Console.WriteLine("Stop");
        }

        public void Record()
        {
            Console.WriteLine("Record");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Stop Record");// не понял как вызвать конкретно этот этот!!!!
        }   

    }
}
