namespace Lanchonete;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Produto> pedido = new List<Produto>();

        pedido.Add(new Lanche("X-Burger", 26.00m));
        pedido.Add(new Bebida("RedBull", 15.00m));
        pedido.Add(new Sobremesa("Sundae", 20.00m));

        Console.WriteLine($"============RESUMO DO PRODUTO==============");

        decimal total = 0;

        foreach (Produto produto in pedido)
        {
            produto.exibirResumoProduto();
            total += produto.calcularPrecoFinal();
        }

        Console.WriteLine($"Total do pedido: R$ {total:f2}");
        
        
    }
}
