
using System.Data;
using System.Windows.Forms;

using Facsis.Model.DTO;
using Facsis.Model.DAL;
using Facsis.Controller.Util;
using Npgsql;


namespace Facsis.Model.BLL
{
    class UsuarioBLL
    {
        AcessoBanco bd;

        // ==========================================================================================
        // SELECT, INSERT, UPDATE, DELETE
        // ==========================================================================================
        public void Inserir(UsuarioDTO dto)
        {
            bd = new AcessoBanco();

            try
            {
                // Insere dados na tabela usuario
                string nome = dto.Nome.Replace("'", "''");

                string cmd = "INSERT INTO usuario(" +
                    "nome, email, telefone, nivel) VALUES ('" +
                    nome + "','" + dto.Email + "','" + dto.Telefone + "','" + dto.Nivel + "') returning id_usuario";

                bd.Conectar();

                // Insere dados na tabela login <Motivo: Chave estrangeira FK>
                int id = bd.ExecutarComandoSqlRet(cmd);

                cmd = "INSERT INTO acesso(id_login, login_usuario, senha) VALUES ('" + id + "','" + dto.Login + "','" + dto.Senha + "')";
                bd.ExecutarComandoSql(cmd);

                Mensagens.cadastroInserir();
            }
            catch (NpgsqlException)
            {
                MessageBox.Show("Não foi possível efeturar o cadastro\nVerifique se todos os dados foram digitados corretamente ou se o LOGIN já está cadastrado.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                bd = null;
            }
        }

        public void Atualizar(UsuarioDTO dto)
        {
            bd = new AcessoBanco();

            try
            {
                string nome = dto.Nome.Replace("'", "''");
                string cmd = string.Format("UPDATE usuario SET nome = '{0}', email = '{1}', telefone = '{2}', nivel = '{3}' WHERE id_usuario = '{4}'", nome, dto.Email, dto.Telefone, dto.Nivel, dto.Id);

                bd.Conectar();
                bd.ExecutarComandoSql(cmd);

                bd.Conectar();
                cmd = string.Format("UPDATE acesso SET login_usuario = '{0}', senha = '{1}' WHERE id_login = '{2}'", dto.Login, dto.Senha, dto.Id);
                bd.ExecutarComandoSql(cmd);

                Mensagens.cadastroAlterar();
            }
            catch (NpgsqlException)
            {
                Mensagens.cadastroErroAlterar();
            }
            finally
            {
                bd = null;
            }
        }

        public void Excluir(string id)
        {
            bd = new AcessoBanco();

            try
            {
                string cmd = "DELETE FROM acesso WHERE id_login = " + id;
                bd.Conectar();
                bd.ExecutarComandoSql(cmd);

                cmd = "DELETE FROM usuario WHERE id_usuario = " + id;
                bd.Conectar();
                bd.ExecutarComandoSql(cmd);

                Mensagens.cadastroExcluir();
            }
            catch (NpgsqlException)
            {
                Mensagens.cadastroErroExcluir();                
            }
            finally
            {
                bd = null;
            }
        }

        public DataTable selecionaUsuario(string nome)
        {
            DataTable dt = new DataTable();
            bd = new AcessoBanco();

            try
            {
                bd.Conectar();
                dt = bd.RetDataTable("SELECT * FROM usuario u JOIN acesso a on u.id_usuario = a.id_login and u.nome = '" + nome + "'");
            }
            catch (NpgsqlException)
            {
                MessageBox.Show("Não foi possível efetuar a consulta de cadastros.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                bd = null;
            }

            return dt;
        }

        public DataTable selecionaUsuario(int id)
        {
            DataTable dt = new DataTable();
            bd = new AcessoBanco();

            try
            {
                bd.Conectar();
                dt = bd.RetDataTable(string.Format("SELECT * FROM usuario u JOIN acesso a on u.id_usuario = a.id_login and u.id_usuario = '" + id + "'"));
            }
            catch (NpgsqlException)
            {
                MessageBox.Show("Não foi possível efetuar a consulta de cadastros.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                bd = null;
            }

            return dt;
        }
    }
}
