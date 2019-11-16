using System;
namespace Lab4 {
  public class Zadanie7 {

    public int det_3_3(int[,] matrix) {
      return matrix[0, 0] * matrix[1, 1] * matrix[2, 2] + matrix[1, 0] * matrix[2, 1] * matrix[0, 2] + matrix[2, 0] * matrix[0, 1] * matrix[1, 2]
        - (matrix[2, 0] * matrix[1, 1] * matrix[0, 2] + matrix[0, 0] * matrix[2, 1] * matrix[1, 2] + matrix[1, 0] * matrix[0, 1] * matrix[2, 2]);
    }
    public void Run() {
      int[,] arr = { { 1, 0, -1 }, { 0, 0, 1 }, { -1, -1, 0 } };

      Console.WriteLine( det_3_3(arr) ); // 0

    }
  }
}
