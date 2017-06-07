using System;
using System.Data;
using System.Windows.Forms;

using Npgsql;

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
            conn = new NpgsqlConnection(connStr);

            try
            {
                conn.Open();
            }
            catch (NpgsqlException)
            {
                MessageBox.Show("Não foi possível se conectar ao banco.\nErro do banco: ", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível se conectar ao banco.\nErro do sistema: ", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            int id = 0;

            NpgsqlCommand cmd = new NpgsqlCommand(comando, conn);
            id = Convert.ToInt32(cmd.ExecuteScalar());

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
