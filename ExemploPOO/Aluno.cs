namespace ExemploPOO1
{
  public class Aluno : Pessoas
  {
    public int Nota { get; set; }
    public override void Apresentar()
    {
      Console.WriteLine($"Olá, meu nome é {Nome} e sou aluno nota {Nota}");
    }

  }
}