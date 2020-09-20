using System;
using System.Collections.Generic;


namespace Homework2 {

  class PrimeApp {

    static void Main(string[] args) {
      const int N = 100;

      bool[] primes = new bool[N+1]; //i是素数时，primes[i]为true
      for (int i = 2; i < N+1; i++) {
        primes[i] = true;
      }

      FilterPrimes(primes);

      for (int num = 2; num < N+1; num++) {
        if (primes[num]) {
          Console.Write($"\t{num}");
        }
      }
    }

    // 数组过滤素数
    private static bool[] FilterPrimes(bool[] primes) {
      for (int num = 2; num * num < primes.Length; num++) {
        if (!primes[num]) continue;
        for (int multiples = 2 * num; multiples < primes.Length; multiples += num) {
          primes[multiples] = false;
        }
      }
      return primes;
    }
  }
}
