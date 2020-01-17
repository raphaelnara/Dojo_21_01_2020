using System;
using Desafio1.Services;

namespace Desafio1.Sumula
{
    class Program
    {
        static void Main(string[] args)
        {
            var resposta = "S";
            do
            {
                var partida = PartidaFactory.ContruirPartida();
                PingPongService.Jogar(partida);
                
                Console.WriteLine("Deseja jogar mais uma partida? (S/N)");
                resposta = Console.ReadLine();
            }
            while (!string.IsNullOrEmpty(resposta) && !resposta.Equals("S", StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
