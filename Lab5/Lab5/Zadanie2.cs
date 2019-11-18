using System;
namespace Lab5 {
  public class Zadanie2 {
    public void Run() {

      Int32 i = 23;
      object o = i;
      i = 123;
      Console.WriteLine(i + ", " + (Int32)o);

      //Specified cast is not valid.
      //long j = (long)o;
      //Console.WriteLine(i + ", " + j);

    }
  }
}
