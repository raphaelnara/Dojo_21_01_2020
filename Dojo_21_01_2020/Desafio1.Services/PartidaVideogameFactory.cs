using System;
using Desafio1.Model;
using Desafio1.Services.Interfaces;

namespace Desafio1.Services
{
    public class PartidaVideogameFactory : IPartidaFactory
    {
        public Partida GerarPartida()
        {
            string jogador1, jogador2;
            do
            {
                Console.WriteLine("Entre com o jogador 1:");
                jogador1 = Console.ReadLine();

                if (string.IsNullOrEmpty(jogador1))
                    Console.WriteLine("Valor inválido!");
            }
            while (string.IsNullOrEmpty(jogador1));

            do
            {
                Console.WriteLine("Entre com o jogador 2:");
                jogador2 = Console.ReadLine();

                if (string.IsNullOrEmpty(jogador2))
                    Console.WriteLine("Valor inválido!");
            }
            while (string.IsNullOrEmpty(jogador2));

            return new Partida
            {
                Participante1 = new Jogador(jogador1),
                Participante2 = new Jogador(jogador2)
            };
        }
    }
}