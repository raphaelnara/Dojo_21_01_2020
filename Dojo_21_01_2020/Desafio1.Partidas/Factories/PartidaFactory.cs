using System;
using Desafio1.Partidas.Model;
using Desafio1.Partidas.Util;

namespace Desafio1.Partidas.Factories
{
    public static class PartidaFactory
    {
        public static Partida ConstruirPartida()
        {
            return new Partida
            {
                Dupla1 = new Dupla
                {
                    Jogador1 = new Jogador(ConsoleUtil.ObterInput("Entre com o jogador 1 para a dupla 1:")),
                    Jogador2 = new Jogador(ConsoleUtil.ObterInput("Entre com o jogador 2 para a dupla 1:"))
                },
                Dupla2 = new Dupla
                {
                    Jogador1 = new Jogador(ConsoleUtil.ObterInput("Entre com o jogador 1 para a dupla 2:")),
                    Jogador2 = new Jogador(ConsoleUtil.ObterInput("Entre com o jogador 2 para a dupla 2:"))
                },
            };
        }
    }
}
