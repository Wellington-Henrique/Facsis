
namespace Facsis.Model.DTO
{
    class UsuarioDTO
    {

        private int id;
        private string nome;
        private string email;
        private string telefone;
        private string nivel;
        private string login;
        private string senha;

        public int Id { get { return id; } set { id = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Telefone { get { return telefone; } set { telefone = value; } }
        public string Nivel { get { return nivel; } set { nivel = value; } }
        public string Login { get { return login; } set { login = value; } }
        public string Senha { get { return senha; } set { senha = value; } }

    }
}
