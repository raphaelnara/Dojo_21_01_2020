using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Desafio2.Pagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            var table = ListarFuncionarios();
            var funcionarios = table.AsEnumerable().Select(row => new Funcionario());
        }

        private static DataTable ListarFuncionarios()
        {
            var connection = new SqlConnection(ConfigurationManager.AppSettings["CONEXAO"]);
            var adapter = new SqlDataAdapter("SELECT * FROM Funcionario", connection);
            var table = new DataTable("Funcionario");
            adapter.Fill(table);
            return table;
        }

        private static DataTable ListarEstagiarios()
        {
            var connection = new SqlConnection(ConfigurationManager.AppSettings["CONEXAO"]);
            var adapter = new SqlDataAdapter("SELECT * FROM Estagiario", connection);
            var table = new DataTable("Estagiario");
            adapter.Fill(table);
            return table;
        }
    }
}
