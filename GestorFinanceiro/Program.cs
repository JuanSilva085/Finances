using System;
using GestorFinanceiro.Models;
using GestorFinanceiro.Repositorios;

class Program
{
    static void Main()
    {
        RepositorioTransacoes repositorio = new();

        while (true) 
        {
            Console.WriteLine("===== Gestor Financeiro =====");
            Console.WriteLine("1 - Adicionar Transação");
            Console.WriteLine("2 - Listar Transações");
            Console.WriteLine("3 - Consultar saldo disponível");
            Console.WriteLine("0- Sair");
            Console.Write("Escolha uma opção:");

            string option = Console.ReadLine();

            switch (option) 
            {
                case "1":
                    AddTransition(repositorio);
                    break;

                case "2":
                    ListTransitions(repositorio);
                    break;
                
                case "3":
                    Console.WriteLine($"Seu saldo atual é: {repositorio.CalcularSaldo()}");
                    Console.ReadKey();
                    break;

                case "0":
                    return;
                
                default:
                    Console.WriteLine("Opção inválida");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void AddTransition(RepositorioTransacoes repo)
    {
        Console.Write("Descrição: ");
        string descricao = Console.ReadLine();

        Console.Write("Valor: ");
        decimal valor = decimal.Parse(Console.ReadLine());

        Console.Write("Categoria: (ex: Casa, mercado) ");
        string categoria = Console.ReadLine();

        Console.Write("Tipo: (Entradas e saídas)");
        string tipo = Console.ReadLine();

        repo.AddTransition(new Transacao
        {
            Descricao = descricao,
            Valor = valor,
            Categoria = categoria,
            Tipo = tipo
        });

        Console.Write("Transação adicionada com sucesso!");
        Console.ReadKey();
    }

    static void ListTransitions(RepositorioTransacoes repo)
    {
        var transacoes = repo.ListTransitions();

        if(transacoes.Count == 0)
        {
            Console.WriteLine("Nenhuma transação registrada.");
        }
        else
        {
            foreach(var transacao in transacoes)
            {
                Console.WriteLine(transacao);
            }
        }
        Console.ReadKey();
    }
}