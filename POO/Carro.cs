using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO
{
    public class Carro : Veiculo
    {
        //atributos da classe
        //public string Marca;
        public string Modelo;
        //public int Ano;


        //métodos
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Carrro: {Marca} {Modelo}, Ano: {Ano}");
        }
    }
}