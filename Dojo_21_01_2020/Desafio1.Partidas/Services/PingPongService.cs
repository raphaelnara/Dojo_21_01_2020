using System;
using Desafio1.Partidas.Factories;
using Desafio1.Partidas.Model;

namespace Desafio1.Partidas.Services
{
    public static class PingPongService
    {
        public static void ExecutarNovaPartida()
        {
            var partida = PartidaFactory.ConstruirPartida();

            var random = new Random();
            
            var placar = new Placar(partida, random.Next(5), random.Next(5));

            Database.Database.SalvarResultado(placar);

            TvService.ExibirResultado(placar);
        }
    }
}
