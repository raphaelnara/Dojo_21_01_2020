namespace Desafio1.Model
{
    public class Dupla : Participante
    {
        public Jogador Jogador1 { get; set; }

        public Jogador Jogador2 { get; set; }

        public override string Nome => $"{Jogador1.Nome} / {Jogador2.Nome}";
    }
}
