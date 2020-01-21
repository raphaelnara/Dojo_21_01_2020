using System;

namespace Desafio1.Partidas.Model
{
    public class Placar
    {
        public DateTime Data { get; }

        public Partida Partida { get; }

        public int Valor1 { get; }

        public int Valor2 { get; }

        public Placar(Partida partida, int valor1, int valor2)
        {
            Data = DateTime.Now;
            Partida = partida;
            Valor1 = valor1;
            Valor2 = valor2;
        }

        public override string ToString()
        {
            return $"{Data:dd/MM/yyyy HH:mm} - {Partida.Dupla1} [{Valor1}] x [{Valor2}] {Partida.Dupla2}";
        }
    }
}
