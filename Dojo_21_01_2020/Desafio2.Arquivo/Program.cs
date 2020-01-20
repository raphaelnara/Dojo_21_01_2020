using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Desafio2.Arquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            var arq = args.Length == 0 ? @"C:\\temp\output" : args[0];

            IEnumerable <DataRow> registros = Ler().AsEnumerable().Where(row => Convert.ToDateTime(row["Data"]) >= DateTime.Now.AddMonths(-1));
            Dictionary<string, int> kv = new Dictionary<string, int>();
            IEnumerable<Resultado> registros2 = registros.Select(row => new Resultado
            {
                Jogador1 = row["Jogador1"].ToString(),
                Jogador2 = row["Jogador2"].ToString(),
                Jogador3 = row["Jogador3"].ToString(),
                Jogador4 = row["Jogador4"].ToString(),
                Placar = row["Placar"].ToString()
            });
            registros2.ToList().ForEach(r =>
            {
                MatchCollection matches = Regex.Matches(r.Placar, @"[^X]+");
                int v1, v2;
                if (int.TryParse(matches[0].Value, out v1) && int.TryParse(matches[1].Value, out v2))
                {
                    if (v1 > v2)
                    {
                        if (kv.ContainsKey(r.Jogador1))
                            kv[r.Jogador1]++;
                        else
                            kv[r.Jogador1] = 1;
                        if (kv.ContainsKey(r.Jogador2))
                            kv[r.Jogador2]++;
                        else
                            kv[r.Jogador2] = 1;
                    }
                    if (v1 < v2)
                    {
                        if (kv.ContainsKey(r.Jogador3))
                            kv[r.Jogador3]++;
                        else
                            kv[r.Jogador3] = 1;
                        if (kv.ContainsKey(r.Jogador4))
                            kv[r.Jogador4]++;
                        else
                            kv[r.Jogador4] = 1;
                    }
                }
            });
            string str = string.Empty;
            Parallel.ForEach(kv, keyValue =>
                str += keyValue.Key + "," + keyValue.Value + "\n");
            StreamWriter writer = new StreamWriter(arq, false, Encoding.UTF8);
            writer.Write(str);
            Salvar(arq);
            Console.WriteLine("Arquivo exportado com sucesso");
            Console.Read();
        }
        
        private static DataTable Ler()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["BD"]);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Resultado", connection);
            DataTable result = new DataTable();
            adapter.Fill(result);
            return result;
        }

        private static DataTable Ler(string data)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["BD"]);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Resultado WHERE Data = " + data, connection);
            DataTable result = new DataTable();
            adapter.Fill(result);
            return result;
        }

        private static void Salvar(string a)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["BD"]);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "INSERT INTO Arquivo VALUES (GETDATE(), '" + a + "')";
            command.ExecuteNonQuery();
        }
    }
}
