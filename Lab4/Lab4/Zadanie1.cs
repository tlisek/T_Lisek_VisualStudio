using System;
namespace Lab4 {

  public class Point {
    public int x, y;
    public Point(int p1, int p2) {
      x = p1;
      y = p2;
    }
  }

  public class Zadanie1 {

    void Fun1(in int i) {
      // i is readonly
      //i++;
    }

    void Fun2(out int i) {
      i = 1;
      i++;

    }

    void Fun3(ref int i) {
      i++;

    }

    void Fun4(int i) {
      i++;

    }

    // d.
    void testFun(in int i) {
    }

    //Nie może definiować przeciążonego elementu metoda, który różni się tylko modyfikatorami parametru „out” i „in”
    //void testFun(out int i) {
    //  i = 1;
    //}


    void Fun5(Point p) {
      Point p2 = new Point(5, 6);
      p = p2;
    }

    void Fun6(ref Point p) {
      Point p2 = new Point(5, 6);
      p = p2;
    }

    public void Run() {

      int x;

      x = 1;
      Fun1(x);
      Console.WriteLine(x);
      // x = 1

      x = 1;
      Fun2(out x);
      Console.WriteLine(x);
      // x = 2

      x = 1;
      Fun3(ref x);
      Console.WriteLine(x);
      // x = 2

      x = 1;
      Fun4(x);
      Console.WriteLine(x);
      // x = 1



      short y;

      y = 1;
      Fun1(y);
      Console.WriteLine(y);
      // y = 1

      y = 1;
      //Fun2(out y);
      // Nie mozna przekonwertowac out short na out int
      Console.WriteLine(y);

      y = 1;
      //Fun3(ref y);
      // Nie mozna przekonwertowac ref short na ref int
      Console.WriteLine(y);

      y = 1;
      Fun4(y);
      Console.WriteLine(y);
      // y = 1


      Point p1 = new Point(1, 1);
      Console.WriteLine("x={0}; y={1}", p1.x, p1.y);
      //x=1; y=1
      Fun5(p1);
      Console.WriteLine("x={0}; y={1}", p1.x, p1.y);
      //x=1; y=1


      Point p2 = new Point(1, 1);
      Console.WriteLine("x={0}; y={1}", p2.x, p2.y);
      //x=1; y=1
      Fun6(ref p2);
      Console.WriteLine("x={0}; y={1}", p2.x, p2.y);
      //x=5; y=6

      p1 = null;

      //System.NullReferenceException
      //Console.WriteLine("x={0}; y={1}", p1.x, p1.y);

      //Fun5(p1);

      //System.NullReferenceException
      //Console.WriteLine("x={0}; y={1}", p1.x, p1.y);

      p2 = null;
      //System.NullReferenceException
      //Console.WriteLine("x={0}; y={1}", p2.x, p2.y);

      Fun6(ref p2);

      Console.WriteLine("x={0}; y={1}", p2.x, p2.y);
      //x=5; y=6


    }
  }
}
