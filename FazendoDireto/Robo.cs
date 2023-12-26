using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_praticando_poo.FazendoDireto
{
  class Robo
{
    public int VelocidadeAtual { get; set; } = 0;
    public int VelocidadeMaxima { get; }
    public int VelocidadeMinima { get; }

    public Robo(int vmin, int vmax)
    {
        VelocidadeMinima = vmin;
        VelocidadeMaxima = vmax;
        VelocidadeAtual = vmin;
    }

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
}
}
// class Program
// {
//     static void Main()
//     {
//         // Lê os valores de Vmin e Vmax
//         string[] velocidades = Console.ReadLine().Split();
//         int vmin = int.Parse(velocidades[0]);
//         int vmax = int.Parse(velocidades[1]);

//         // Cria um objeto Robo com base nas velocidades fornecidas
//         Robo robo = new Robo(vmin, vmax);

//         // Lê a sequência de comandos
//         string comandos = Console.ReadLine();

//         // Itera sobre os comandos e aplica as ações no robô
//         foreach (char comando in comandos)
//         {
//             if (comando == 'A')
//             {
//                 robo.Acelerar();
//             }
//             else if (comando == 'D')
//             {
//                 robo.Desacelerar();
//             }
//         }

//         // Exibe a velocidade final do robô
//         Console.WriteLine(robo.VelocidadeAtual);
//     }
// }
// }