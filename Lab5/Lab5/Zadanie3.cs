using System;
namespace Lab5 {
  public class Zadanie3 {

    public int? test;

    public void Run() {

      Console.WriteLine("Zmienna nullable");

      Console.WriteLine(test);

      Console.WriteLine( test.GetValueOrDefault(-1) );

      if( test.HasValue ) {
        Console.WriteLine(test);
      }
      else {
        Console.WriteLine("Nie ma wartosci");
      }

      Console.WriteLine("\nPrzypisanie wartosci");

      test = 1;

      Console.WriteLine(test);

      Console.WriteLine(test.GetValueOrDefault(-1));

      if (test.HasValue) {
        Console.WriteLine(test);
      }
      else {
        Console.WriteLine("Nie ma wartosci");
      }

    }
  }
}
