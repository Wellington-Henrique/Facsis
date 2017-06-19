
using System.Windows.Forms;

namespace Facsis.Controller.Util
{
    class Mensagens
    {
        public static DialogResult perguntaExcluir()
        {
            if (MessageBox.Show("Você deseja realmente excluir este cadastro?", "Excluir cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                return DialogResult.Yes;

            return DialogResult.No;
        }

        public static void vendaEfetuada()
        {
            MessageBox.Show("Venda efetuada com sucesso!", "Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void vendaErro()
        {
            MessageBox.Show("Não foi possível efeturar a venda\nVerifique se todos os dados foram digitados corretamente.", "Venda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void cadastroInserir()
        {
            MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void cadastroAlterar()
        {
            MessageBox.Show("Cadastro alterado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void cadastroErroAlterar()
        {
            MessageBox.Show("Não foi possível alterar o cadastro.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void cadastroExcluir()
        {
            MessageBox.Show("O cadastro foi excluído com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void cadastroErroExcluir()
        {
            MessageBox.Show("Não foi possível excluir o cadastro.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void BuscaErro()
        {
            MessageBox.Show("Não foi possível efetuar a consulta.", "Consulta de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void fechaAplicao()
        {

            if (MessageBox.Show("Você tem certeza que deseja sair?",
                "Facsis", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Application.Exit(); //Encerra o sistema
        }

        public static void camposVazios()
        {
            MessageBox.Show("Informe todos os campos!", "Facsis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}

