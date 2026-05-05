namespace Funções;

class Program
{
    static void Main(string[] args)
    {
        /*
            tipoDeRetorno NomeDaFuncao(parametros)
            {
                comandos da função
            }
        */

        // sem parametros e sem retorno
        // static void MostrarMensagem()
        // {
        //     Console.WriteLine("Olá! Boa Tarde!");
        // }

        // // chamando a função
        // MostrarMensagem();

        // //função com parametro
        // // parametro é o string nome
        // static void Saudacao(string nome)
        // {
        //     Console.WriteLine($"Olá, {nome}!");
        // }

        // Saudacao("Juan");

        // //função com retorno
        // // parametros a,b
        // // retorno é a soma
        // static int Somar(int a, int b)
        // {
        //     //int soma = a + b;
        //     //return soma;
        //     return a+ b;
        // }

        // int resultado = Somar(10, 2);
        // Console.WriteLine(resultado);

        // static void ExibirDobro(int num)
        // {
        //     Console.WriteLine(num * 2);
        // }

        // ExibirDobro(10);

        // Arrays -> armazena valores do mesmo tipo em uma única variável

        // int[] numeros = new int[5];

        // Console.WriteLine(numeros);

        // numeros[0] = 2;
        // numeros[1] = 5;
        // numeros[2] = 8;
        // numeros[3] = 15;
        // numeros[4] = 20;

        // Console.WriteLine(numeros);

        // Console.WriteLine(string.Join(", ", numeros));

        // string[] nomes = {"Juan", "Aline", "Carla"};
        // //percorrendo com for
        // for(int i = 0; i < nomes.Length; i++)
        // {
        //     Console.WriteLine(nomes[i]);
        // }

        // //percorrendo com foreach
        // foreach(string nome in nomes)
        // {
        //     Console.WriteLine(nome);
        // }

        // Função + Array

        // static double CalcularMedia(double[] notas)
        // {
        //     double soma = 0;

        //     // notas = [10, 5, 2, 7]
        //     for(int i = 0; i < notas.Length; i++)
        //     {
        //         soma += notas[i];
        //         // soma = soma + nota[posição]
        //     }

        //     return soma / notas.Length;
        // }

        // double[] notasAluno = {8.0, 7.5, 9.0, 6.5};

        // double media = CalcularMedia(notasAluno);

        // Console.WriteLine($"Média final: {media}");

        //outro exemplo
        // int[] numeros = new int[5];
        // int soma = 0;

        // for(int i = 0; i < numeros.Length; i++)
        // {
        //     Console.WriteLine($"Digite o {i + 1}º número: ");
        //     numeros[i] = int.Parse(Console.ReadLine());

        //     soma += numeros[i];
        // }

        // Console.WriteLine(string.Join(", ", numeros));
        // Console.WriteLine($"A soma dos números é: {soma}");

        //-----------------------------------------------

        // static double CalcularMedia(double[] notas);

        // string[] nomes = {"Juan", "Aline", "Carla"};
        // //percorrendo com for
        // for(int i = 0; i < nomes.Length; i++)
        // {
        //     Console.WriteLine(nomes[i]);
        // }
        // {
        // {
        //     double soma = 0;

        //     // notas = [10, 5, 2, 7]
        //     for(int i = 0; i < notas.Length; i++)
        //     {
        //         soma += notas[i];
        //         // soma = soma + nota[posição]
        //     }

        //     return soma / notas.Length;
        // }

        // double[] notasAluno = {8.0, 7.5, 9.0, 6.5};

        // double media = CalcularMedia(notasAluno);

        // if(media >= 7)
        // {
        //     Console.WriteLine("Sua média foi: " + media + " Você está Aprovado!!!");
        // }
        // else if(media >= 5)
        // {
        //     Console.WriteLine("Sua média foi: " + media + " Você está em Recuperação!!!");
        // }
        // else
        // {
        //     Console.WriteLine("Sua média foi: " + media + " Você está Reprovado!!!");
        // }

        // }

        // static string VerificarSituacao(double nota)
        // {
        //     if(nota >= 7)
        //     {
        //         return "Aprovado";
        //     }
        //     else
        //     {
        //         return "Reprovado";
        //     }
        // }

        // string[] alunos = new string[3];
        // double[] notas = new double[3];
        
        // for(int i = 0; i < alunos.Length; i++)
        // {
        //     Console.WriteLine("Digite o nome do aluno: ");
        //     alunos[i] = Console.ReadLine();

        //     Console.WriteLine("Digite a nota: ");
        //     notas[i] = double.Parse(Console.ReadLine());
        // }

        // for(int i = 0; i < alunos.Length; i++)
        // {
        //     Console.WriteLine($"Aluno: {alunos[i]} - Nota: {notas[i]} - Situação: {VerificarSituacao(notas[i])}");
        // }

        // Funções matmáticas
        // valor absoluto -> se tiver um valor negativo transforma em positivo
        // int valor = Math.Abs(-10);
        // Console.WriteLine(valor);

        //potência
        // double potencia = Math.Pow(2, 3);
        // Console.WriteLine(potencia);

        //raiz quadrada
        // double raiz = Math.Sqrt(25);
        // Console.WriteLine(raiz);

        //arredondamento
        // double num = Math.Round(3.6);
        // Console.WriteLine(num);

        //Random números aleatórios
        // Random random = new Random();
        // int num = random.Next(1, 101);

        // Console.WriteLine(num);

        //Funções para String
        // string texto = "CSharp";
        // int tamanho = texto.Length;

        // Console.WriteLine(tamanho);

        //substituir texto
        // string frase = "Olá mundo";
        // frase = frase.Replace("mundo", "C#");

        // Console.WriteLine(frase);

        // string frase = "Estou aprendendo C#";

        // if(frase.Contains("C#"))
        // {
        //     Console.WriteLine("A frase contém 'C#'");
        // }

        // bool existe = frase.Contains("C#");
        // Console.WriteLine(existe);

        // int[] num = {1, 2, 4, 12, 8};
        // Array.Sort(num); //ordenando valores

        // Console.WriteLine(string.Join(", ", num));

        // //inverter valores
        // Array.Reverse(num);
        // Console.WriteLine(string.Join(", ", num));

        //Simular adicionar valores em array
        // string[] nomes = {Ana, Bruno, Carlos};

        // string novoNome = "Pedro";

        // string novoArray = new string[nomes.Length + 1];

        // for(int i = 0; i < nomes.Length; i++)
        // {
        //     novoArray[i] = nomes[i];
        // }

        // novoArray[novoArray.Length - 1] = novoNome;
        // nomes = novoArray;

        // foreach(string nome in nomes)
        // {
        //     Console.WriteLine(nome);
        // }

        //Adicionando elementos com o List

        // List<string> nomes = new List<string>();

        // nomes.Add("Ana");
        // nomes.Add("Bruno");
        // nomes.Add("Carlos");
        // nomes.Add("Pedro");

        // nomes.Remove("Bruno");

        // foreach (string nome in nomes)
        // {
        //     Console.WriteLine(nome);
        // }

        // // //acessar pela posição    
        // // Console.WriteLine(nomes[0]);

        // //tamanho da lista
        // // Console.WriteLine(nomes.Count);

        // //realizando busca dentro da lista
        // // Console.WriteLine("Digite o nome na busca: ");
        // // string nomeDigitado = Console.ReadLine();

        // // if(nomes.Contains("Ana"))
        // // {
        // //     Console.WriteLine("Nome encontrado!");
        // // }
        // // else
        // //     Console.WriteLine("Nome não encontrado!");

        // //inserindo nome em posição específica
        // nomes.Insert(2, "Paula");

        // //removendo nome em posição específica

        // nomes.RemoveAt(3);

        //  foreach (string nome in nomes)
        // {
        //     Console.WriteLine(nome);
        // }

        // //limpando a lista
        // nomes.Clear();

        // foreach(string nome in nomes)
        // {
        //     Console.WriteLine(nome);
        // }

        //removendo item digitado

        // List<string> produtos = new List<string>();

        // produtos.Add("Mouse");
        // produtos.Add("Teclado");
        // produtos.Add("Monitor");

        // Console.WriteLine("Digite o produto para remover: ");
        // string remover = Console.ReadLine();

        // if(produtos.Contains(remover))
        // {
        //     //vai remover o produto
        //     produtos.Remove(remover);

        //     foreach(string produto in produtos)

        //     {
        //         Console.WriteLine(produto);
        //     }
        // }
        // else
        // {
        //     Console.WriteLine("Produto digitado não exsite na lista!!!!");
        // }


        // List<string> tarefas = new List<string>();
        // int opcao;

        // do
        // {
        //     Console.WriteLine("\n--- Bem vindo(a) ao menu do sistema de tarefa! :) ---");
        //     Console.WriteLine("1 - Adicionar tarefa");
        //     Console.WriteLine("2 - Listar tarefas");
        //     Console.WriteLine("3 - Remover tarefa");
        //     Console.WriteLine("0 - Sair");
        //     Console.Write("Escolha uma opção: ");

        //     if (!int.TryParse(Console.ReadLine(), out opcao))
        //     {
        //         Console.WriteLine("Por favor, digite um número válido.");
        //         continue;
        //     }

        //     switch (opcao)
        //     {
        //         case 1:
        //             Console.WriteLine("Digite a tarefa:");
        //             string novaTarefa = Console.ReadLine();
        //             tarefas.Add(novaTarefa);
        //             Console.WriteLine("Tarefa adicionada!");
        //             break;

        //         case 2:
        //             Console.WriteLine("\n--- Lista de Tarefas ---");
        //             if (tarefas.Count == 0)
        //             {
        //                 Console.WriteLine("A lista está vazia.");
        //             }
        //             else
        //             {
        //                 foreach (string item in tarefas)
        //                 {
        //                     Console.WriteLine($"- {item}");
        //                 }
        //             }
        //             break;

        //         case 3:
        //             Console.WriteLine("Digite o nome exato da tarefa para remover:");
        //             string tarefaRemover = Console.ReadLine();
        //             if (tarefas.Remove(tarefaRemover))
        //                 Console.WriteLine("Tarefa removida com sucesso!");
        //             else
        //                 Console.WriteLine("Tarefa não encontrada.");
        //             break;

        //         case 0:
        //             Console.WriteLine("Saindo......");
        //             Console.WriteLine("Sistema encerrado.");
        //             break;

        //         default:
        //             Console.WriteLine("Opção inválida!");
        //             break;
        //     }
        // } while (opcao != 0);

        //Nível 1 - Atividade  1

        // Console.WriteLine("Digite uma palavra: ");
        // string contar = Console.ReadLine();

        // if(contar.Contains("a"))
        // {
        //     Console.WriteLine(contar);
        // }
        // else
        // {
        //     Console.WriteLine("Não tem a letra 'A' !!!!");
        // }

        


    }
}
