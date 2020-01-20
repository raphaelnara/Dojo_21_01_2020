namespace Desafio1.Model
{
    public class Dupla
    {
        public Jogador Jogador1 { get; set; }
        public Jogador Jogador2 { get; set; }

        public override string ToString()
        {
            return $"({Jogador1} e {Jogador2})";
        }
    }
}
