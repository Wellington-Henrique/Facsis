using System;
using System.Windows.Forms;

namespace Facsis.Controller.Util
{
    class Mensagens
    {

        public static void erroConexao(Exception erro)
        {           
            MessageBox.Show("Não foi possível se conectar com o banco: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void erroBusca(Exception erro)
        {
            MessageBox.Show("Nenhum cadastro foi encontrado: " + erro.Message, "Busca de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void cadastroEfetuado()
        {
            MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void cadastroAlterado()
        {
            MessageBox.Show("Cadastro alterado com sucesso!", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void cadastroExcluido()
        {
            MessageBox.Show("Cadastro excluído com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult perguntaExcluir()
        {

            if (MessageBox.Show("Deseja realmente excluir este cadastro?", "Exclusão", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                return DialogResult.Yes;

            return DialogResult.No;
        }

        public static void campoVazio()
        {
            MessageBox.Show("Preencha todos os campos!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void mostraRetorno(string letra)
        { 
            MessageBox.Show("retorno: " + letra);
        }
    }
}
