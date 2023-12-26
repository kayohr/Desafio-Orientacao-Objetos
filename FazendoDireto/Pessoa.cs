using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_praticando_poo.FazendoDireto
{
class Pessoa
{
    private string nome;
    private int idade;

    public Pessoa(string n, int i)
    {
        nome = n;
        idade = i;
    }

    public string GetNome()
    {
        return nome;
    }

    public int GetIdade()
    {
        return idade;
    }
}
}
// class Program
// {
//     static void Main()
//     {
//         // Solicita ao usuário que insira o nome
//         Console.Write("Digite o nome: ");
//         string nome = Console.ReadLine();

//         // Solicita ao usuário que insira a idade
//         Console.Write("Digite a idade: ");
//         int idade = int.Parse(Console.ReadLine());

//         // Cria um objeto Pessoa com base nas informações fornecidas pelo usuário
//         Pessoa pessoa = new Pessoa(nome, idade);

//         // Exibe o nome e a idade da pessoa usando os métodos GetNome() e GetIdade()
//         Console.WriteLine($"Nome: {pessoa.GetNome()}, Idade: {pessoa.GetIdade()}");
//     }
// }
// }