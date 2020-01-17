using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Desafio2.Console.ExtracaoColetas
{
    class Program
    {
        static void Main(string[] args)
        {
            var operacoes = LerOperacoes();
        }

        private static DataTable LerOperacoes()
        {
            var connection = new SqlConnection(ConfigurationManager.AppSettings["CONEXAO"]);
            var adapter = new SqlDataAdapter("SELECT * FROM Operacao", connection);
            var table = new DataTable("Funcionario");
            adapter.Fill(table);
            return table;
        }
    }
}
