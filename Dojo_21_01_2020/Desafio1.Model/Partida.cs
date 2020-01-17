using System;

namespace Desafio1.Model
{
    public class Partida
    {
        public DateTime Data { get; set; }
        public Dupla Dupla1 { get; set; }
        public Dupla Dupla2 { get; set; }
        public Placar Placar { get; set; }
    }
}