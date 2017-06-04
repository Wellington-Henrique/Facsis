using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facsis.Model.DTO
{
    class LoginDTO
    {
        private static int id;
        private static string nome;
        private static string login;
        private static string nivel;

        public static int Id { get { return id; } set { id = value; } }
        public static string Nome { get { return nome; } set { nome = value; } }
        public static string Login { get { return login; } set { login = value; } }
        public static string Nivel { get { return nivel; } set { nivel = value; } }
    }
}
