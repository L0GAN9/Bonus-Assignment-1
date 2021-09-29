using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter 3 sides of triangle");
    var a = Convert.ToInt32(Console.ReadLine());
    var b = Convert.ToInt32(Console.ReadLine());
    var c = Convert.ToInt32(Console.ReadLine());

    
    if (a+b < c)
    {
     Console.WriteLine("Triangle Cannot Be Formed");
     
    }

    else if (a == 0)
    {
      Console.WriteLine("Triangle Cannot Be Formed");
    }

    else if (b == 0)
    {
      Console.WriteLine("Triangle Cannot Be Formed");
    }
    
    else if (c == 0)
    {
      Console.WriteLine("Triangle Cannot Be Formed");
    }

    else if (a+c < b)
    {
     Console.WriteLine("Triangle Cannot Be Formed");
    }

    else if (b+c < a)
    { 
     Console.WriteLine("Triangle Cannot Be Formed");
    }
     
    else
    {
      Console.WriteLine("Triangle Can Be Formed");
      if (a == b) {
       if (b == c) {
        if (c == a) {
        Console.WriteLine("Triangle is Equilateral");
        }
       }
      }
      if (a != b) {
       if (b != c) {
        if (c != a) {
          Console.WriteLine("Triangle is Scalene");
        }
       }
      }
      if (a == b) {
        if (c != a) {
          Console.WriteLine("Triangle is Isoceles");
        }
      }
      if (b == c) {
        if (c != a) {
          Console.WriteLine("Triangle is Isoceles");
        }
      }
      if (c == a) {
        if (b != c) {
          Console.WriteLine("Triangle is Isoceles");
        }
      }
    }
  }
}