using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_18
{
	static class Calculator
	{
		public static int Plus(int x, int y)
		{
			int rezult = x + y;
			return rezult;
		}

		public static int Substract(int x,int y)
		{
			int rez = x - y;
			return rez;
		}

		public static double Multipley(int x, int y)
		{
			double rez = x * y;
			return rez;
		}

		public static double Divide(int x, int y)
		{
			double rez = x / y;
			return rez;
		}
	}
}
