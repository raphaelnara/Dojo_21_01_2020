using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Desafio1.Model;

namespace Desafio2.Console.Extracao
{
    class Program
    {
        private static Dictionary<string, int> _quantidadeVitoriasJogador = new Dictionary<string, int>();

        static void Main(string[] args)
        {
            var table = LerRegistrosBase();

            ExportarMaioresVencedoresCsv(table);
        }

        /// <summary>
        /// Método que percorre as linhas do DataTable e converte elas para objetos Partida
        /// Em seguida filtra os do último mês e conta as vitórias 
        /// </summary>
        /// <param name="table"></param>
        private static void ExportarMaioresVencedoresCsv(DataTable table)
        {
            var partidas = table.AsEnumerable().Select(row => new Partida
                {
                    Data = Convert.ToDateTime(row["Data"]),
                    Dupla1 = new Dupla
                    {
                        Jogador1 = row["Jogador1"].ToString(),
                        Jogador2 = row["Jogador2"].ToString()
                    },
                    Dupla2 = new Dupla
                    {
                        Jogador1 = row["Jogador3"].ToString(),
                        Jogador2 = row["Jogador4"].ToString()
                    },
                    Placar = new Placar
                    {
                        Valor1 = Convert.ToInt32(row["ValorPlacar1"]),
                        Valor2 = Convert.ToInt32(row["ValorPlacar2"])
                    }
                })
                .Where(partida => partida.Data >= DateTime.Now.AddMonths(-1));
        }

        public static DataTable LerRegistrosBase()
        {
            var connection = new SqlConnection(ConfigurationManager.AppSettings["CONEXAO"]);
            var adapter = new SqlDataAdapter("SELECT * FROM Partida", connection);
            var table = new DataTable("Partida");
            adapter.Fill(table);
            return table;
        }
    }
}
