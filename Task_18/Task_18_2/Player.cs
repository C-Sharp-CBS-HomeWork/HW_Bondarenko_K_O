using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_18_2
{
	static class Player
	{
		
		public static void play(Note[] notes)
		{
			foreach(Note note in notes)
			{
				if(note.frequency == 0)
				{
					Thread.Sleep(note.duration);
				}
				else
				Console.Beep(note.frequency , note.duration);
			}
		}
	}
}
