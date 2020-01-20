using System;
using Desafio1.Data;
using Desafio1.Model;

namespace Desafio1.Services.Interfaces
{
    public interface IJogoService
    {
        Placar Jogar(Partida partida);
    }

    public class VideogameService : IJogoService
    {
        public VideogameService()
        {
            
        }
        public Placar Jogar(Partida partida)
        {
            var random = new Random();

            var placar = new Placar(partida, random.Next(5), random.Next(5));

            Database.SalvarResultado(placar);

            TvService.ExibirResultado(placar);

            return placar;
        }
    }

    public class PingPongService : IJogoService
    {
        public Placar Jogar(Partida partida)
        {
            var random = new Random();

            var placar = new Placar(partida, random.Next(5), random.Next(5));

            Database.SalvarResultado(placar);

            TvService.ExibirResultado(placar);

            return placar;
        }
    }
}
