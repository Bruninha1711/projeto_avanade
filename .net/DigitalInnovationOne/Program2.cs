using System;

namespace Instrucoes
{
  class Program2
  {
    static void Declaracoes()
    {
      int a;
      int b = 2, c = 3;
      const int d = 4;
      a = 1;
      Console.Writeline(a + b + c + d);
    }
    static void InstrucaoIf(string[] args)
    {
      if (args.Length == 0)
      {
        Console.WriteLine(" Nenhum argumento");
      }
      else if (args.Length == 1)
      {
        Console.WriteLine("Um argumento");
      }
      else
      {
        Console.WriteLine($"(args.Length) argumentos");
      }

    }
    static void InstrucaoSwitch(string[] args)
    {
      int numeroDeArgumentos = args.Length;
      switch (numeroDeArgumentos)
      {
        case 0:
          Console
      }
    }
    static void InstrucaoWhile(string[] args)
  }
}