using System;
using System.Data;

using Facsis.Controller.Util;

namespace Facsis.Model.DAL
{
    class LoginBLL
    {
        AcessoBanco bd;
        DataTable dt;

        // ==========================================================================================
        // SELECT
        // ==========================================================================================
        public DataTable selecionaDadosUsuario(string login, string senha)
        {
            dt = new DataTable();
            bd = new AcessoBanco();

            try
            {
                bd.Conectar();
                dt = bd.RetDataTable("SELECT id_usuario, nome, nivel, login_usuario FROM usuario u JOIN acesso a on u.id_usuario = a.id_login and a.login_usuario = '" + login + "' and  a.senha = '" + senha + "'");
            }
            catch (Exception)
            {
                Mensagens.BuscaErro();
            }
            finally
            {
                bd = null;
            }

            return dt;
        }
    }
}
