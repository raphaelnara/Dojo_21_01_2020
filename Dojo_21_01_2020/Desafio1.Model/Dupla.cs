namespace Desafio1.Model
{
    public class Dupla
    {
        public string Jogador1 { get; set; }
        public string Jogador2 { get; set; }

        public override string ToString()
        {
            return $"({Jogador1} e {Jogador2})";
        }
    }
}
