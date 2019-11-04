using System;
namespace Lab4 {
  public class Zadanie4 {
    public void Run() {


      int[] arr = new int[5];

      for(int i = 0; i< arr.Length; i++) {
        arr[i] = int.Parse(Console.ReadLine());
      }


      for (int i = arr.Length-1; i >=0; i--) {
        Console.Write( "{0};", arr[i] );
      }


    }
  }
}
