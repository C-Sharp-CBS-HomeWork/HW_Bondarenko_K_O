using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_18_2
{
	class Note
	{
		public readonly int frequency;
		public readonly int duration;

		public Note( int frequency, int duration)
		{
			this.frequency = frequency;
			this.duration = duration;
		}

		public static Note CreateDo()
		{
			return new Note(261, 1000);
		}

		public static Note CreateRe()
		{
			return new Note(564, 1000);
		}

		public static Note CreateMee()
		{
			return new Note(721, 1000);
		}

		public static Note CreateFu()
		{
			return new Note(182, 1000);
		}

		public static Note CreatSol()
		{
			return new Note(555, 1000);
		}

		public static Note CreateLay()
		{
			return new Note(32000, 1000);
		}

		public static Note CreateSee()
		{
			return new Note(2998, 1000);
		}

		public static Note CreatePause()
		{
			return new Note(37, 1000);
		}
	}
}
