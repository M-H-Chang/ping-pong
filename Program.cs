using System;
using System.Collections.Generic;



namespace PingPongGame
{
  public class PingPong
  {

    static void Main()
    {
      Console.Write("Please enter a number to return our cool Ping Pong statement: ");
      string UserInput = Console.ReadLine();
      int Input = int.Parse(UserInput);

      for (int index = 1; index <= Input; index++)
      {
        if ((index % 3 == 0) && (index % 5 == 0))
        {
          Console.WriteLine("Ping-Pong");
        }
        else if ((index % 3) == 0)
        {
          Console.WriteLine("Ping");
        }
        else if ((index % 5) == 0)
        {
          Console.WriteLine("Pong");
        }
        else
        {
          Console.WriteLine(index);
        }
      }
    }
  }
}