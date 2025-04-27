using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleProduto
{
    internal class Mensageiro
    {
        public string MensagemSucesso(string mensagem)
        {
            return $"Sucesso{mensagem}"; 
        }
        public string MensagemErro(string mensagem)
        {
            return $"Erro: {mensagem}";
        }
        public string MensagemAlerta(string mensagem)
        {
            return $"Alerta: {mensagem}";
        }
    }
}
