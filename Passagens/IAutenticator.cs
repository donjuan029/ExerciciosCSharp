using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passagens
{
    public interface IAutenticator
    {
        string senha = "";
        
        while (senha != "123456")

        {
            Console.WriteLine("Digite a senha: ");
            senha = Console.ReadLine();

            if (senha != "123456")
            {
                Console.WriteLine("Senha incorreta! Tente novamente");
            }
        }

        Console.WriteLine("Acesso permitido!");
        
    }
}