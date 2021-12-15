using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_18_2
{
	static class MelodyParser
	{
		public static Note [] ParseMelody(string melody)
		{
			Note[] notes = new Note[melody.Length];

			int i = -1;

			foreach (char x in melody)
			{
				i++;

				switch (x)
				{
					case '1':
						notes[i] = Note.CreateDo();
						break;
					case '2':
						notes[i] = Note.CreateFu();
						break;
					case '3':
						notes[i] = Note.CreateLay();
						break;
					case '4':
						notes[i] = Note.CreateMee();
						break;
					case '5':
						notes[i] = Note.CreateRe();
						break;
					case '6':
						notes[i] = Note.CreateSee();
						break;
					case ' ':
						notes[i] = Note.CreatePause();
						break;
					case '7':
						notes[i] = Note.CreatSol();
						break;
					case '8':
						notes[i] = Note.CreateDo();
						break;
					case '9':
						notes[i] = Note.CreatSol();
						break;						
				}					
			}

			return notes;
		}
		
		public static Note[] ParseTrue(string melody)
		{
			List<Note> notes = new List<Note>();
			var mel = melody.Split(new char[] { ';' } , StringSplitOptions.RemoveEmptyEntries);

			foreach (var x in mel)
			{
				var numbers = x.Split(',');

				var freq = int.Parse(numbers[0]);
				var durat = int.Parse(numbers[1]);

				notes.Add(new Note(freq, durat));
			}

			return notes.ToArray();
		} 
	}
}
