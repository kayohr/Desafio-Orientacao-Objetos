using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_praticando_poo.models
{
    public class ObjetoComAtributos
    {
        //Jogador
    public string Nome { get; set; }
    public string Nacionalidade { get; set; }
    public int Idade { get; set; }
    public string Posicao { get; set; }

    public static ObjetoComAtributos JogadorNovo(string nome, string nacionalidade, int idade, string posicao)
    {
        return new ObjetoComAtributos
        {
            Nome = nome,
            Nacionalidade = nacionalidade,
            Idade = idade,
            Posicao = posicao
        };
    }
   public void ExibirInformacoesJogador()
        {
            // Solicita as informações do jogador diretamente no método
            Console.WriteLine("Digite o nome do jogador:");
            Nome = Console.ReadLine();

            Console.WriteLine("Digite a nacionalidade do jogador:");
            Nacionalidade = Console.ReadLine();

            Console.WriteLine("Digite a idade do jogador:");
            _ = int.TryParse(Console.ReadLine(), out int Idade);           

            Console.WriteLine("Digite a posição do jogador:");
            Posicao = Console.ReadLine();

            // Exibe as informações do jogador
            Console.WriteLine("\nJogador criado!");
            Console.WriteLine(Nome);
            Console.WriteLine(Nacionalidade);
            Console.WriteLine(Idade);
            Console.WriteLine($"Posição: {Posicao}");
        }
}

    }
