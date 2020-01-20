using System;
using Desafio1.Data;
using Desafio1.Model;

namespace Desafio1.Services
{
    public static class PingPongService
    {
        public static void Jogar(Partida partida)
        {
            var random = new Random();
            
            var placar = new Placar(partida, random.Next(5), random.Next(5));

            Database.SalvarResultado(placar);

            TvService.ExibirResultado(placar);
        }
    }
}
