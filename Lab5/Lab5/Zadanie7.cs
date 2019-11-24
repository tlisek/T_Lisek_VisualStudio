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

      matrix = new int[num_items];

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
      if (c_idx < c && l_idx < l) {
        int pos = c * l_idx + c_idx; // num_rows * row + num_col
        matrix[pos] += item;
      }
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

    public Matrix AddMatrix(Matrix matrix2) {


      int new_c = Math.Max(this.GetC(), matrix2.GetC());
      int new_l = Math.Max(this.GetL(), matrix2.GetL());

      int[] sumItems = { };

      Matrix sum = new Matrix(new_c, new_l, sumItems);

      for (int l_idx = 0; l_idx < this.GetL(); l_idx++) {
        for (int c_idx = 0; c_idx < this.GetC(); c_idx++) {
          int pos = this.GetC() * l_idx + c_idx; // num_rows * row + num_col
          int item = this.GetItems()[pos];
          sum.AddElem(c_idx, l_idx, item);
        }
      }

      for (int l_idx = 0; l_idx < matrix2.GetL(); l_idx++) {
        for (int c_idx = 0; c_idx < matrix2.GetC(); c_idx++) {
          int pos = matrix2.GetC() * l_idx + c_idx; // num_rows * row + num_col
          sum.AddElem(c_idx, l_idx, matrix2.GetItems()[pos]);
        }
      }

      return sum;
    }

    public void PrintMatrix() {
      for (int l_idx = 0; l_idx < this.GetL(); l_idx++) {
        for (int c_idx = 0; c_idx < this.GetC(); c_idx++) {
          int pos = this.GetC() * l_idx + c_idx; // num_rows * row + num_col
          Console.Write("{0} ", this.GetItems()[pos]);

        }
        Console.Write("\n");
      }
    }

  }

  public class Zadanie7 {
    public void Run() {

      int[] matrix1_elements = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
      int[] matrix2_elements = { 1,1,1,1,1,1 };

      Matrix m1 = new Matrix(4, 3, matrix1_elements);
      Matrix m2 = new Matrix(3, 2, matrix2_elements);

      Console.WriteLine("M1:");
      m1.PrintMatrix();

      Console.WriteLine("M2:");
      m2.PrintMatrix();

      Matrix sum = m1.AddMatrix(m2);

      Console.WriteLine("Sum:");
      sum.PrintMatrix();

    }
  }
}
