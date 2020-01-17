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

            partida.Data = DateTime.Now;
            partida.Placar = new Placar
            {
                Valor1 = random.Next(5),
                Valor2 = random.Next(5)
            };

            Database.SalvarPartida(partida);

            TelevisaoService.ExibirResultado(partida);
        }
    }
}
