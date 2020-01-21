namespace Desafio1.Partidas.Model
{
    public class Dupla
    {
        public string Nome => $"({Jogador1} e {Jogador2})";

        public Jogador Jogador1 { get; set; }

        public Jogador Jogador2 { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
