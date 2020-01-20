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

namespace Desafio2.Extracao
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<DataRow> rowCollection;
            if (args.Length > 0)
            {
                rowCollection = LerRegistrosBancoDeDados(args[0]).AsEnumerable();
            }
            else
            {
                rowCollection = LerRegistrosBancoDeDados().AsEnumerable().Where(row =>
                {
                    var data = Convert.ToDateTime(row["Data"]);
                    return data >= DateTime.Now.AddMonths(-1);
                });
            }

            var resultados = rowCollection.Select(row => new Resultado
                {
                    Jogador1 = row["Jogador1"].ToString(),
                    Jogador2 = row["Jogador2"].ToString(),
                    Jogador3 = row["Jogador3"].ToString(),
                    Jogador4 = row["Jogador4"].ToString(),
                    Placar = row["Placar"].ToString()
                });

            var kv = new Dictionary<string, int>();

            resultados.ToList().ForEach(resultado =>
            {
                var matches = Regex.Matches(resultado.Placar, @"[^X]+");

                int v1, v2;
                if (int.TryParse(matches[0].Value, out v1) && int.TryParse(matches[1].Value, out v2))
                {
                    if (v1 > v2)
                    {
                        if (kv.ContainsKey(resultado.Jogador1))
                            kv[resultado.Jogador1]++;
                        else
                            kv[resultado.Jogador1] = 1;

                        if (kv.ContainsKey(resultado.Jogador2))
                            kv[resultado.Jogador2]++;
                        else
                            kv[resultado.Jogador2] = 1;
                    }
                    if (v1 < v2)
                    {
                        if (kv.ContainsKey(resultado.Jogador3))
                            kv[resultado.Jogador3]++;
                        else
                            kv[resultado.Jogador3] = 1;

                        if (kv.ContainsKey(resultado.Jogador4))
                            kv[resultado.Jogador4]++;
                        else
                            kv[resultado.Jogador4] = 1;
                    }
                }
            });

            var csv = string.Empty;

            Parallel.ForEach(kv, keyValue =>
                csv += keyValue.Key + "," + keyValue.Value + "\n");

            var writer = new StreamWriter(@"C:\\temp\output.csv",false, Encoding.UTF8);
            writer.Write(csv);
            writer.Close();

            Console.WriteLine("Arquivo exportado com sucesso");
            Console.Read();
        }
        
        private static DataTable LerRegistrosBancoDeDados()
        {
            var connection = new SqlConnection(ConfigurationManager.AppSettings["BD"]);
            var adapter = new SqlDataAdapter("SELECT * FROM Resultado", connection);
            var result = new DataTable();
            adapter.Fill(result);
            return result;
        }

        private static DataTable LerRegistrosBancoDeDados(string data)
        {
            var connection = new SqlConnection(ConfigurationManager.AppSettings["BD"]);
            var adapter = new SqlDataAdapter("SELECT * FROM Resultado WHERE Data = " + data, connection);
            var result = new DataTable();
            adapter.Fill(result);
            return result;
        }
    }
}
