using System;
using System.Threading;

namespace Lab10 {
	public class Zadanie2 {
		public void Run() {

			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Zadanie2");

			new Thread(Run2).Start(); // Uruchom Run2 w innym wątku
			Run2(); // Uruchom Run2 w głownym wątku
		}

		static void Run2() {
			// Deklaracja i użycie zmiennej lokalnej - 'cycles'
			for (int cycles = 0; cycles < 5; cycles++) Console.Write('x');
		}

	}
}
