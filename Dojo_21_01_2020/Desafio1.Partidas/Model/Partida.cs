namespace Desafio1.Partidas.Model
{
    public class Partida
    {
        public string Identificador => $"{Dupla1} x {Dupla2}";

        public Dupla Dupla1 { get; set; }

        public Dupla Dupla2 { get; set; }

        public override string ToString()
        {
            return Identificador;
        }
    }
}