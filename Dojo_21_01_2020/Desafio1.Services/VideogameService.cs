﻿using System;
using Desafio1.Data;
using Desafio1.Model;
using Desafio1.Services.Interfaces;

namespace Desafio1.Services
{
    public class VideogameService : IJogoService
    {
        private readonly IDisplayService _display;
        private readonly IPartidaFactory _partidaFactory;
        private readonly IRepository<Placar> _placarRepository;
        private readonly IRepository<Partida> _partidaRepository;

        public VideogameService(IPartidaFactory partidaFactory, IRepository<Partida> partidaRepository, IRepository<Placar> placarRepository, IDisplayService exibidor)
        {
            _display = exibidor;
            _partidaFactory = partidaFactory;
            _placarRepository = placarRepository;
            _partidaRepository = partidaRepository;
        }

        public void Jogar()
        {
            const int totalRodadas = 3;

            int valor1 = 0, valor2 = 0;

            var random = new Random();
            for (int rodada = 0; rodada < totalRodadas; rodada++)
            {
                if (random.Next(10) % 2 == 0)
                    valor1++;
                else
                    valor2++;
            }

            var partida = _partidaFactory.GerarPartida();
            var placar = new Placar(partida, valor1, valor2);

            _partidaRepository.Salvar(partida);
            _placarRepository.Salvar(placar);
            _display.ExibirPlacar(placar);
        }
    }
}