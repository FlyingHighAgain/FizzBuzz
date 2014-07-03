// FizzBuzz2.cs

﻿using System;
using System.Linq;

class FizzBuzz2
{
  static void Main(string[] args)
  {
    var fizzbuzz = Enumerable.Range(1, 100)
      .Select(num =>
      {
        if (num % 3 == 0 && num % 5 == 0)
        {
          return "FizzBuzz";
        }
        else if (num % 3 == 0)
        {
          return "Fizz";
        }
        else if (num % 5 == 0)
        {
          return "Buzz";
        }
        else
        {
          return num.ToString();
        }
      });

    fizzbuzz.ToList().ForEach(Console.WriteLine);
  }
}
