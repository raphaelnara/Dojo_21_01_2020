using System;
using Desafio1.Data.Interfaces;
using Desafio1.Model;

namespace Desafio1.Data
{
    public class PlacarPingPongRepository : IPlacarRepository
    {
        public void Salvar(Placar placar)
        {
            Console.WriteLine("Resultado da partida de Ping Pong registrado no banco de dados");
        }
    }
}