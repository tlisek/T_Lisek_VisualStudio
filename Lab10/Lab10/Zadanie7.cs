using System;
using System.Threading;

namespace Lab10 {
	public class Zadanie7 {
		public void Run() {

			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Zadanie7");

			int[,] array1 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
			int[,] array2 = new int[,] { { -1, -2, -3 }, { 4, 5, 6 }, { 7, 8, 9 } };
			int[,] array3 = new int[,] { { 1, 2, 3 }, { -4, -5, -6 }, { 7, 8, 9 } };
			int[,] array4 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { -7, -8, -9 } };
			int[,] array5 = new int[,] { { -1, 2, 3 }, { -4, 5, 6 }, { -7, 8, 9 } };


			Thread t1 = new Thread(() => sumMatrix(array1));
			Thread t2 = new Thread(() => sumMatrix(array2));
			Thread t3 = new Thread(() => sumMatrix(array3));
			Thread t4 = new Thread(() => sumMatrix(array4));
			Thread t5 = new Thread(() => sumMatrix(array5));

			t1.Start();
			t2.Start();
			t3.Start();
			t4.Start();
			t5.Start();


		}

		static void sumMatrix(int[,] matrix) {
			int sum = 0;

			foreach (int el in matrix) {
				sum += el;
			}

			Console.WriteLine(sum);
		}
	}
}
