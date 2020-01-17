using System;
using Desafio1.Services;

namespace Desafio1.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta = null;
            do
            {
                System.Console.WriteLine();

                var partida = PartidaFactory.ContruirPartida();
                PingPongService.Jogar(partida);

                System.Console.WriteLine("Deseja jogar mais uma partida? (S/N)");
                resposta = System.Console.ReadLine();
            }
            while (string.IsNullOrEmpty(resposta) || resposta.Equals("S", StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
