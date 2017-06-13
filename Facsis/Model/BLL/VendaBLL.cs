
using System.Data;
using System.Windows.Forms;

using Facsis.Model.DTO;
using Facsis.Model.DAL;
using Facsis.Controller.Util;
using Npgsql;


namespace Facsis.Model.BLL
{
    class VendaBLL
    {
        AcessoBanco bd;

        //======================================================
        //  Solicita registro da venda no banco
        //======================================================
        public void registrar(VendaDTO dto)
        {
            bd = new AcessoBanco();
            ProdutoBLL p_dto = new ProdutoBLL();

            try
            {
                // Insere dados na tabela produto
                string cmd = "INSERT INTO venda(" +
                    "id_usuario, id_pessoa, data_nota, data_pedido, status, forma_pagamento) VALUES ('" +
                    dto.CodVendedor + "','" + dto.CodCliente + "','" + dto.DataNota + "','" + dto.DataPedido + "','" + dto.Status + "','" + dto.FormaPag + "') returning id_venda";

                bd.Conectar();

                // Insere dados na tabela venda < Motivo: Chave estrangeira FK >
                int id = bd.ExecutarComandoSqlRet(cmd);

                // Registra os itens da compra
                for (int i = 0; i < dto.ItensPedido.Rows.Count - 1; i++)
                {
                    bd.Conectar();

                    cmd = "INSERT INTO itens_pedido(id_venda, id_produto, quantidade, vlr_unitario) VALUES ('" +
                            id + "','" +
                            dto.ItensPedido.Rows[i].Cells[0].Value + "','" +
                            dto.ItensPedido.Rows[i].Cells[3].Value + "','" +
                            dto.ItensPedido.Rows[i].Cells[4].Value + "')";

                    bd.ExecutarComandoSql(cmd);

                    // Da baixa no item do estoque
                    p_dto.DarBaixa(dto.ItensPedido.Rows[i].Cells[0].Value.ToString(), dto.ItensPedido.Rows[i].Cells[3].Value.ToString());
                }


                Mensagens.vendaEfetuada();
            }
            catch (NpgsqlException)
            {
                Mensagens.vendaErro();
            }
            finally
            {
                bd = null;
            }
        }

        //======================================================
        //  Carrega o número da última venda
        //======================================================
        public int ultimaVenda()
        {
            bd = new AcessoBanco();
            int id = 0;

            try
            {
                bd.Conectar();
                string cmd = "SELECT id_venda FROM venda ORDER BY id_venda DESC LIMIT 1";
                id = bd.ExecutarComandoSqlRet(cmd);
            }
            catch (NpgsqlException)
            {
                MessageBox.Show("Não foi possível efeturar a venda\nVerifique se todos os dados foram digitados corretamente.", "Venda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return id;
        }

        //======================================================
        //  Solicita atualização do cadastro no banco
        //======================================================
        public void Atualizar(VendaDTO dto)
        {
            //bd = new AcessoBanco();

            //try
            //{
            //    string cmd = string.Format("produto usuario SET nome = '{0}', fornecedor = '{1}', medida = '{2}', status = '{3}', ultima_compra = '{4}' descricao = '{5}', preco = '{6}' WHERE id_produto = '{4}'", dto.Nome, dto.Fornecedor, dto.Medida, dto.Status, dto.CompraAtual, dto.Descricao, dto.Preco, dto.Id);

            //    bd.Conectar();
            //    bd.ExecutarComandoSql(cmd);

            //    bd.Conectar();
            //    cmd = string.Format("UPDATE estoque SET quantidade = '{0}', locacao = '{1}' WHERE id_produto = '{4}'", dto.Quantidade, dto.Locacao, dto.Id);
            //    bd.ExecutarComandoSql(cmd);
            //    Mensagens.cadastroAlterar();
            //}
            //catch (NpgsqlException)
            //{
            //    Mensagens.cadastroErroAlterar();
            //}
            //finally
            //{
            //    bd = null;
            //}
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
