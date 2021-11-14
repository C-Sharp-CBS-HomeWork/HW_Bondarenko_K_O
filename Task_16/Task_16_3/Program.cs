using System;

namespace Task_16_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Play();
            player.Pause();
            player.Stop();
            Console.WriteLine("");
            player.Record();
            player.Pause();
            player.Stop();
        }
    }
}
