namespace Desafio1.Partidas.Model
{
    public class Jogador
    {
        public string Nome { get; }

        public Jogador(string nome)
        {
            Nome = nome;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}