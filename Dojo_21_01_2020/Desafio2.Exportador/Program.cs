using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Desafio2.Exportador
{
    class Program
    {
        static void Main(string[] args)
        {
            int tipoAtleta;

            var table = LerRegistrosBaseDeDados();

            foreach (DataRow row in table.Rows)
            {
                var status = Convert.ToInt32(row["Status"]);
                if (status == 1)
                {

                }
                else if (status == 2)
                {

                }
            }
        }

        private static DataTable LerRegistrosBaseDeDados()
        {
            try
            {
                using (var conn = new SqlConnection(ConfigurationManager.AppSettings["CONEXAO"]))
                {
                    try
                    {
                        using (var dataAdapterUsuarios = new SqlDataAdapter("SELECT * FROM Usuario", conn))
                        {
                            var ds = new DataSet();
                            dataAdapterUsuarios.Fill(ds, "Usuarios");
                            return ds.Tables["Usuarios"];
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
