
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
            ProdutoBLL p_bll = new ProdutoBLL();

            try
            {
                //Insere dados na tabela venda
                string cmd = "INSERT INTO venda(id_usuario, id_pessoa, data_nota, data_pedido, status, forma_pagamento, valor_total)" +
                     "VALUES ('" + dto.CodVendedor + "','" + dto.CodCliente + "','" + dto.DataNota + "','" + dto.DataPedido + "','" + dto.Status + "','" + dto.FormaPag + "','" + dto.Total.ToString().Replace(",", ".") + "') returning id_venda";

                bd.Conectar();

                // Insere dados na tabela venda < Motivo: Chave estrangeira FK >
                int id = bd.ExecutarComandoSqlRet(cmd);

                // Registra os itens da compra
                for (int i = 0; i < dto.ItensPedido.Rows.Count - 1; i++)
                {
                    bd.Conectar();

                    cmd = string.Format("INSERT INTO itens_pedido(id_venda, id_produto, quantidade, vlr_unitario) VALUES ('{0}', '{1}', '{2}', '{3}')",
                            id,
                            dto.ItensPedido.Rows[i].Cells[0].Value,
                            dto.ItensPedido.Rows[i].Cells[4].Value,
                            dto.ItensPedido.Rows[i].Cells[5].Value.ToString().Replace(",", "."));

                    bd.ExecutarComandoSql(cmd);


                    // Da baixa no item do estoque
                    if (dto.Status == "Faturada")
                        p_bll.DarBaixa(dto.ItensPedido.Rows[i].Cells[0].Value.ToString(), dto.ItensPedido.Rows[i].Cells[4].Value.ToString());
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
            bd = new AcessoBanco();
            ProdutoBLL p_bll = new ProdutoBLL();

            try
            {
                //string cmd = string.Format("UPDATE venda SET id_usuario = '{0}', id_pessoa = '{1}', data_nota = '{2}', data_pedido = '{3}', status = '{4}', forma_pagamento = '{5}', valor_total = '{6}' WHERE id_venda = '{7}'" +
                //                           dto.CodVendedor, dto.CodCliente, dto.DataNota, dto.DataPedido, dto.Status, dto.FormaPag, dto.Total.ToString().Replace(",", "."), dto.NumPedido);

                string cmd = "UPDATE venda SET id_usuario = '" + dto.CodVendedor + "', " +
                                              "id_pessoa = '" + dto.CodCliente + "', " +
                                              "data_nota = '" + dto.DataNota + "', " +
                                              "data_pedido = '" + dto.DataPedido + "', " + 
                                              "status = '" + dto.Status + "', " +
                                              "forma_pagamento = '" + dto.FormaPag + "', " +
                                              "valor_total = '" + dto.Total.ToString().Replace(",", ".") + "' " +
                                              "WHERE id_venda = '" + dto.NumPedido + "'";

                bd.Conectar();
                bd.ExecutarComandoSql(cmd);

                // Registra os itens da compra
                for (int i = 0; i < dto.ItensPedido.Rows.Count - 1; i++)
                {
                    bd.Conectar();
                    bd.ExecutarComandoSql(cmd);
               
                    // Da baixa no item do estoque
                    if (dto.Status == "Faturada")
                        p_bll.DarBaixa(dto.ItensPedido.Rows[i].Cells[0].Value.ToString(), dto.ItensPedido.Rows[i].Cells[4].Value.ToString());
                }
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
        //  Seleciona cadastro no banco pelo status
        //======================================================
        public DataTable selecionaVenda(string status)
        {
            DataTable dt = new DataTable();
            bd = new AcessoBanco();

            try
            {
                bd.Conectar();
                dt = bd.RetDataTable("SELECT * FROM venda WHERE status = '" + status + "'");
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

        //public DataTable selecionaItensVendaPendente(string id)
        //{
        //    DataTable dt = new DataTable();
        //    bd = new AcessoBanco();

        //    try
        //    {
        //        bd.Conectar();
        //        dt = bd.RetDataTable("SELECT * FROM itens_pedido WHERE id_venda = '" + id + "'");
        //    }
        //    catch (NpgsqlException)
        //    {
        //        MessageBox.Show("Não foi possível efetuar a consulta de cadastros.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //    finally
        //    {
        //        bd = null;
        //    }

        //    return dt;
        //}

        public DataTable selecionaItensVendaPendente(string id)
        {
            DataTable dt = new DataTable();
            bd = new AcessoBanco();

            try
            {
                bd.Conectar();
                dt = bd.RetDataTable("SELECT v.id_venda, id_usuario, c.id_pessoa, c.nome as nome_pessoa, data_nota, data_pedido, v.status, forma_pagamento, valor_total, i.id_produto, p.nome as nome_produto, p.descricao, p.medida, quantidade, vlr_unitario FROM venda v " +
                                     "JOIN itens_pedido i ON v.id_venda = i.id_venda AND v.id_venda = '" + id + "'" +
                                     "JOIN pessoa c ON v.id_pessoa = c.id_pessoa " +
                                     "JOIN produto p ON i.id_produto = p.id_produto");
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
