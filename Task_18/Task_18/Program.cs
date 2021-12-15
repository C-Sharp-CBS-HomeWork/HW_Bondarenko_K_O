using System;

namespace Task_18
{
	class Program
	{
		static void Main(string[] args)
		{
			Random random = new Random();

			int x = random.Next(1, 100);
			int y = random.Next(1, 100);

			Console.WriteLine(Calculator.Divide(x,y));
			Console.WriteLine(Calculator.Multipley(x,y));
			Console.WriteLine(Calculator.Plus(x,y));
			Console.WriteLine(Calculator.Substract(x,y));

			Console.ReadKey();
		}
	}
}
