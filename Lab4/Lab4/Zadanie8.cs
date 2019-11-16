using System;
namespace Lab4 {
  public class Zadanie8 {

    public void printArray(int[][] arr) {

      foreach (int[] row in arr) {
        Console.WriteLine(String.Join(";", row));
      }

    }

    public void Run() {

      int[][] arr1 = new int[5][];
      arr1[0] = new int[] { 1, 2, 3 };
      arr1[1] = new int[] { 4, 5, 6, 7, 8, 9 };
      arr1[2] = new int[] { 10, 11, 12, 13 };
      arr1[3] = new int[] { 14, 15, 16, 17, 18 };
      arr1[4] = new int[] { 19, 20, 21 };


      int[][] arr2 = {
        new int[] { 1, 2, 3 },
        new int[] { 4, 5, 6, 7, 8, 9 },
        new int[] { 10, 11, 12, 13 },
        new int[] { 14, 15, 16, 17, 18 },
        new int[] { 19, 20, 21 }
      };

      Console.WriteLine("Array 1:");
      printArray(arr1);
      Console.WriteLine("\nArray 2:");
      printArray(arr2);
    }
  }
}
