using System;
namespace Lab7 {
  public class Zadanie2 {
    public void Run() {

      Point p1 = new Point(1, 1);
      Point p2 = new Point(5, -2);

      Point p3 = 5;

      Console.WriteLine(p1);
      Console.WriteLine(p2);
      Console.WriteLine(p3);

      p1++;
      p2--;
      Console.WriteLine(p1);
      Console.WriteLine(p2);

      Console.WriteLine( (int)p2 );


      Console.WriteLine(p1+p2);

    }
  }

  public class Point {

    private int _x;
    public int X {
      get { return _x; }
      set { _x = value; }
    }

    private int _y;
    public int Y {
      get { return _y; }
      set { _y = value; }
    }

    public Point(int x, int y) {
      _x = x;
      _y = y;
    }

    public override string ToString() {
      return "{" + String.Format("{0}; {1}", _x, _y) + "}";
    }

    public static Point operator +(Point p1, Point p2) {
      return new Point(p1.X + p2.X, p1.Y + p2.Y);
    }


    public static bool operator true(Point p) {
      return !(p.X == 0 && p.Y == 0);
    }

    public static bool operator false(Point p) {
      return (p.X == 0 && p.Y == 0);
    }


    public static bool operator ==(Point p1, Point p2) {
      return (p1.X == p2.X && p1.Y == p2.Y);
    }

    public static bool operator !=(Point p1, Point p2) {
      return !(p1.X == p2.X && p1.Y == p2.Y);
    }


    public static bool operator <(Point p1, Point p2) {
      return (p1.X < p2.X && p1.Y < p2.Y);
    }

    public static bool operator >(Point p1, Point p2) {
      return (p1.X > p2.X && p1.Y > p2.Y);
    }


    public static Point operator ++(Point p) {
      return new Point(p.X + 1, p.Y + 1);
    }

    public static Point operator --(Point p) {
      return new Point(p.X - 1, p.Y - 1);
    }

    public static implicit operator Point(int v) {
      return new Point(v, v);
    }


    public static explicit operator int(Point p) {
      return p.X + p.Y;
    }

    // += Assignment operators cannot be overloaded, but +=, for example, is evaluated using +, which can be overloaded.
  }

}
