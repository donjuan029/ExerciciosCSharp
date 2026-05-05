namespace ProjectC_;

class Program
{
    static void Main(string[] args)
    {
        // ContaBancaria conta = new ContaBancaria();
        // conta.Sacar(20);
        // conta.MostrarSaldo();

        Cachorro c1 = new Cachorro();
        c1.nome = "caramelo";
        c1.idade = 50;
        c1.raca = "indefinida";
        c1.cor = "caramelo";
        c1.emitirSom();
        c1.mostrarDados();

        Console.WriteLine($"-------------------------");
        

        Gato g1 = new Gato();
        g1.nome = "feijão";
        g1.idade = 5;
        g1.raca = "indefinida";
        g1.cor = "preto";
        g1.emitirSom();
        g1.mostrarDados();

        

        
    }
}
