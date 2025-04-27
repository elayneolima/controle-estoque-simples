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

        public string GetNome ()
        {
            if (_nome != null && _nome.Length > 1)
            {
                return _nome;
            }
            else
            {
                return "Nome é obrigatório";
            }
            
        }

        public double GetPreco()
        {
            if (_preco != null)
            {
                return _preco;
            }
            else
            {
                Console.WriteLine(mensageiro.MensagemAlerta("Preco é obrigatório!")); 
                return 0; 
            }
        }

        public int GetQuantidade()
        {
            if (_quantidade != null)
            {
                return _quantidade;
            }
            else
            {
                Console.WriteLine(mensageiro.MensagemAlerta("Quantidade é obrigatoria!"));
                return 0;
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
