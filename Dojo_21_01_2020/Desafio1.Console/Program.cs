using System;
using Desafio1.Services;

namespace Desafio1.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string resposta = null;
                do
                {
                    PingPongService.CriarNovaPartida();

                    System.Console.WriteLine("Deseja jogar mais uma partida? (S/N)");
                    resposta = System.Console.ReadLine();

                    System.Console.WriteLine();
                }
                while (string.IsNullOrEmpty(resposta) || resposta.Equals("S", StringComparison.InvariantCultureIgnoreCase));
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
                System.Console.Read();
            }
        }
    }
}
