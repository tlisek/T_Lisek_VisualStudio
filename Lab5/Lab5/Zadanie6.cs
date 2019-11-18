using System;
using System.Collections.Generic;

namespace Lab5 {

  public class Stack {
    List<int> items = new List<int>();

    public void AddItem(int item) {
      items.Add(item);
    }

    public void DeleteItem(int item) {
      items.RemoveAt(0);
    }

    public void ShowTheNumberOfItems() {
      Console.WriteLine("Liczba elementow: {0}", items.Count);
    }

    public int GetTheNumberOfItems() {
      return items.Count;
    }

    public void ShowMinItem() {
      List<int> tmpItems = items;
      tmpItems.Sort();
      Console.WriteLine("Min: {0}", tmpItems[0]);
    }

    public void ShowMaxItem() {
      List<int> tmpItems = items;
      tmpItems.Sort();
      Console.WriteLine("Min: {0}", tmpItems[items.Count - 1]);
    }

    public void PrintAllItems() {
      foreach (int i in items) {
        Console.WriteLine(i);
      }
    }

    public int FindAnItem(int item) {

      if (items.Contains(item)) {
        return items.FindIndex(x => x == item);
      }

      return -1;
    }

    public int GetAnItem(int index) {
      return items[index];
    }

    public void ClearAll() {
      items.Clear();
    }

  }

  public class Zadanie6 {
    public void Run() {

      int num_items = 100;

      var rand = new Random();

      Stack s1 = new Stack();
      Stack s2 = new Stack();

      Stack s3 = new Stack();

      for (int i = 0; i < num_items; i++) {
        s1.AddItem(rand.Next(2 * num_items));
        s2.AddItem(rand.Next(2 * num_items));
      }

      Console.WriteLine("Stack 1:");
      s1.PrintAllItems();

      Console.WriteLine();

      Console.WriteLine("Stack 2:");
      s2.PrintAllItems();

      for (int i = 0; i < s1.GetTheNumberOfItems(); i++) {
        int item = s1.GetAnItem(i);
        if (item % 2 == 0) {
          s3.AddItem(item);
        }
      }

      for (int i = 0; i < s2.GetTheNumberOfItems(); i++) {
        int item = s2.GetAnItem(i);
        if (item % 2 == 0 && s3.FindAnItem(item) == -1) {
          s3.AddItem(item);
        }
      }

      Console.WriteLine();

      Console.WriteLine("Stack 3:");
      s3.PrintAllItems();

    }
  }
}
