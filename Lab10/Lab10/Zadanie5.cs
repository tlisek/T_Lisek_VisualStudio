using System;
using System.Threading;

namespace Lab10 {
	public class Zadanie5 {

		static readonly object locker = new object();

		static bool done; // Pole statyczne
		public void Run() {

			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Zadanie5");

			new Thread(Run2).Start();
			Run2();
		}
		static void Run2() {

			lock (locker) {
				//exclusive lock
				if (!done) { done = true; Console.WriteLine("Done"); }
			}

		}



	}
}
