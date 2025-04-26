using System;
using ControleProduto;
using System.Globalization;


/*
//Apenas um teste para tentar acessar a prop. quantidade externamente.

Produto p = new Produto("teste", 90.00, 10);
Console.WriteLine(p._quantidade);
*/

#region entrada dados
Console.Write("Informe o nome do produto: "); 
string nome = Console.ReadLine();

Console.Write("Informe o preço do produto: ");
double preco = double.Parse(Console.ReadLine());

Console.Write("Informe a quantidade do produto: ");
int quantidade = int.Parse(Console.ReadLine());

#endregion

#region instanciacao da classe

Produto p = new Produto(nome, preco, quantidade);

Console.WriteLine(); 
Console.WriteLine(p);
Console.WriteLine();

Console.WriteLine("Informe a quantidade a ser adicionada no estoque: ");
int qtd = int.Parse(Console.ReadLine());
p.AdicionarProduto(qtd);

Console.WriteLine();
Console.WriteLine(p);
Console.WriteLine();

Console.WriteLine("Informe a quantidade a ser removida do estoque: "); 
qtd = int.Parse(Console.ReadLine());
p.RemoverProduto(qtd);

Console.WriteLine();
Console.WriteLine(p);
Console.WriteLine();

#endregion 

