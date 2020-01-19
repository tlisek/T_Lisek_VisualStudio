using System;
using System.Threading;

namespace Lab11 {
	class MainClass {
		public static void Main(string[] args) {

			Zadanie1 Z1 = new Zadanie1();
			//Z1.Run();

			Thread.Sleep(500);

			Zadanie2 Z2 = new Zadanie2();
			Z2.Run();

			Thread.Sleep(500);

			Zadanie3 Z3 = new Zadanie3();
			Z3.Run();

			Thread.Sleep(500);

			Zadanie4 Z4 = new Zadanie4();
			Z4.Run();

			Thread.Sleep(500);

			Zadanie5 Z5 = new Zadanie5();
			Z5.Run();


		}
	}
}
