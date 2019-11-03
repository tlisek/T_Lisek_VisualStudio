using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab3 {
  class Zadanie5 {

    public void Run() {
      char[] samogloski = { 'a', 'ą', 'e', 'ę', 'i', 'o', 'u', 'y' };
      char[] cyfry = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
      Console.WriteLine("Sprawdz znak:");


      char input = Console.ReadKey().KeyChar;

      Console.WriteLine("");

      if (samogloski.Contains(input)) {
        Console.WriteLine("Samogloska");
      }
      else if (cyfry.Contains(input)) {
        Console.WriteLine("Cyfra");

      }
      else {
        Console.WriteLine("Inny znak");

      }

    }



  }
}
