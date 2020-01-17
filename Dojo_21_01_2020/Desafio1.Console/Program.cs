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
                System.Console.WriteLine("Deseja jogar o quê? Ping Pong = 1, Videogame = 2");
                resposta = System.Console.ReadLine();
                if (resposta == null) continue;

                var fabricaJogo = new JogoFactory();
                var jogo = fabricaJogo.CriarJogo(resposta);
                jogo.Jogar();

                System.Console.WriteLine("Deseja jogar mais uma partida? (S/N)");
                resposta = System.Console.ReadLine();
            }
            while (string.IsNullOrEmpty(resposta) || resposta.Equals("S", StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
