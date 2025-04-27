using System;
using ControleProduto;
using System.Globalization;



/*

string nome = Console.ReadLine();
double preco = double.Parse(Console.ReadLine());
int quantidade = int.Parse(Console.ReadLine());


Produto p = new Produto(nome, preco, quantidade);
Console.WriteLine(p.GetNome()); 
Console.WriteLine(p.GetPreco());
Console.WriteLine(p.GetQuantidade());

*/
#region Login

Acesso login = new Acesso("Teste", "SEN13");

Console.Write("Informe o usuário: ");
string uAcesso = Console.ReadLine();

Console.Write("Informe a senha: ");
string uChave = Console.ReadLine();


if (!login.ValidarLogin(uAcesso, uChave))
{
    Console.WriteLine("Usuário ou Senha está incorreto, verifique e tente novamente."); 
    return;
}

#endregion

#region entrada dados

Console.WriteLine();

if (login.ValidarLogin(uAcesso, uChave) == true)
{
    Console.WriteLine($"Olá, você está logado com usuário proprietário {uAcesso}");
}


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

