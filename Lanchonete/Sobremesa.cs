using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lanchonete
{
    public class Sobremesa : Produto, IDesconto
    {
        public Sobremesa(string nomeProduto, decimal precoBase) : base(nomeProduto, precoBase)
        {

        }
        public decimal aplicarDesconto()
        {
            return precoBase * 0.1m;
        }
        public override decimal calcularPrecoFinal()
        {
            return precoBase - aplicarDesconto();
        }
        public override void exibirResumoProduto()
        {
            Console.WriteLine("Tipo: Sobremesa");
            base.exibirResumoProduto();
            Console.WriteLine($"Desconto: {aplicarDesconto():f2}");
            Console.WriteLine();
            
        }

    }
}