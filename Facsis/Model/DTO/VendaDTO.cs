using System;
using System.Data;

namespace Facsis.Model.DTO
{
    class VendaDTO
    {
        
        private static int idCliente;
        private static string nomeCliente;
        private int idVendedor;
        private DateTime dataNota;
        private DateTime dataPedido;
        private string status;
        private string formaPagamento;
        private DataTable itensPedido;
        private Double valor;

        public static int IdCliente { get { return idCliente; } set { idCliente = value; } }
        public static string NomeCliente { get { return nomeCliente; } set { nomeCliente = value; } }
        public int IdVendedor { get { return idVendedor; } set { idVendedor = value; } }
        public DateTime DataNota { get { return dataNota; } set { dataNota = value; } }
        public DateTime DataPedido { get { return dataPedido; } set { dataPedido = value; } }
        public string Status { get { return status; } set { status = value; } }
        private string FormaPagamento { get { return formaPagamento; } set { formaPagamento = value; } }
        private DataTable ItensPedido { get { return itensPedido; } set { itensPedido = value; } }
        public double Valor  { get { return valor; } set { valor = value; } }

    }
}
