using System;
using Desafio1.Partidas.Services;

namespace Desafio1.Partidas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string resposta;
                do
                {
                    PingPongService.ExecutarNovaPartida();

                    Console.WriteLine("Deseja jogar mais uma partida? (S/N)");
                    resposta = Console.ReadLine();

                    Console.WriteLine();
                }
                while (string.IsNullOrEmpty(resposta) || resposta.Equals("S", StringComparison.InvariantCultureIgnoreCase));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.Read();
            }
        }
    }
}
