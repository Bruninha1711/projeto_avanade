// See https://aka.ms/new-console-template for more information
using Interface;
using Enum;
using Primeiro;
using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoas1 = (Pessoas)0;
            Pessoas pessoas2 = Pessoas.João;
            Pessoas pessoas3 = (Pessoas)4;

            Pessoa person = new Pessoa();

            person.Nome = "Bruna Luiza";
            person.Idade = 21;
            person.Estado = "São Paulo";

            var person2 = new Pessoa();

            person2.Nome = "Blenda Luiza";
            person2.Idade = 28;
            person2.Estado = "São Paulo";

            Animal animal = new Animal();

            animal.nome = "Nina";
            animal.Especie = "Cachorro";
            animal.nomeDono = "Bruna";
            Console.WriteLine(pessoas3);

        }
    }
}


