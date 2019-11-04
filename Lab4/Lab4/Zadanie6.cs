using System;
namespace Lab4 {
  public class Zadanie6 {
    public void Run() {

      int[,] arr1 = new int[5, 5] { { 2, 2, 3, 4, 5 }, { 2, 3, 4, 5, 6 }, { 1, 2, 3, 4, 5 }, { 2, 3, 4, 5, 6 }, { 1, 2, 3, 4, 5 } };
      int[,] arr2 = new int[5, 5] { { 1, 8,9, 1, 5 }, { 2, 3, 4, 5, 6 }, { 1, 2, 3, 4, 5 }, { 2, 3, 4, 5, 6 }, { 1, 2, 3, 4, 5 } };

      int[,] arr3 = new int[5, 5];

      for(int i = 0; i< arr3.GetLength(0); i++) {
        for(int j=0; j< arr3.GetLength(1); j++) {
          arr3[i, j] = arr1[i, j] + arr2[i, j];
        }
      }


      for (int i = 0; i < arr3.GetLength(0); i++) {
        for (int j = 0; j < arr3.GetLength(1); j++) {
          Console.Write("{0};", arr3[i, j]);
        }
        Console.Write("\n");
      }


      Console.WriteLine("Length is {0}", arr3.Length);
      Console.WriteLine("LongLength is {0}", arr3.LongLength);
      Console.WriteLine("Rank is {0}", arr3.Rank);

    }
  }
}
