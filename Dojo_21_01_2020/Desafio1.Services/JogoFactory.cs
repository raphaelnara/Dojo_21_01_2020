using System;
using Desafio1.Data;
using Desafio1.Services.Interfaces;

namespace Desafio1.Services
{
    public class JogoFactory : IJogoFactory
    {
        public IJogoService CriarJogo(string id)
        {
            var repositorioPlacares = new PlacarRepository();
            var repositorioPartidas = new PartidaRepository();
            switch (id)
            {
                case "1":
                    var tv = new TvService();
                    var partidaPingPongFactory = new PartidaPingPongFactory();
                    return new PingPongService(partidaPingPongFactory, repositorioPartidas, repositorioPlacares, tv);
                case "2":
                    var xbox = new XboxService();
                    var partidaXboxFactory = new PartidaVideogameFactory();
                    return new PingPongService(partidaXboxFactory, repositorioPartidas, repositorioPlacares, xbox);
                default:
                    throw new ArgumentException("Serviço inválido");
            }
        }
    }
}
