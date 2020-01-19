using System;
using System.Threading;

namespace Lab11 {
	public class Zadanie2 {

		public void Run() {

			Console.WriteLine();
			Console.WriteLine("Zadanie2");

			new Thread(Run2).Start();
		}
		static void Run2() {
			try {
				// ...
				throw null;
				// ...
			}
			catch (Exception ex) {
				Console.WriteLine("Exception!");
			}
		}

	}
}
