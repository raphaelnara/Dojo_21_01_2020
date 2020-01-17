namespace Desafio1.Model
{
    public class Jogador : Participante
    {
        public override string Nome { get; }

        public Jogador(string nome)
        {
            Nome = nome;
        }
    }
}
