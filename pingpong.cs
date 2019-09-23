using System;

class PingPong
{
  static void Main()
  {
    Console.WriteLine("Give me a number");
    int yourNumber = int.Parse(Console.ReadLine());
    for (int i = 1; i <= yourNumber; i++)
    {
      if (i % 3 == 0 && i % 5 == 0)
      {
        Console.WriteLine("pingpong");
      }
      else if (i % 3 == 0)
      {
        Console.WriteLine("ping");
      }
      else if (i % 5 == 0)
      {
        Console.WriteLine("pong");
      }
      else {
        Console.WriteLine(i);
      }
    }
  }
}
