using System;

namespace Desafio1.Model
{
    public class Placar
    {
        public DateTime Data { get; }
        public Partida Partida { get; }
        public int Valor1 { get; }
        public int Valor2 { get; }

        public Placar(Partida partida, int valor1, int valor2)
        {
            Partida = partida;
            Data = DateTime.Now;
            Valor1 = valor1;
            Valor2 = valor2;
        }
    }
}
