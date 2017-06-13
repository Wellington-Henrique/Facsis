using System;
using System.Data;
using System.Windows.Forms;

namespace Facsis.Model.DTO
{
    class VendaDTO
    {
        
        private static int idCliente;
        private static string nomeCliente;
        private int codCliente;
        private int codVendedor;
        private int numPedido;
        private DateTime dataNota;
        private DateTime dataPedido;
        private string status;
        private DataGridView itensPedido;
        private string formaPag;
        private string tipoOp;

        public int CodCliente { get { return codCliente; } set { codCliente = value; } }
        public static int IdCliente { get { return idCliente; } set { idCliente = value; } }
        public static string NomeCliente { get { return nomeCliente; } set { nomeCliente = value; } }
        public int CodVendedor { get { return codVendedor; } set { codVendedor = value; } }
        public int NumPedido { get { return numPedido; } set { numPedido = value; } }
        public DateTime DataNota { get { return dataNota; } set { dataNota = value; } }
        public DateTime DataPedido { get { return dataPedido; } set { dataPedido = value; } }
        public string Status { get { return status; } set { status = value; } }
        public DataGridView ItensPedido { get { return itensPedido; } set { itensPedido = value; } }
        public string FormaPag { get { return formaPag; } set { formaPag = value; } }
        public string TipoOp { get { return tipoOp; } set { tipoOp = value; } }

    }
}
