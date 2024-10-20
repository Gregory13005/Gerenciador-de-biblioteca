using System;
using System.Collections.Generic;
using System.Threading;

public class Principal
{
    static Cadastro cadastro = new Cadastro();

    static void Main(string[] args)
    {
        Console.WriteLine("Seja bem-vindo ao sistema de gerenciamento GdB!");

        // Loop contínuo para manter o menu acessível
        while (true)
        {
            Console.WriteLine("\nInsira a opção que deseja: \n" +
                              "1. Login\n" +
                              "2. Cadastrar\n" +
                              "3. Sair");

            string inputOpcao = Console.ReadLine();
            int opcao;

            // Validação da entrada do usuário
            if (int.TryParse(inputOpcao, out opcao))
            {
                switch (opcao)
                {
                    case 1:
                        cadastro.LogIn(); // Chama o método de login
                        break;

                    case 2:
                        cadastro.SignUp(); // Chama o método de cadastro
                        break;

                    case 3:
                        Console.WriteLine("Até breve!");
                        Environment.Exit(0); // Sai do programa
                        break;

                    default:
                        Console.WriteLine("Opção inválida."); // Mensagem para opções inválidas
                        break;
                }
            }
            else
            {
                Console.WriteLine("Por favor, insira um número válido."); // Mensagem de erro para entradas não numéricas
            }
        }
    }
}