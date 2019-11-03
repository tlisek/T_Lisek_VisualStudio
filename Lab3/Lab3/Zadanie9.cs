using System;
namespace Lab3 {
  public class Zadanie9 {
    public void Run() {

      char[] delimiterChars = {'+','-'};

      Console.WriteLine("Podaj dzialanie (wspierane operacje: +,-)");
      string input = Console.ReadLine();

      string mathExpr = input.Replace(" ", "");

      string[] nums = mathExpr.Split(delimiterChars);


      int i = 0;
      int res = int.Parse(nums[0]);

      foreach (char c in mathExpr) {
        if (c == '+') {
          i++;
          res = res + int.Parse(nums[i]);
        }
        else if (c == '-') {
          i++;
          res = res - int.Parse(nums[i]);
        }
      }

      Console.WriteLine("{0} = {1}", input, res);

    }
  }
}
