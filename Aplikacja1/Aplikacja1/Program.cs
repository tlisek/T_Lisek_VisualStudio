using System;

namespace Aplikacja1 {
  class MainClass {

    public static void Zadanie2() {
      int a = 5;
      int b = 2;

      Console.WriteLine("Zadanie 2");

      Console.WriteLine("2.1) Wynik dodawania: {0}", a + b);
      Console.WriteLine("2.2) Wynik dzielenia: {0}", a / b);
      Console.WriteLine("2.3) Wyniki operacji:\n\t{0}\n\t{1}\n\t{2}\n\t{3}", -1 + 4 * 6, (35 + 5) % 7, 14 + -4 * 6 / 11, 2 + 15 / 6 * 1 - 7 % 2);
    }

    public static void Zadanie3() {

      Console.WriteLine("Zadanie 3");

      string x, y;
      Console.WriteLine("Podaj liczbe a: ");
      x = Console.ReadLine();
      Console.WriteLine("\nPodaj liczbe b: ");
      y = Console.ReadLine();
      Console.WriteLine("\nDrugi numer: {1}, Pierwszy numer: {0}", int.Parse(x), int.Parse(y));

    }

    public static void Zadanie4() {
      Console.WriteLine("Zadanie 4");
      string digitsString;
      Console.WriteLine("Podaj 3 cyfry: ");
      digitsString = Console.ReadLine();

      char[] digits = digitsString.ToCharArray();

      Console.WriteLine("\nIloczyn {0}x{1}x{2} = {3}", digits[2], digits[1], digits[0], int.Parse(digits[0].ToString()) * int.Parse(digits[1].ToString()) * int.Parse(digits[2].ToString()));
    }

    public static void Zadanie5() {

      Console.WriteLine("Zadanie 5");
      char digit;
      Console.WriteLine("Podaj cyfre: ");
      digit = Console.ReadKey().KeyChar;
      Console.WriteLine("\n\n{0}{0}{0}{0}\n{0}  {0}\n{0}  {0}\n{0}  {0}\n{0}  {0}\n{0}{0}{0}{0}", digit);

    }

    public static void Zadanie6() {

      Console.WriteLine("Zadanie 6");
      int ii = 75400;
      double id = 7.54;
      string s1 = String.Format("Wartosc int to {0},a wartosc double to {1}", ii, id);
      Console.WriteLine(s1);

      string s2 = "Wartosc int to " + ii.ToString() + ",a wartosc double to " + id.ToString();
      Console.WriteLine(s2);

      Console.WriteLine(String.Format("Wartosc int to \n{0,40}\n,a wartosc double to \n{1,-40}.\n", ii, id));

      int ii2 = 57300;
      double id2 = 5.73;
      Console.WriteLine("" +
        "{0:c} {1:c}\n" +
        "{0:d}\n" +
        "{0:e} {1:e}\n" +
        "{0:f} {1:f}\n" +
        "{1:r}\n" +
        "{0:x}.", ii2, id2);

      Console.WriteLine("\n");

      float flo = 220.022f;
      Console.WriteLine("{0:0.00000}\n{0:[#].(#)(##)}\n{0:0.0}\n{0:0,0}\n{0:,.}\n{0:0%}\n{0:0e+0}", flo);

      Console.WriteLine("\n");

      double d1 = 123.4;
      double d2 = -1234;
      double d3 = 0;

      Console.WriteLine("{0:#,##0.0;(#,##)Minus;Zero}", d1);
      Console.WriteLine("{0:#,##0.0;(#,##)Minus;Zero}", d2);
      Console.WriteLine("{0:#,##0.0;(#,##)Minus;Zero}", d3);

      Console.WriteLine("\n");

      DateTime d = System.DateTime.Now;

      Console.WriteLine("{0:d}\n{0:D}\n{0:t}\n{0:T}\n{0:f}\n{0:F}\n{0:g}\n{0:G}\n{0:M}\n{0:r}\n{0:s}\n{0:u}\n{0:U}\n{0:Y}", d);

      Console.WriteLine("\n");

    }

    public static void Zadanie7() {

      Console.WriteLine("Podaj temperature w stopniach Celsiusza:");
      float celsius = float.Parse(Console.ReadLine());

      Console.WriteLine("{0} stopni celsiusza to {1} stopni Kelvina i {2} stopni fahrenheita", celsius, celsius + 273, celsius * 18 / 10 + 32);

    }

    public static bool Zadanie8() {

      return int.Parse( Console.ReadLine() ) * int.Parse( Console.ReadLine() ) < 0;
    }

    public static void Main(string[] args) {

      Zadanie2();

      Zadanie3();

      Zadanie4();

      Zadanie5();

      Zadanie6();

      Zadanie7();

      Console.WriteLine("Podaj dwie liczby a program sprawdzi, czy sa roznych znakow:");
      Console.WriteLine( Zadanie8().ToString() );

    }

  }
}
