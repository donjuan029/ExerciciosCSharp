namespace Repetição;

class Program
{
    static void Main(string[] args)
    {
        // foreach -> usado para percorrer listas

        //Exemplo do FOR

        //1°: int 1 = 1     -> inicializador, valor inicial
        //2°: i <= 5        -> condição, se for verdadeiro, continua executando
        //3º: i++           -> iterador, acrescenta um valor a mais dentro do i
        //                                  (i = i + 1)

        // for(int i = 1; i <= 10; i++)
        // {
        //     Console.WriteLine(i);
        // }

        // int soma = 0;

        // for(int i = 1; i <= 10; i++)
        // {
        //     soma = soma + 1;
        //     //soma += 1;

        //     Console.WriteLine("Soma Atual: " + soma);
        // }

        // Console.WriteLine("Soma Total: " + soma);

        //Exemplo WHILE

        // int contador = 1;

        // while(contador <= 5)
        // {
        //     Console.WriteLine(contador);
        //     //contador = contador + 1
        //     contador++;
        // }

        // Console.WriteLine("Contador Final: " + contador);

        // int num = 0;

        // while(num <= 0)
        // {
        //     Console.WriteLine("Digite um número maior que zero: ");
        //     num = int.Parse(Console.ReadLine());
        // }

        // Console.WriteLine("Número válido: " + num);

        //Exemplo do/while
        // int num = 0;

        // do
        // {
        //     Console.WriteLine("Digite um número maior que zero: ");
        //     num = int.Parse(Console.ReadLine());
        // }
        // while(num <= 0);

        // Console.WriteLine("Número válido: " + num);

        //menu

        // int opcao;

        // do
        // {
        //     Console.WriteLine("1 - Continuar");
        //     Console.WriteLine("2 - Sair");
        //     opcao = int.Parse(Console.ReadLine());
        // }while(opcao != 2);

        // Console.WriteLine("Programa encerrado");

        //Exemplo FOREACH

        // string[] nomes = {"Ana", "Carlos", "Maria"};

        // foreach(string nome in nomes)
        // {
        //     Console.WriteLine(nome);
        // }

        // int[] numeros = {2, 4, 5, 8};
        // int soma = 0;

        // foreach(int numero in numeros)
        // {
        //     soma += numero;
        //     // somo = soma + numero;
        // }

        // Console.WriteLine("Soma: " + soma);

        //Nível Fácil 1

        // int soma = 0;

        // for(int i = 1; i <= 10; i++)
        // {
        //     soma = soma + 1;
        //     //soma += 1;

        //     Console.WriteLine("Soma: " + soma);
        // }

        //Nível Fácil 2

        // int sub = 11;

        // for(int i = 11; i >= 1; i--)
        // {
        //     sub = sub - 1;
        //     //

        //     Console.WriteLine("Sub: " + sub);
        // }

        //Nível Fácil 3

        // Console.Write("Digite um número: ");
        // int num = int.Parse(Console.ReadLine());

        // Console.WriteLine("Tabuada do número: " + num);

        // for (int i = 1; i <= 10; i++)
        // {
        //     int resultado = num * i;
        //     Console.WriteLine(resultado);
        // }

        //Nível Fácil 4

        // int contador = 1;

        // while(contador <= 5)
        // {
        //     Console.WriteLine(contador);
        //     //contador = contador + 1
        //     contador++;
        // }

        //Nível Fácil 5

        
        // int soma = 0;

        // for (int i = 1; i <= 5; i++)
        // {
        //     soma += i;
        // }

        // Console.WriteLine(soma);

        //Nível Médio 1

        // int soma = 0;

        // for (int i = 1; i <= 5; i++)
        // {
        //     Console.Write($"Digite o {i}º número: ");
        //     int num = int.Parse(Console.ReadLine());
        //     soma += num;
        // }

        // Console.WriteLine("O valor total somado é: " + soma);
    
        //Nível Médio 2

        // for (int i = 1; i <= 20; i++)
        // {
        //     if (i % 2 == 0)
        //     {

        //         Console.WriteLine("Contagem dos pares: " + i);

        //     }

        // }

        //Nível Médio 3

        // string senha = "";
        
        // while (senha != "1234")

        // {
        //     Console.WriteLine("Digite a senha: ");
        //     senha = Console.ReadLine();

        //     if (senha != "1234")
        //     {
        //         Console.WriteLine("Senha incorreta! Tente novamente");
        //     }
        // }

        // Console.WriteLine("Acesso permitido!");

        //Nível Médio 4

        // int opcao;

        // do
        // {
        //     Console.WriteLine("1 - Mostrar mensagem");
        //     Console.WriteLine("2 - Sair");
        //     opcao = int.Parse(Console.ReadLine());
        // }while(opcao != 2);

        // Console.WriteLine("Programa encerrado");

        //Nível Médio 5

        // double soma = 0;
        // int media = 4;

        // for (int i = 1; i <= 4; i++)
        // {
        //     Console.Write($"Digite o {i}º número: ");
        //     double num = double.Parse(Console.ReadLine());
        //     soma += num;
        // }

        // double mediaFinal = soma / media;
        // Console.WriteLine("Sua média é: " + mediaFinal);

        //Nível Avançado 1

        
    }
}
