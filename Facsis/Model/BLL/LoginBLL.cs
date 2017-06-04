using System;
using System.Data;
using Facsis.Controller.Util;

namespace Facsis.Model.DAL
{
    class LoginBLL
    {
        AcessoBanco bd = new AcessoBanco();

        //public int selecionaUsuarioLogin(string login, string senha)
        //{
        //    int id = 0;

        //    try
        //    {                
        //        bd.Conectar();
        //        id = bd.ExecutarComandoSqlRet("SELECT id_login, login_usuario FROM acesso WHERE login_usuario = '" + login + "' and senha = '" + senha + "'");
        //    }
        //    catch (Exception ex)
        //    {
        //        Mensagens.erroBusca(ex);
        //    }
        //    finally
        //    {
        //        bd = null;
        //    }

        //    return id;
        //}

        public DataTable selecionaDadosUsuario(string login, string senha)
        {
            DataTable dt = new DataTable();

            try
            {
                bd.Conectar();


                bd = new AcessoBanco();
                bd.Conectar();
                dt = bd.RetDataTable("SELECT id_usuario, nome, funcao, login_usuario FROM usuario u JOIN acesso a on u.id_usuario = a.id_login and a.login_usuario = '" + login + "' and  a.senha = '" + senha+ "'");
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
