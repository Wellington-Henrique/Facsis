
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

        // ==========================================================================================
        // SELECT, INSERT, UPDATE, DELETE
        // ==========================================================================================
        public void Inserir(ProdutoDTO dto)
        {
            bd = new AcessoBanco();

            try
            {
                // Insere dados na tabela produto
                string cmd = "INSERT INTO produto(" +
                    "nome, fornecedor, medida, status, ultima_compra, descricao, preco) VALUES ('" +
                    dto.Nome + "','" + dto.Fornecedor + "','" + dto.Medida + "','" + dto.Status + "','" + dto.CompraAtual + "','" + dto.Descricao + "','" + dto.Preco.ToString().Replace(",", ".") + "') returning id_produto";

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

        public void DarBaixa(string id, string quantidade)
        {
            bd = new AcessoBanco();

            try
            {
                bd.Conectar();
                string cmd = string.Format("UPDATE estoque SET quantidade = quantidade - '{0}' WHERE id_produto = '{1}'", quantidade, id);
                bd.ExecutarComandoSql(cmd);
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

        public void Atualizar(ProdutoDTO dto)
        {
            bd = new AcessoBanco();

            try
            {
                string cmd = string.Format("UPDATE produto SET nome = '{0}', fornecedor = '{1}', medida = '{2}', status = '{3}', ultima_compra = '{4}', descricao = '{5}', preco = '{6}' WHERE id_produto = '{7}'", dto.Nome, dto.Fornecedor, dto.Medida, dto.Status, dto.CompraAtual, dto.Descricao, dto.Preco.ToString().Replace(",", "."), dto.Id);

                bd.Conectar();
                bd.ExecutarComandoSql(cmd);

                bd.Conectar();
                cmd = string.Format("UPDATE estoque SET quantidade = quantidade + '{0}', locacao = '{1}' WHERE id_produto = '{2}'", dto.Quantidade, dto.Locacao, dto.Id);
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

        public DataTable selecionaProduto(string nome, string tipoConsulta)
        {
            DataTable dt = new DataTable();
            bd = new AcessoBanco();

            try
            {
                string cmd = "SELECT * FROM produto p JOIN estoque e on p.id_produto = e.id_produto and p.nome = '" + nome + "'";

                if (tipoConsulta == "Venda")
                    cmd += " and p.status = 'ATIVO'";

                bd.Conectar();
                dt = bd.RetDataTable(cmd);
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

        public DataTable selecionaProduto(int id, string tipoConsulta)
        {
            DataTable dt = new DataTable();
            bd = new AcessoBanco();

            try
            {
                string cmd = "SELECT * FROM produto p JOIN estoque e on p.id_produto = e.id_produto and p.id_produto = '" + id + "'";

                if (tipoConsulta == "Venda")
                    cmd += " and p.status = 'ATIVO'";

                bd.Conectar();
                dt = bd.RetDataTable(cmd);
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
