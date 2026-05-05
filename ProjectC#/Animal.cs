using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectC_
{
    public abstract class Animal
    {
        public string nome;    
        public int idade;    
        public string raca;    
        public string cor;    
        //virtual = o método será sobreescrito
        public virtual void emitirSom()
        {
            Console.WriteLine("O animal faz um som");
            
        }

        public virtual void mostrarDados()
        {
            Console.WriteLine($"O animal de nome: {nome}, tem {idade} anos");
            
        }

        public abstract void comer();
    }
}