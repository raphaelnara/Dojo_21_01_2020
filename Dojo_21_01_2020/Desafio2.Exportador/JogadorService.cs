using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Desafio2.Exportador.DTO;

namespace Desafio2.Exportador
{
    public class JogadorService
    {
        public List<PartidaJogador> ObterPartidasJogador(string nomeJogador)
        {
            var lista = new List<PartidaJogador>();
            try
            {
                using (var conn = new SqlConnection(ConfigurationManager.AppSettings["CONEXAO"]))
                {
                    try
                    {
                        using (var dataAdapterTempos = new SqlDataAdapter("SELECT * FROM Usuario", conn))
                        {
                            var ds = new DataSet();
                            dataAdapterTempos.Fill(ds, "Tempos");
                            return ds.Tables["Tempos"];
                        }
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
