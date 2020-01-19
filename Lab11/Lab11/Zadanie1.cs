using System;
using System.Threading;

namespace Lab11 {
	public class Zadanie1 {

		public void Run() {

			Console.WriteLine("Zadanie1");

			try {
				new Thread(Run2).Start();
			}
			catch (Exception ex) {
				Console.WriteLine("Exception!");
			}
		}
		static void Run2() { throw null; } // Throws a NullReferenceException


	}
}
