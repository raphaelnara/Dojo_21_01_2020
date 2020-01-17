using System;
using Desafio1.Model;
using Desafio1.Services.Interfaces;

namespace Desafio1.Services
{
    public class XboxService : IDisplayService
    {
        public void ExibirPlacar(Placar placar)
        {
            Console.WriteLine();
            Console.WriteLine("XBOX");
            Console.WriteLine($"Realizada em {placar.Data:dd/MM/yyyy HH:mm}");
            Console.Write($"({placar.Partida.Participante1.Nome})");
            Console.Write($" [{placar.Valor1}] x [{placar.Valor2}] ");
            Console.Write($"({placar.Partida.Participante2.Nome})");
            Console.WriteLine("FATALITY!!!!");
            Console.WriteLine();
        }
    }
}