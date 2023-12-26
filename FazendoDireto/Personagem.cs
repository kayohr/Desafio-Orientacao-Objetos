using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_praticando_poo.FazendoDireto
{
    using System;

class Personagem
{
    public string Nome { get; set; }
    public string Raca { get; set; }
    public string Classe { get; set; }
    public int Nivel { get; set; } = 1;
    public int Vida { get; set; } = 10;

    public Personagem(string nome, string raca, string classe)
    {
        Nome = nome;
        Raca = raca;
        Classe = classe;
    }

    public void ExibirStatus()
    {
        Console.WriteLine("Status:");
        Console.WriteLine($"Nome:{Nome}");
        Console.WriteLine($"Raça:{Raca}");
        Console.WriteLine($"Classe:{Classe}");
        Console.WriteLine($"Nível:{Nivel}");
        Console.WriteLine($"Vida:{Vida}");
    }
}
}
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Digite o nome do personagem:");
//         string nome = Console.ReadLine();

//         Console.WriteLine("Digite a raça do personagem:");
//         string raca = Console.ReadLine();

//         Console.WriteLine("Digite a classe do personagem:");
//         string classe = Console.ReadLine();

//         // Criação do personagem com os dados fornecidos
//         Personagem personagem = new Personagem(nome, raca, classe);

//         // Exibe o status do personagem
//         personagem.ExibirStatus();
//     }
// }

// }