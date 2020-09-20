using System;
using System.Collections.Generic;

namespace Homework2 {

  public class FactorApp {

    public static void Main(string[] args) {
      try {
        Console.Write("请输入一个整数:");
        int num = Convert.ToInt32(Console.ReadLine());
        List<int> factors = Factorize(num);
        Console.Write("素因子有:");
        factors.ForEach(f=> Console.Write("\t" + f));
      }catch (Exception e) {
        Console.WriteLine($"错误:{e.Message}");
      }
    }


    //因数分解法
    private static List<int> Factorize(int num) {
      List<int> factors = new List<int>();
      for (int factor = 2; factor * factor <= num; factor++) {
        while (num % factor == 0) {
          factors.Add(factor);
          num = num / factor;
        }
      }

      if (num != 1) {
        factors.Add(num);//剩余的素因子
      }

      return factors;
    }
  }
}
