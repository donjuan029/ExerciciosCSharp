using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectC_
{
    public class ContaBancaria
    {
        private decimal saldo = 100;

        public void Sacar(decimal valor)
        {
            if(valor <= saldo)
            {
                // decimal resultado = saldo - valor;
                // saldo = resultado;
                saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!! :(");
            }
        }

        public void MostrarSaldo()
        {
            Console.WriteLine($"Saldo: {saldo}");
            
        }


    }
}