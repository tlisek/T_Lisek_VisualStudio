using System;
namespace Lab5 {

  public class Matrix2D {
    protected int[][] matrix;
    protected int c; // num cols
    protected int l; // num rows

    public Matrix2D(int _c, int _l, int[] _items) {
      c = _c;
      l = _l;

      matrix = new int[l][];

      for (int l_ind = 0; l_ind < _l; l_ind++) {
        matrix[l_ind] = new int[_c];
        for (int c_ind = 0; c_ind < _c; c_ind++) {

          int pos = c * l_ind + c_ind;


          if (pos < _items.Length) {
            matrix[l_ind][c_ind] = _items[pos];
          }
          else {
            matrix[l_ind][c_ind] = 0;
          }
        }
      }

    }

    public void AddElem(int c_idx, int l_idx, int item) {
      if (c_idx < c && l_idx < l) {
        matrix[l_idx][c_idx] += item;
      }
    }

    public int GetC() {
      return c;
    }
    public int GetL() {
      return l;
    }

    public int[][] GetItems() {
      int[][] tmp = (int[][])matrix.Clone(); // Copy
      return tmp;
    }

    public Matrix2D AddMatrix(Matrix2D matrix2) {


      int new_c = Math.Max(this.GetC(), matrix2.GetC());
      int new_l = Math.Max(this.GetL(), matrix2.GetL());

      int[] sumItems = { };

      Matrix2D sum = new Matrix2D(new_c, new_l, sumItems);

      for (int l_idx = 0; l_idx < this.GetL(); l_idx++) {
        for (int c_idx = 0; c_idx < this.GetC(); c_idx++) {
          sum.AddElem(c_idx, l_idx, this.GetItems()[l_idx][c_idx]);
        }
      }

      for (int l_idx = 0; l_idx < matrix2.GetL(); l_idx++) {
        for (int c_idx = 0; c_idx < matrix2.GetC(); c_idx++) {
          sum.AddElem(c_idx, l_idx, matrix2.GetItems()[l_idx][c_idx]);
        }
      }

      return sum;
    }

    public Matrix2D SubtractMatrix(Matrix2D matrix2) {


      int new_c = Math.Max(this.GetC(), matrix2.GetC());
      int new_l = Math.Max(this.GetL(), matrix2.GetL());

      int[] sumItems = { };

      Matrix2D sum = new Matrix2D(new_c, new_l, sumItems);

      for (int l_idx = 0; l_idx < this.GetL(); l_idx++) {
        for (int c_idx = 0; c_idx < this.GetC(); c_idx++) {
          sum.AddElem(c_idx, l_idx, this.GetItems()[l_idx][c_idx]);
        }
      }

      for (int l_idx = 0; l_idx < matrix2.GetL(); l_idx++) {
        for (int c_idx = 0; c_idx < matrix2.GetC(); c_idx++) {
          sum.AddElem(c_idx, l_idx, -matrix2.GetItems()[l_idx][c_idx]);
        }
      }

      return sum;
    }

    public void PrintMatrix() {
      for (int l_idx = 0; l_idx < this.GetL(); l_idx++) {
        for (int c_idx = 0; c_idx < this.GetC(); c_idx++) {
          Console.Write("{0} ", this.GetItems()[l_idx][c_idx]);

        }
        Console.Write("\n");
      }
    }

  }
  public class Zadanie8 {
    public void Run() {



      int[] matrix1_elements = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
      int[] matrix2_elements = { 1, 1, 1, 1, 1, 1 };

      Matrix2D m1 = new Matrix2D(4, 3, matrix1_elements);
      Matrix2D m2 = new Matrix2D(3, 2, matrix2_elements);

      Console.WriteLine("M1:");
      m1.PrintMatrix();

      Console.WriteLine("M2:");
      m2.PrintMatrix();

      Matrix2D sum = m1.AddMatrix(m2);

      Console.WriteLine("Sum:");
      sum.PrintMatrix();

      Matrix2D difference = m1.SubtractMatrix(m2);

      Console.WriteLine("Diff:");
      difference.PrintMatrix();

    }
  }
}
