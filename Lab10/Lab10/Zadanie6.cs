using System;
using System.Threading;

namespace Lab10 {
	public class Zadanie6 {


		public void Run() {

			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Zadanie6");

			Thread t = new Thread(Run2);
			t.Start();
			t.Join();
			Console.WriteLine("Thread t has ended!");

		}
		static void Run2() {
			for (int i = 0; i < 777; i++) Console.Write("#");
		}

	}
}
