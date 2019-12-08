using System;
namespace Lab7 {

  delegate void PreformOperation(int x, int y);

  public class Zadanie3 {

    public void AddNumbers(int x, int y) {
      Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
    }

    public void SubtractNumbers(int x, int y) {
      Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
    }

    public void MultiplyNumbers(int x, int y) {
      Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
    }

    public void DivideNumbers(int x, int y) {
      if (y == 0) {
        throw new DivideByZeroException();
      }
      else {
        Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
      }
    }

    public void Run() {

      PreformOperation add = new PreformOperation(AddNumbers);
      PreformOperation sub = new PreformOperation(SubtractNumbers);
      PreformOperation mul = new PreformOperation(MultiplyNumbers);
      PreformOperation div = new PreformOperation(DivideNumbers);

      add(1, 5);
      sub(3, 7);
      mul(2, 3);
      div(10, 2);


    }
  }
}
