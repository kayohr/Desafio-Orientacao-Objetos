using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_praticando_poo.models
{
    //Personagem
    public class Construtores
    {
    public string Nome { get; set; }
    public string Raca { get; set; }
    public string Classe { get; set; }
    public int Nivel { get; set; } = 1;
    public int Vida { get; set; } = 10;

    public Construtores(string nome, string raca, string classe)
    {
        Nome = nome;
        Raca = raca;
        Classe = classe;
    }

public Construtores() //sem isso só passar os paramantros no Program
        {
            // Solicita as informações do jogador diretamente no método
            Console.WriteLine("Digite o nome do personagem:");
            Nome = Console.ReadLine();

            Console.WriteLine("Digite a raça do personagem:");
            Raca = Console.ReadLine();

            Console.WriteLine("Digite a classe do personagem:");
            Classe = Console.ReadLine();
        }
   
    public void ExibirStatus()
    {
        //Ou por o ReadLine aqui também
        // string Nome = Console.ReadLine();

        // string Raca = Console.ReadLine();

        // string Classe = Console.ReadLine();

        Console.WriteLine("Nome:" + Nome);
        Console.WriteLine("Raça:" + Raca);
        Console.WriteLine("Classe:" + Classe);
        Console.WriteLine("Nível:" + Nivel);
        Console.WriteLine("Vida:" + Vida);
    }
}


}