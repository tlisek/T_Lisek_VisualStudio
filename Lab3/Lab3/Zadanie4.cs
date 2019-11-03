using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3 {
  enum Day { Poniedzialek, Wtorek, Sroda, Czwartek, Piatek, Sobota, Niedziela };

  enum Liczba { mala = 10, srednia = 100, duza = int.MaxValue }

  class Zadanie4 {
    public void Run() {

      Console.WriteLine("Podaj numer dnia tygodnia (1-7):");
      int num_day = int.Parse(Console.ReadLine());
      Console.WriteLine("Dzien numer {0} to {1}", num_day, Enum.GetName(typeof(Day), num_day - 1));

      Console.WriteLine("Podaj liczbe:");

      int value = int.Parse(Console.ReadLine());

      foreach(Liczba liczba in Enum.GetValues(typeof(Liczba))) {
        if( value <= (int)liczba) {
          Console.WriteLine( Enum.GetName(typeof(Liczba), liczba) );
          break;
        }
      }


    }
  }
}
