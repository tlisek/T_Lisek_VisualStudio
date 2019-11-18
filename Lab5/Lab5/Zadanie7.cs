using System;
namespace Lab5 {

  public class Matrix {
    int[] matrix;
    int c; // num cols
    int l; // num rows

    public Matrix(int _c, int _l, int[] _items) {
      c = _c;
      l = _l;

      int num_items = c * l;

      for (int i = 0; i < num_items; i++) {
        if (i < _items.Length) {
          matrix[i] = _items[i];
        }
        else {
          matrix[i] = 0;
        }
      }

    }

    public void AddElem(int c_idx, int l_idx, int item) {
      //indexing from 0
      int pos = l * l_idx + c_idx; // num_rows * row + num_col
      matrix[pos] = item;
    }

    public int GetC() {
      return c;
    }
    public int GetL() {
      return l;
    }

    public int[] GetItems() {
      int[] tmp = (int[])matrix.Clone(); // Copy
      return tmp;
    }

    public int[] AddMatrix(Matrix matrix2) {


      int new_c = Math.Max(this.GetC(), matrix2.GetC());
      int new_l = Math.Max(this.GetL(), matrix2.GetL());

      int[] sum = new int[new_c * new_l];

      for (int l_idx = 0; l_idx < new_l; l_idx++) {
        for (int c_idx = 0; c_idx < new_c; c_idx++) {

          int pos = new_l * l_idx + c_idx; // num_rows * row + num_col

          sum[pos] = 0;
          if (l_idx < this.GetL() && c_idx < this.GetC()) sum[pos] += this.GetItems()[pos];
          if (l_idx < matrix2.GetL() && c_idx < matrix2.GetC()) sum[pos] += matrix2.GetItems()[pos];

        }
      }

      return sum;
    }

    public void PrintMatrix() {
      for (int c_idx = 0; c_idx < this.GetC(); c_idx++) {

        for (int l_idx = 0; l_idx < this.GetL(); l_idx++) {
          int pos = this.GetL() * l_idx + c_idx; // num_rows * row + num_col
          Console.Write("{0} ", this.GetItems()[pos]);

        }
        Console.Write("\n");
      }
    }

  }

  public class Zadanie7 {
    public void Run() {

      int[] matrix1_elements = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
      int[] matrix2_elements = { 1,1,1,1 };

      Matrix m1 = new Matrix(3, 3, matrix1_elements);
      Matrix m2 = new Matrix(2, 2, matrix2_elements);

      m1.PrintMatrix();
      m2.PrintMatrix();

    }
  }
}
