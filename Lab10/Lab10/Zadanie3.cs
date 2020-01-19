using System;
using System.Threading;

namespace Lab10 {
	public class Zadanie3 {

		bool done;
		public void Run() {

			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Zadanie3");

			Zadanie3 tt = new Zadanie3();
			new Thread(tt.Run2).Start();
			tt.Run2();
		}
		// Zauważ, że Run2 jest teraz metodą instancji
		void Run2() {
			if (!done) { done = true; Console.WriteLine("Done"); }
		}


	}
}
