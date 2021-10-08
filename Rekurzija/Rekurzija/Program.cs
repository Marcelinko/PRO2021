using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekurzija
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine(Naloga3(2));
			Console.WriteLine(Naloga3(5));
			Console.WriteLine(Naloga4(2));
			Console.WriteLine(Naloga4(5));
			Console.WriteLine(Naloga5(2));
			Console.WriteLine(Naloga5(5));
			Console.ReadKey();
		}
		static int Fib(int st) 
		{
			if (st == 1 || st == 2)
				return 1;
			else
				return Fib(st - 1) + Fib(st - 2);
		}
		static int PotencaLiterativno(int st) {
			int potenca = 1;
			for (int i = 0; i <= st; i++)
			{
				potenca = potenca * 2;
			}
			return potenca;
		}
		static int PotencaRekurzivno(int st)
		{
			if (st == 0) 
			{
				return 1;
			}
			return 2 * PotencaRekurzivno(st - 1);
		}
		static int Naloga3(int st)
        {
			if (st <= 2)
				return 2;
			return Naloga3(st - 2) * Naloga3(st - 1) - 1;
        }
		static int Naloga4(int st)
		{
			if (st == 1)
				return 2;
			return 3* Naloga4(st - 1) + 2;
		}
		static int Naloga5(int st)
		{
			if (st == 1)
				return 1;
			if (st == 2)
				return 2;
			return Naloga5(st - 1)*2+Naloga5(st-2);
		}

	}
}
