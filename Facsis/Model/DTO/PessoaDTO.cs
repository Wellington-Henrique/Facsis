
namespace Facsis.Model.DTO
{
    class PessoaDTO
    {
        private int id;
        private string nome;
        private string tipo_pessoa;
        private string cpf_cnpj;
        private string email;
        private string telefone;
        private string endereco;        
        private int numero_imovel;
        private string cidade;
        private string uf;
        private string relacao;

        public int Id { get { return id; } set { id = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Tipo { get { return tipo_pessoa; } set { tipo_pessoa = value; } }
        public string CPF_CNPJ { get { return cpf_cnpj; } set { cpf_cnpj = value; } }
        public string Email { get { return email; } set { email = value; } }        
        public string Telefone { get { return telefone; } set { telefone = value; } }
        public string Endereco { get { return endereco; } set { endereco = value; } }
        public int NImovel { get { return numero_imovel; } set { numero_imovel = value; } }
        public string Cidade { get { return cidade; } set { cidade = value; } }
        public string UF { get { return uf; } set { uf = value; } }
        public string Relacao { get { return relacao; } set { relacao = value; } }

    }
}
