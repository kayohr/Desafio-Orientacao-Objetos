using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_praticando_poo.models
{
    public class PropriedadesMetodos
    {
    public int VelocidadeAtual { get; set; } = 0;
    public int VelocidadeMaxima { get; }
    public int VelocidadeMinima { get; }

    public PropriedadesMetodos(int vmin, int vmax)
    {
        VelocidadeMinima = vmin;
        VelocidadeMaxima = vmax;
        VelocidadeAtual = vmin;
    }

        // public PropriedadesMetodos()
        // {
        // }

        public void Acelerar()
    {
        if (VelocidadeAtual < VelocidadeMaxima)
        {
            VelocidadeAtual++;
        }
    }

    public void Desacelerar()
    {
        if (VelocidadeAtual > VelocidadeMinima)
        {
            VelocidadeAtual--;
        }
    }

    public void Resultado(string comandos)
    {
        // Ou, sem paramantros
        //  string comandos = Console.ReadLine();

         foreach (char c in comandos)
            {
                if (c == 'A')
                {
                    Acelerar();
                }
                else if (c == 'D')
                {
                    Desacelerar();
                }
            }
            Console.WriteLine(VelocidadeAtual);
           
        }
    }
}
