using System;
namespace Lab3 {


  public struct Point2D_version1 {
    private int x, y;

    public void Reset() {
      x = 0;
      y = 0;
    }

    public void IncrX() {
      x++;
    }
    public void IncrY() {
      y++;
    }

    public void Print2DPoint() {
      Console.WriteLine("x: {0}, y: {1}", x, y);
    }

    public double Dist(Point2D p) {
      return Math.Sqrt(Math.Pow(x - p.x, 2) + Math.Pow(y - p.y, 2));
    }
  }


  public struct Point2D_version2 {
    private int x, y;

    //public Point2D_version2() {
    //  x = 1;
    //  y = 1;
    //}

    public void Reset() {
      x = 0;
      y = 0;
    }

    public void IncrX() {
      x++;
    }
    public void IncrY() {
      y++;
    }

    public void Print2DPoint() {
      Console.WriteLine("x: {0}, y: {1}", x, y);
    }

    public double Dist(Point2D p) {
      return Math.Sqrt(Math.Pow(x - p.x, 2) + Math.Pow(y - p.y, 2));
    }
  }

  public class Zadanie2 {
    public void Run() {

      //Struct can be instasntiated without the new operator. However, you won't be able to use any of its methods, events or properties if you do so.

      Point2D_version1 p1;

      // Błąd: Użyto nieprzypisanej zmiennej lokalnej „p1”
      //Console.WriteLine(p1.ToString());




      // Structure cannot include parameterless constructor or destructor.

      Point2D_version1 p1_2 = new Point2D_version1();

      // Błąd: Struktury nie mogą zawierać jawnych konstruktorów bez parametrów
      Point2D_version2 p2 = new Point2D_version2();
      Console.WriteLine(p2.ToString());

    }
  }
}
