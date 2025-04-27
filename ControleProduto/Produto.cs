using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization; 

namespace ControleProduto
{
    internal class Produto
    {
        private Mensageiro mensageiro = new Mensageiro(); 

        private string _nome;
        private double _preco;
        private int _quantidade; 


        public Produto (string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }


        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        public double ValorTotalEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProduto(int qte)
        {
            _quantidade += qte; 
        }

        public void RemoverProduto (int qte)
        {
            _quantidade -= qte;
        }

        public override string ToString()
        {
            return "Produto: "
                   + _nome
                   + "\n"
                   + "Valor: R$ "
                   + _preco
                   + "\n"
                   + "Quantidade: "
                   + _quantidade
                   + "\n"
                   + "Valor Total Em Estoque: R$ "
                   + ValorTotalEstoque().ToString("f2", CultureInfo.InvariantCulture);


        }
    }
}
