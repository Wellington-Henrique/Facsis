using System;

namespace Facsis.Model.DTO
{
    class ProdutoDTO
    {
        private int id;
        private string nome;
        private string fornecedor;
        private string medida;
        private string status;
        private string descricao;
        private double preco;
        private int quantidade;
        private string locacao;
        private DateTime ultimaCompra;
        private DateTime compraAtual;

        public int Id { get { return id; } set { id = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Fornecedor { get { return fornecedor; } set { fornecedor = value; } }
        public string Medida { get { return medida; } set { medida = value; } }
        public string Status { get { return status; } set { status = value; } }
        public string Descricao { get { return descricao; } set { descricao = value; } }
        public double Preco { get { return preco; } set { preco = value; } }
        public int Quantidade { get { return quantidade; } set { quantidade = value; } }
        public string Locacao { get { return locacao; } set { locacao = value; } }
        public DateTime UltimaCompra { get { return ultimaCompra; } set { ultimaCompra = value; } }
        public DateTime CompraAtual { get { return compraAtual; } set { compraAtual = value; } }
    }
}
