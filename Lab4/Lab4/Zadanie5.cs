using System;
using System.Collections.Generic;

namespace Lab4 {


  public class Zadanie5 {
    public void Run() {

      int[] arr = new int[5];
      var count = new Dictionary<int, int>();

      for (int i = 0; i < arr.Length; i++) {
        arr[i] = int.Parse(Console.ReadLine());
      }

      foreach (int val in arr) {
        if (!count.ContainsKey(val)) {
          count[val] = 0;
        }
        count[val]++;
      }


      foreach (KeyValuePair<int, int> entry in count) {
        Console.WriteLine("Count for {0} is {1}", entry.Key, entry.Value);
      }


    }
  }
}
