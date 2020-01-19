using System;
using System.Threading;

namespace Lab10 {
	public class Zadanie4 {

		static bool done; // Pole statyczne
		public void Run() {

			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Zadanie4");

			new Thread(Run2).Start();
			Run2();
		}
		static void Run2() {
			if (!done) { done = true; Console.WriteLine("Done"); }
		}


	}
}
