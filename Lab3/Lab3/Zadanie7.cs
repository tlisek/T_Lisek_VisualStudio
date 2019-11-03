using System;
namespace Lab3 {
  public class Zadanie7 {

    public void Run() {
      int i1 = 100;

      // Blad kompilacji
      //Console.WriteLine( checked(2147483647 + 10) );

      // Blad w konsoli
      try {
        checked {
          int i3 = 2147483647 + i1;
          Console.WriteLine(i3);
        }
      }
      catch(System.OverflowException e) {
        Console.WriteLine("Wykryto blad:\n{0}", e.ToString());
      }
    }
  }
}
