using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lab11 {
	public class Zadanie4 {
		public void Run() {

			Console.WriteLine();
			Console.WriteLine("Zadanie4");

			ThreadPool.QueueUserWorkItem(Run2);
			ThreadPool.QueueUserWorkItem(Run2, 123);
			Console.ReadLine();
		}
		static void Run2(object data) {
			Console.WriteLine("Hello !! The thread pool! " + data);
		}
	}
}
