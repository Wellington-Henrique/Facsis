using System;

using Facsis.Model.DTO;
using Facsis.Model.DAL;
using Facsis.Controller.Util;
using System.Data;

namespace Facsis.Controller.BLL
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
                string nome = dto.Nome.Replace("'", "''");
                string cmd = "INSERT INTO cliente(nome, email) VALUES ('" + nome + "','" + dto.Email + "')";

                bd.Conectar();
                bd.ExecutarComandoSql(cmd);
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
                string cmd = string.Format("UPDATE cliente set nome = '{0}', email = '{1}' WHERE id_cliente = {2}", nome, dto.Email, dto.Id);

                bd = new AcessoBanco();
                bd.Conectar();
                bd.ExecutarComandoSql(cmd);
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
                string cmd = string.Format("DELETE FROM cliente WHERE id_cliente = " + id);

                bd.Conectar();
                bd.ExecutarComandoSql(cmd);
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
        public DataTable selecionaCliente(string nome)
        {
            DataTable dt = new DataTable();

            try
            {            
                bd = new AcessoBanco();
                bd.Conectar();
                dt = bd.RetDataTable("SELECT id_cliente, nome, email FROM cliente WHERE nome = " + nome);
            }
            catch (Exception ex)
            {
                Mensagens.erroConexao(ex);
            }
            finally
            {
                bd = null;
            }

            return dt;
        }
    }
}
