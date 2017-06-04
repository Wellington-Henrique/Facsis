using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facsis.Controller.Util
{
    class VariaveisGlobais
    {
        private string usuarioAtivo;
        private string login;
        private string nivel;

        public string Nome { get { return usuarioAtivo; } set { usuarioAtivo = value; } }
        public string Login { get { return login; } set { login = value; } }
        public string Nivel { get { return nivel; } set { nivel = value; } }

    }
}
