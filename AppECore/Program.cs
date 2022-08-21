using System;
using cadastro;
class Programa
{
    static void Main(string[] args)
    {
        var pessoas = new List<Pessoa>();
        bool continua = true;
        Console.WriteLine("Seja bem vindo ao Cadastro E-Core!");
        while (continua)
        {
            Console.WriteLine("Selecione a operação que deseja realizar:");
            Console.WriteLine("1 - Cadastrar nova pessoa");
            Console.WriteLine("2 - Consultar lista de pessoas cadastradas");
            Console.WriteLine("3 - Sair");
            try
            {
                int opcao = Int16.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        pessoas.Add(CadastrarPessoa());
                        break;
                    case 2:
                        Console.WriteLine("Selecione a ordenação desejada: ");
                        Console.WriteLine("1 - Alfabética");
                        Console.WriteLine("2 - Por idade");
                        int opcaoOrdenacao = Int16.Parse(Console.ReadLine());
                        ListarPessoas(pessoas, opcaoOrdenacao);
                        break;
                    case 3:
                        continua = false;
                        break;
                    default:
                        Console.WriteLine("Selecione uma opção válida!");
                        break;
                }
                Console.Clear();
            }
            catch (Exception)
            {
                Console.WriteLine("Valor Inválido!");
            }
            
        }
        
    }
    private static Pessoa CadastrarPessoa()
    {
        Console.WriteLine("Digite o nome da pessoa a ser cadastrada:");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite a idade da pessoa a ser cadastrada:");
        int idade = Int16.Parse(Console.ReadLine());
        return new Pessoa(nome, idade);
    }
    private static void ListarPessoas(List<Pessoa>pessoas, int ordenar)
    {
        if (pessoas.Count == 0)
        {
            Console.WriteLine("Nenhuma pessoa cadastrada.");
        }
        else if (ordenar == 1)
        {
            pessoas.OrderBy(pessoa => pessoa.nome).ToList().ForEach(pessoa =>
                pessoa.Print()
                );
        }
        else if (ordenar == 2)
        {
            pessoas.OrderBy(pessoa => pessoa.idade).ToList().ForEach(pessoa =>
                pessoa.Print()
            );
        }
        else 
        {
            Console.WriteLine("Selecione uma opção válida!");
        }
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadLine();
    }
}   