using System;
namespace Lab3 {

  public class Point {
    public int x, y;
    public Point(int p1, int p2) {
      x = p1;
      y = p2;
    }
  }

  public struct Coords {
    public int x, y;
    public Coords(int p1, int p2) {
      x = p1;
      y = p2;
    }
  }


  public class Zadanie8 {

    static void Fun1(Point _p) {
      _p.x++;
      _p.y--;
    }
    static void Fun2(Coords _c) {
      _c.x++;
      _c.y--;
    }


    public void Run() {

      Point p = new Point(1, 1);
      Coords c = new Coords(1, 1);

      Console.WriteLine("Points: {0};{1}", p.x, p.y);
      Console.WriteLine("Coords: {0};{1}", c.x, c.y);

      Console.WriteLine("Running function");

      Fun1(p);
      Fun2(c);

      Console.WriteLine("Points: {0};{1}", p.x, p.y);
      Console.WriteLine("Coords: {0};{1}", c.x, c.y);

      Console.WriteLine("\n");

      Point p1 = new Point(1, 1);
      Point p2 = new Point(1, 1);

      Coords c1 = new Coords(1, 1);
      Coords c2 = new Coords(1, 1);

      Console.WriteLine("Object.Equals()");
      Console.WriteLine("Points: " + Object.Equals(p1, p2));
      Console.WriteLine("Coords: " + Object.Equals(c1, c2));
      Console.WriteLine("\n");

      Console.WriteLine("x1.Equals(x2)");
      Console.WriteLine("Points: " + p1.Equals(p2));
      Console.WriteLine("Coords: " + c1.Equals(c2));
      Console.WriteLine("\n");

      Console.WriteLine("Object.ReferenceEquals()");
      Console.WriteLine("Points: " + Object.ReferenceEquals(p1, p2));
      Console.WriteLine("Coords: " + Object.ReferenceEquals(c1, c2));

    }

  }
}
