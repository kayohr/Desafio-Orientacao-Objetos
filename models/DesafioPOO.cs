using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_praticando_poo.models
{
    public class DesafioPOO
    {
        private string nome;
        private int idade;

        //Pessoa
        public DesafioPOO(string n, int i)
    {
        nome = n;
        idade = i;
    }

        public DesafioPOO()
        {
        }
    //JEITO 1
    //     public string GetNome(string nome)
    // {
    //     return nome;
    // }

    // public int GetIdade(int idade)
    // {

    //     return idade;
    // }

    //JEITO 2
    public string GetNome()
    {        
        string nome = Console.ReadLine();

        return nome;
    }

    public int GetIdade()
    {
        int idade = int.Parse(Console.ReadLine());

        return idade;
    }
    
    public void DadosCompletos()
    {

    Console.WriteLine($"Nome: {GetNome()}, Idade: {GetIdade()}");

    }

        
    }
}