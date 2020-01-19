using System;
using System.Threading;

namespace Lab10 {
	public class Zadanie1 {
		public void Run() {
			Console.WriteLine("Zadanie1");

			Thread t = new Thread(Write1); //Uruchom inny wątek
			t.Start();
			// Główny wątek.
			for (int i = 0; i < 1000; i++) Console.Write("0");

		}
		//Inny wątek
		static void Write1() {
			for (int i = 0; i < 1000; i++) Console.Write("1");
		}




	}

}

