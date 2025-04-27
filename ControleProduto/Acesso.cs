using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleProduto
{
    internal class Acesso
    {
        private string _usuario;
        private string _senha;

        public Acesso (string nomeUsuario, string senhaUsuario)
        {
            this._usuario = nomeUsuario;
            this._senha = senhaUsuario;
        }

        public bool ValidarLogin()
        {

        }
    }
}
