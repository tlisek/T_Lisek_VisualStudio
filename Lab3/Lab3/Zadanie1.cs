using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3 {
  public struct Point2D {
    public int x, y;

    public Point2D(int _x, int _y) {
      x = _x;
      y = _y;
    }

    public void Reset() {
      x = 0;
      y = 0;
    }

    public void IncrX(dx) {
      x+=dx;
    }
    public void IncrY(dy) {
      y+=dy;
    }

    public void Print2DPoint() {
      Console.WriteLine("x: {0}, y: {1}", x, y);
    }

    public double Dist(Point2D p) {
      return Math.Sqrt(Math.Pow(x - p.x, 2) + Math.Pow(y - p.y, 2));
    }
  }
  class Zadanie1 {
    public void Run() {
      int num_points = 4;
      int rad = 3;

      Point2D[] Points = new Point2D[num_points];
      Point2D P_final;

      for (int i = 0; i < num_points; i++) {
        Console.WriteLine("Podaj punkt {0} (oddzielajac wspolrzedne przecinkiem): ", i + 1);
        string[] PointCoords = Console.ReadLine().Split(",");
        Point2D P = new Point2D(int.Parse(PointCoords[0]), int.Parse(PointCoords[1]));
        Points[i] = P;
      }

      double min_dist;

      do {
        Console.WriteLine("Podaj punkt ostatni (oddzielajac wspolrzedne przecinkiem): ");
        string[] PointCoords = Console.ReadLine().Split(",");
        P_final = new Point2D(int.Parse(PointCoords[0]), int.Parse(PointCoords[1]));

        min_dist = double.PositiveInfinity;

        foreach (Point2D P in Points) {
          double d = P.Dist(P_final);
          if (d < min_dist) min_dist = d;
          if (d <= rad) break;
        }

        Console.WriteLine("Punkt nie lezy wewnątrz zadnego z punktow.\nNajmniejsza odleglosc: {0}: ", min_dist);

      }
      while (min_dist > rad);


      Console.WriteLine("Lista Punktow:\n");
      foreach (Point2D P in Points) {
        P.Print2DPoint();
      }

      Console.WriteLine("Punkt koncowy:\n");
      P_final.Print2DPoint();

    }
  }
}
