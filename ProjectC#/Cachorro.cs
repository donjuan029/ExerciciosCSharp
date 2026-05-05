using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectC_
{
    public class Cachorro : Animal
    {
        public override void comer()
        {
            Console.WriteLine($"Comeu biscoito!!!");
            
        }
        
        public override void emitirSom()
        {
            Console.WriteLine("AU AU !!!!!!!");
            
        }
    }
}