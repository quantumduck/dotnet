using System;

namespace exp1
{
    class Program
    {
        static void Main(string[] args)
        {
          if (args.Length == 0)
          {
            Console.WriteLine("You gotta give me something!");
          }
          else
          {
            Console.WriteLine($"I'm sorry, I don't know what {args[0]} is.");
          }
        }
    }
}
