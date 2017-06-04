using System;

using Facsis.Model.DTO;
using Facsis.Model.DAL;
using Facsis.Controller.Util;
using System.Data;

namespace Facsis.Model.BLL
{
    class UsuarioBLL
    {
        AcessoBanco bd = new AcessoBanco();

        //======================================================
        //  Solicita cadastro no banco
        //======================================================
        public void Inserir(UsuarioDTO dto)
        {
            try
            {
                // Insere dados na tabela usuario
                string nome = dto.Nome.Replace("'", "''");
                string cmd = "INSERT INTO usuario(" +
                    "nome, email, telefone, funcao) VALUES ('" +
                    nome + "','" + dto.Email + "','" + dto.Telefone + "','" + dto.Nivel + "') returning id_usuario";

                bd.Conectar();

                // Insere dados na tabela login <Motivo: Chave estrangeira FK>
                int id = bd.ExecutarComandoSqlRet(cmd);
                cmd = "INSERT INTO acesso(id_login, login_usuario, senha) VALUES ('" + id + "','" + dto.Login + "','" + dto.Senha + "')";
                bd.ExecutarComandoSql(cmd);

                Mensagens.cadastroEfetuado();
            }
            catch (Exception ex)
            {
                Mensagens.erroConexao(ex);
            }
            finally
            {
                bd = null;
            }
        }

        //======================================================
        //  Solicita atualização do cadastro no banco
        //======================================================
        public void Atualizar(UsuarioDTO dto)
        {
            try
            {
                string nome = dto.Nome.Replace("'", "''");
                string cmd = string.Format("UPDATE usuario SET nome = '{0}', email = '{1}', telefone = '{2}', funcao = '{3}' WHERE id_usuario = '{4}'", nome, dto.Email, dto.Telefone, dto.Nivel, dto.Id);

                bd = new AcessoBanco();
                bd.Conectar();
                bd.ExecutarComandoSql(cmd);

                Mensagens.cadastroAlterado();
            }
            catch (Exception ex)
            {
                Mensagens.erroConexao(ex);
            }
            finally
            {
                bd = null;
            }
        }

        //======================================================
        //  Solicita exclusão do cadastro no banco
        //======================================================
        public void Excluir(string id)
        {
            try
            {
                bd = new AcessoBanco();

                string cmd = "DELETE FROM acesso WHERE id_login = " + id;
                bd.Conectar();
                bd.ExecutarComandoSql(cmd);

                cmd = "DELETE FROM usuario WHERE id_usuario = " + id;
                bd.Conectar();                          
                bd.ExecutarComandoSql(cmd);

                Mensagens.cadastroExcluido();
            }
            catch (Exception ex)
            {
                Mensagens.erroConexao(ex);
            }
            finally
            {
                bd = null;
            }
        }

        //======================================================
        //  Seleciona cadastro no banco pelo nome do usuário
        //======================================================
        public DataTable selecionaUsuarioNome(string nome)
        {
            DataTable dt = new DataTable();

            try
            {
                bd = new AcessoBanco();
                bd.Conectar();
                dt = bd.RetDataTable(string.Format("SELECT * FROM usuario u JOIN acesso a on u.id_usuario = a.id_login and u.nome = '" + nome + "'"));
            }
            catch (Exception ex)
            {
                Mensagens.erroBusca(ex);
            }
            finally
            {
                bd = null;
            }

            return dt;
        }

        public DataTable selecionaUsuarioId(int id)
        {
            DataTable dt = new DataTable();

            try
            {
                bd = new AcessoBanco();
                bd.Conectar();
                dt = bd.RetDataTable(string.Format("SELECT * FROM usuario u JOIN acesso a on u.id_usuario = a.id_login and u.id_usuario = '" + id + "'"));
            }
            catch (Exception ex)
            {
                Mensagens.erroBusca(ex);
            }
            finally
            {
                bd = null;
            }

            return dt;
        }
    }
}
