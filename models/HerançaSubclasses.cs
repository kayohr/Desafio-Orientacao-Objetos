using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_praticando_poo.models
{
    // Classe base (Personagem)
    public class HerancaSubclasses
    {
        public string Nome { get; set; }
        public int Mana { get; set; }

        public HerancaSubclasses(string nome, int mana)
        {
            Nome = nome;
            Mana = mana;
        }

        //Ou com ReadLine junto com o Subclasse : base
        // public HerancaSubclasses()
        // {
        //     Console.WriteLine("Digite o nome do personagem:");
        //     Nome = Console.ReadLine();

        //     Console.WriteLine("Digite a quantidade de mana:");
        //     // Certifique-se de validar a entrada, este exemplo assume um número válido
        //     Mana = int.Parse(Console.ReadLine());
        // }
    }

    // Subclasse herda de HerancaSubclasses
    class Subclasse : HerancaSubclasses
    {
        public int DanoBase { get; set; }

        // Construtor da Subclasse chama o construtor da classe base (HerancaSubclasses)
        public Subclasse(string nome, int mana, int danoBase) : base(nome, mana)
        {
            DanoBase = danoBase;
        }
        //Ou com readline
        // public Subclasse() : base()
        // {
        //     Console.WriteLine("Digite o dano base da subclasse:");
        //     // Certifique-se de validar a entrada, este exemplo assume um número válido
        //     DanoBase = int.Parse(Console.ReadLine());
        // }

        // Método para calcular o dano
        public int CalcularDano()
        {
            return DanoBase * Mana;
        }

        // Método para exibir o resultado
        public void ExibirResultado()
        {
            // Calcular o dano
            int danoCausado = CalcularDano();

            // Exibir o resultado
            Console.WriteLine($"{Nome} atacou e causou {danoCausado} de dano!");
        }
    }
}