using System;

using Facsis.Model.DTO;
using Facsis.Model.DAL;
using Facsis.Controller.Util;
using System.Data;
using Npgsql;

namespace Facsis.Model.BLL
{
    class PessoaBLL
    {
        AcessoBanco bd = new AcessoBanco();

        //======================================================
        //  Solicita cadastro no banco
        //======================================================
        public void Inserir(PessoaDTO dto)
        {
            try
            {
                //Insere dados na tabela pessoa
                string nome = dto.Nome.Replace("'", "''");
                string cmd = string.Format("INSERT INTO pessoa(" +
                    "nome, tipo_pessoa, email, telefone, endereco, numero_imovel, cidade, uf, cpf_cnpj)" +
                    "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')",
                    nome, dto.Tipo, dto.Email, dto.Telefone, dto.Endereco, dto.NImovel, dto.Cidade, dto.UF, dto.CPF_CNPJ);

                bd.Conectar();
                bd.ExecutarComandoSqlRet(cmd);

                Mensagens.cadastroEfetuado();
            }
            catch(NpgsqlException ex)
            {
                Mensagens.erroConexao(ex);
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
        public void Atualizar(PessoaDTO dto)
        {
            try
            {
                string nome = dto.Nome.Replace("'", "''");
                string cmd = string.Format("UPDATE pessoa SET " +
                    "nome = '{0}', tipo_pessoa = '{1}', email = '{2}', telefone = '{3}', endereco = '{4}', numero_imovel = '{5}', cidade = '{6}', uf = '{7}', cpf_cnpj = '{8}' WHERE id_pessoa = '{9}'",
                    nome, dto.Tipo, dto.Email, dto.Telefone, dto.Endereco, dto.NImovel, dto.Cidade, dto.UF, dto.CPF_CNPJ, dto.Id);

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

                string cmd = "DELETE FROM pessoa WHERE id_login = " + id;
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
        public DataTable selecionaPessoa(PessoaDTO dto)
        {
            string busca = null;

            if (dto.Id > 0)
                busca = "id_pessoa = '" + dto.Id + "' ";
            if (dto.Nome != "")
            {
                if (dto.Id > 0)
                    busca += "and ";
                busca += "nome = '" + dto.Nome + "' ";
            }
                           
            if (dto.CPF_CNPJ != "")
            {
                if (dto.Id > 0 || dto.Nome != "")
                    busca += "and ";
                busca += "cpf_cnpj = '" + dto.CPF_CNPJ + "'";
            }

            DataTable dt = new DataTable();

            try
            {
                bd = new AcessoBanco();
                bd.Conectar();
                dt = bd.RetDataTable("SELECT * FROM pessoa WHERE " + busca);
            }
            catch (Exception ex)
            {
                Mensagens.erroBusca(ex);
            }
            finally
            {
                busca = null;
                bd = null;
            }

            return dt;
        }
    }
}
