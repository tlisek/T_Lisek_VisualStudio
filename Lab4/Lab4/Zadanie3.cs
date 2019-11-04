using System;
namespace Lab4 {
  public class Zadanie3 {

    public void Run() {

      int[] arr = new int[10];

      string input = "";
      int input_int;

      do {
        input = Console.ReadLine();
        if (input == "q") break;

        input_int = int.Parse(input);

        for (int i = arr.Length - 1; i >= 1; i--) {
          arr[i] = arr[i - 1];
        }
        arr[0] = input_int;

        Console.WriteLine(String.Join(";", arr));

      }
      while (input != "q");

    }
  }
}
