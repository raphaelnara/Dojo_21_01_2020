using System;
using Desafio1.Data;
using Desafio1.Model;
using Desafio1.Services.Interfaces;

namespace Desafio1.Services
{
    public class PingPongService : IJogoService
    {
        private readonly IDisplayService _display;
        private readonly IPartidaFactory _partidaFactory;
        private readonly IRepository<Placar> _placarRepository;
        private readonly IRepository<Partida> _partidaRepository;

        public PingPongService(IPartidaFactory partidaFactory, IRepository<Partida> partidaRepository, IRepository<Placar> placarRepository, IDisplayService exibidor)
        {
            _display = exibidor;
            _partidaFactory = partidaFactory;
            _placarRepository = placarRepository;
            _partidaRepository = partidaRepository;
        }

        public void Jogar()
        {
            var partida = _partidaFactory.GerarPartida();

            var random = new Random();
            var valor1 = random.Next(10);
            var valor2 = random.Next(10);
            var placar = new Placar(partida, valor1, valor2);

            _partidaRepository.Salvar(partida);
            _placarRepository.Salvar(placar);
            _display.ExibirPlacar(placar);
        }
    }
}
