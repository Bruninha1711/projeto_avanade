using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
  class Program
  {
    public delegate void Operacao(int x, int y);
    static void Main(string[] args)
    {
      Matematica m = new Matematica(10, 20);
      m.Somar();
    }
    // {
    //   Operacao op = new Operacao(Calculadora.Somar);
    //   op.Invoke(10, 10);

    // }
    // {
    //   Data data = new Data();
    //   //data.SetMes(2);
    //   data.Mes = 12;
    //   //System.Console.WriteLine(data.Mes);
    //   data.ApresentarMes();


    // }
    // {
    //   log log = log.GetInstance();
    //   log.Propriedadelog = "teste instancia";

    //   log log2 = log.GetInstance();
    //   System.Console.WriteLine(log2.Propriedadelog);
    // }


    // {
    //   Pessoa p1 = new Pessoa("Leonardo", "Buta");
    //   p1.Apresentar();
    // }
  }
}
