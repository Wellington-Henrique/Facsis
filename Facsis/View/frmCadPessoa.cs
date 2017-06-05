﻿using System;
using System.Windows.Forms;
using Facsis.Model.DTO;
using Facsis.Model.BLL;

namespace Facsis.View
{
    public partial class frmCadPessoa : Form
    {
        PessoaBLL bll = new PessoaBLL();
        PessoaDTO dto = new PessoaDTO();

        public frmCadPessoa()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {


        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {            
            dto.Nome = txtNome.Text.Trim();            
            dto.Tipo = cbPessoa.Text.Trim();
            dto.Email = txtEmail.Text.Trim().ToLower();
            dto.Telefone = txtTelefone.Text.Trim();
            dto.Endereco = txtRua.Text.Trim();
            dto.NImovel = int.Parse(txtNImovel.Text.Trim());
            dto.Cidade = txtCidade.Text.Trim();
            dto.UF = txtUf.Text;
            dto.CPF_CNPJ = txtCpf_Cnpj.Text;

            if (txtId.Text == "")
            {
                bll.Inserir(dto);
            }
            else
            {
                //bll.Atualizar(dto.Id);
                btnCadastrar.Text = "Cadastrar";
            }
        }
    }
}
