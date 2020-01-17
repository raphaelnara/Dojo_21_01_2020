using System;
using Desafio1.Model;

namespace Desafio1.Services
{
    public static class TelevisaoService
    {
        public static void ExibirResultado(Partida partida)
        {
            Console.WriteLine();
            Console.WriteLine($"Partida realizada em {partida.Data:dd/MM/yyyy HH:mm}");
            Console.Write($"({partida.Dupla1.Jogador1} | {partida.Dupla1.Jogador2})");
            Console.Write($" [{partida.Placar.Valor1}] x [{partida.Placar.Valor2}] ");
            Console.Write($"({partida.Dupla2.Jogador1} | {partida.Dupla2.Jogador2})");
            Console.WriteLine();
        }
    }
}
