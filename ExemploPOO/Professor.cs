namespace ExemploPOO1
{
  public class Professor : Pessoas
  {
    public double Salario { get; set; }
    public override void Apresentar()
    {
      Console.WriteLine($"Olá, meu nome é {Nome} e ganho um salário de {Salario}");
    }

  }
}