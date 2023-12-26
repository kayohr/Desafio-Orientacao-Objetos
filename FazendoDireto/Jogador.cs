using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_praticando_poo.FazendoDireto
{
    class Jogador
{
    public string Nome { get; set; }
    public string Nacionalidade { get; set; }
    public int Idade { get; set; }
    public string Posicao { get; set; }

    public Jogador()
    {
    }

    public static Jogador Novo(string nome, string nacionalidade, int idade, string posicao)
    {
        return new Jogador
        {
            Nome = nome,
            Nacionalidade = nacionalidade,
            Idade = idade,
            Posicao = posicao
        };
    }
}
}
// class Program
// {
//     static void Main()
//     {
//         // Lê as informações do jogador
//         Console.WriteLine("Digite o nome do jogador:");
//         string nome = Console.ReadLine();

//         Console.WriteLine("Digite a nacionalidade do jogador:");
//         string nacionalidade = Console.ReadLine();

//         Console.WriteLine("Digite a idade do jogador:");
//         int idade;
//         while (!int.TryParse(Console.ReadLine(), out idade) || idade <= 0)
//         {
//             Console.WriteLine("Idade inválida. Digite novamente:");
//         }

//         Console.WriteLine("Digite a posição do jogador:");
//         string posicao = Console.ReadLine();

//         // Cria um novo jogador
//         Jogador jogador = Jogador.Novo(nome, nacionalidade, idade, posicao);

//         // Exibe as informações do jogador
//         Console.WriteLine("\nJogador criado!");
//         Console.WriteLine(jogador.Nome);
//         Console.WriteLine(jogador.Nacionalidade);
//         Console.WriteLine(jogador.Idade);
//         Console.WriteLine($"Posição: {jogador.Posicao}");
//     }
// }
// }