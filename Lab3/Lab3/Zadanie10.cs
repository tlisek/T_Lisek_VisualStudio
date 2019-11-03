using System;
namespace Lab3 {
  public class Zadanie10 {
    public void Run() {

      // Konwersja niejawna

      //1
      double a = 15.7;
      int x = 10;
      a = a + x; // konwersja x na double

      //2
      int num = 2147483647;
      long bigNum = num;

      //3
      short smallNum2 = 2;
      int num2 = (int)smallNum2;

      //4
      int wartosc1 = 0;
      byte wartosc2 = 15;
      wartosc1 = wartosc2;


      // Konwersja jawna

      //1
      double d = 1234.7;
      int i2 = (int)d;

      //2
      int i3 = 120;
      double d3 = (double)i3;

      //3
      short s4 = (short)i2;

      //4
      long l2 = (long)i3;
    }
  }
}