using System;
namespace Lab5 {
  public class Zadanie1 {
    public void Run_1() {

      Console.WriteLine("Podaj liczbe:");
      int num = int.Parse(Console.ReadLine());

      for (int i = 1; i <= num; i++) {
        for (int j = 1; j <= i; j++) {
          Console.Write("{0} ", j);
        }
        Console.Write("\n");
      }


      int i_while = 1;
      while (i_while <= num) {
        int j = 1;
        while (j <= i_while) {
          Console.Write("{0} ", j);
          j++;
        }
        Console.Write("\n");
        i_while++;
      }

      int i_do = 1;
      do {
        int j = 1;

        do {
          Console.Write("{0} ", j);
          j++;
        }
        while (j <= i_do);

        Console.Write("\n");
        i_do++;
      }
      while (i_do <= num);

    }
    public void Run_2() {

      Console.WriteLine("Podaj liczbe:");
      int num = int.Parse(Console.ReadLine());

      for (int i = 1; i <= num; i++) {
        for (int j = 1; j <= i; j++) {
          Console.Write("{0} ", i);
        }
        Console.Write("\n");
      }


      int i_while = 1;
      while (i_while <= num) {
        int j = 1;
        while (j <= i_while) {
          Console.Write("{0} ", i_while);
          j++;
        }
        Console.Write("\n");
        i_while++;
      }

      int i_do = 1;
      do {
        int j = 1;

        do {
          Console.Write("{0} ", i_do);
          j++;
        }
        while (j <= i_do);

        Console.Write("\n");
        i_do++;
      }
      while (i_do <= num);

    }
  }
}
