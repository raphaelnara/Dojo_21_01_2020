namespace Desafio2.Arquivo
{
    public class ResultadoBanco
    {
        public bool Sucesso
        {
            get { return string.IsNullOrEmpty(Erro); }
        }
        public string Erro { get; set; }

        public ResultadoBanco() { }

        public ResultadoBanco(string erro)
        {
            Erro = erro;
        }
    }
}
