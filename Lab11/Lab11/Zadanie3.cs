using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lab11 {
	public class Zadanie3 {
		public void Run() {

			Console.WriteLine();
			Console.WriteLine("Zadanie3");

			Task.Factory.StartNew(Run2);
		}
		static void Run2() {
			Console.WriteLine("Hello !! The thread pool!");
		}
	}
}
