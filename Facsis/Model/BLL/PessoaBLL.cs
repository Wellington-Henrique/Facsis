
using System;
using System.Data;
using System.Windows.Forms;

using Facsis.Model.DTO;
using Facsis.Model.DAL;
using Facsis.Controller.Util;
using Npgsql;


namespace Facsis.Model.BLL
{
    class PessoaBLL
    {
        AcessoBanco bd;

        //======================================================
        //  Solicita cadastro no banco
        //======================================================
        public void Inserir(PessoaDTO dto)
        {
            bd = new AcessoBanco();

            try
            {
                //Insere dados na tabela pessoa
                string nome = dto.Nome.Replace("'", "''");
                string cmd = string.Format("INSERT INTO pessoa(" +
                    "nome, tipo_pessoa, email, telefone, endereco, numero_imovel, cidade, uf, cpf_cnpj, relacao)" +
                    "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')",
                    nome, dto.Tipo, dto.Email, dto.Telefone, dto.Endereco, dto.NImovel, dto.Cidade, dto.UF, dto.CPF_CNPJ, dto.Relacao);

                bd.Conectar();
                bd.ExecutarComandoSqlRet(cmd);

                Mensagens.cadastroInserir();
            }
            catch (NpgsqlException)
            {
                MessageBox.Show("Não foi possível efeturar o cadastro\nVerifique se todos os dados foram digitados corretamente ou se o CPF/CNJP já está cadastrado.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            bd = new AcessoBanco();

            try
            {
                string nome = dto.Nome.Replace("'", "''");
                string cmd = string.Format("UPDATE pessoa SET " +
                    "nome = '{0}', tipo_pessoa = '{1}', email = '{2}', telefone = '{3}', endereco = '{4}', numero_imovel = '{5}', cidade = '{6}', uf = '{7}', cpf_cnpj = '{8}' WHERE id_pessoa = '{9}'",
                    nome, dto.Tipo, dto.Email, dto.Telefone, dto.Endereco, dto.NImovel, dto.Cidade, dto.UF, dto.CPF_CNPJ, dto.Id);


                bd.Conectar();
                bd.ExecutarComandoSql(cmd);

            }
            catch (Exception)
            {
                Mensagens.cadastroErroAlterar();
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

            bd = new AcessoBanco();

            try
            {
                string cmd = "DELETE FROM pessoa WHERE id_pessoa = " + id;
                bd.Conectar();
                bd.ExecutarComandoSql(cmd);
                Mensagens.cadastroExcluir();
            }
            catch (Exception)
            {
                Mensagens.cadastroErroExcluir();
            }
            finally
            {
                bd = null;
            }
        }

        //======================================================
        //  Seleciona cadastro no banco pelo  e código, nome e cpf/cnp da pessoa
        //======================================================
        public DataTable selecionaPessoa(PessoaDTO dto, string relacao)
        {
            DataTable dt = new DataTable();
            bd = new AcessoBanco();

            try
            {
                bd.Conectar();
                dt = bd.RetDataTable("SELECT * FROM pessoa WHERE id_pessoa = '" + dto.Id  + "' AND nome = '" + dto.Nome + "'AND cpf_cnpj = '" + dto.CPF_CNPJ + "' AND relacao = 'CLIENTE'");              
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

        public DataTable selecionaPessoa(string nome, string relacao)
        {
            DataTable dt = new DataTable();
            bd = new AcessoBanco();

            try
            {
                bd.Conectar();
                dt = bd.RetDataTable("SELECT * FROM pessoa WHERE nome LIKE ALL(string_to_array('%' || regexp_replace('" + nome + "', '\\s+', '% %', 'g') || '%', ' ')) AND relacao = '" + relacao + "'");
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
