
using System.Data;
using System.Windows.Forms;

using Facsis.Model.DTO;
using Facsis.Model.DAL;
using Facsis.Controller.Util;
using Npgsql;


namespace Facsis.Model.BLL
{
    class ProdutoBLL
    {
        AcessoBanco bd;

        //======================================================
        //  Solicita cadastro no banco
        //======================================================
        public void Inserir(ProdutoDTO dto)
        {
            bd = new AcessoBanco();

            try
            {
                // Insere dados na tabela produto
                string cmd = "INSERT INTO produto(" +
                    "nome, fornecedor, medida, status, ultima_compra, descricao, preco) VALUES ('" +
                    dto.Nome + "','" + dto.Fornecedor + "','" + dto.Medida +"','" + dto.Status + "','" + dto.CompraAtual + "','" + dto.Descricao + "','" + dto.Preco +"') returning id_produto";

                bd.Conectar();

                // Insere dados na tabela login <Motivo: Chave estrangeira FK>
                int id = bd.ExecutarComandoSqlRet(cmd);
                bd.Conectar();
                cmd = "INSERT INTO estoque(id_produto, quantidade, locacao) VALUES ('" + id + "','" + dto.Quantidade + "','" + dto.Locacao + "')";
                bd.ExecutarComandoSql(cmd);

                Mensagens.cadastroInserir();
            }
            catch (NpgsqlException)
            {
                MessageBox.Show("Não foi possível efeturar o cadastro\nVerifique se todos os dados foram digitados corretamente.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                bd = null;
            }
        }

        //======================================================
        //  Solicita atualização do cadastro no banco
        //======================================================
        public void Atualizar(ProdutoDTO dto)
        {
            bd = new AcessoBanco();

            try
            {
                string cmd = string.Format("produto usuario SET nome = '{0}', fornecedor = '{1}', medida = '{2}', status = '{3}', ultima_compra = '{4}' descricao = '{5}', preco = '{6}' WHERE id_produto = '{4}'", dto.Nome, dto.Fornecedor, dto.Medida, dto.Status, dto.CompraAtual, dto.Descricao, dto.Preco, dto.Id);

                bd.Conectar();
                bd.ExecutarComandoSql(cmd);

                bd.Conectar();
                cmd = string.Format("UPDATE estoque SET quantidade = '{0}', locacao = '{1}' WHERE id_produto = '{4}'", dto.Quantidade, dto.Locacao, dto.Id);
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

        //======================================================
        //  Solicita exclusão do cadastro no banco
        //======================================================
        public void Excluir(string id)
        {
            bd = new AcessoBanco();

            try
            {
                string cmd = "DELETE FROM estoque WHERE id_produto = " + id;
                bd.Conectar();
                bd.ExecutarComandoSql(cmd);

                cmd = "DELETE FROM produto WHERE id_produto = " + id;
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

        //======================================================
        //  Seleciona cadastro no banco pelo nome do usuário
        //======================================================
        public DataTable selecionaProduto(string nome)
        {
            DataTable dt = new DataTable();
            bd = new AcessoBanco();

            try
            {
                bd.Conectar();
                dt = bd.RetDataTable("SELECT * FROM produto u JOIN estoque a on u.id_produto = a.id_produto and u.nome = '" + nome + "'");
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

        //======================================================
        //  Seleciona cadastro no banco pelo id do usuário
        //======================================================
        public DataTable selecionaProduto(int id)
        {
            DataTable dt = new DataTable();
            bd = new AcessoBanco();

            try
            {
                bd.Conectar();
                dt = bd.RetDataTable(string.Format("SELECT * FROM produto u JOIN estoque a on u.id_produto = a.id_produto and u.id_produto = '" + id + "'"));
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
