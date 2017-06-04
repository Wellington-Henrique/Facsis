using System;

using System.Data;
using Npgsql;
using Facsis.Controller.Util;

namespace Facsis.Model.DAL
{
    class AcessoBanco
    {
        private NpgsqlConnection conn;
        private DataTable data;
        private NpgsqlDataAdapter da;
        private NpgsqlDataReader dr;
        private NpgsqlCommandBuilder cb;

        private String server = "localhost";
        private String user = "postgres";
        private String password = "postgres";
        private String database = "dbfacsis";

        public void Conectar()
        {
            string connStr = String.Format("server = {0}; user = {1}; password = {2}; database = {3}; pooling = false", server, user, password, database);

            try
            {
                conn = new NpgsqlConnection(connStr);
                conn.Open();
            }
            catch(NpgsqlException ex)
            {
                Mensagens.erroConexao(ex);
            }            
            catch (Exception ex)
            {
                Mensagens.erroConexao(ex);
            }
        }

        public void ExecutarComandoSql(string comando)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(comando, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public int ExecutarComandoSqlRet(string comando)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(comando, conn);
            int id = Convert.ToInt32(cmd.ExecuteScalar());

            return id;
        }

        public DataTable RetDataTable(string sql)
        {
            data = new DataTable();
            da = new NpgsqlDataAdapter(sql, conn);
            cb = new NpgsqlCommandBuilder(da);
            da.Fill(data);

            return data;
        }

        public NpgsqlDataReader RetDataReader(string sql)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            return dr;
        }
    }
}
