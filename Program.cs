using System;
using System.Collections.Generic;

public class Principal
{
    static void Main()
    {
        string EmailInserido, SenhaInserida;
        int opcao;

         Dictionary<string, string> usuarios = new Dictionary<string, string>
        {
            { "lucas13@gmail.com", "senha123" },
            { "gregory@positivo.com", "senha456" },
            { "silva@itau.com", "senha789" }
        };


        Console.WriteLine("Seja bem-vindo ao sistema de gerenciamento GdB!");

        Console.WriteLine("Insira a opção que deseja: \n" + 
                  "1. Login\n" + 
                  "2. Cadastrar\n" + 
                  "3. Sair");

        string InputOpcao = Console.ReadLine();

       if (int.TryParse(InputOpcao, out opcao))
        
        switch(opcao)
        {
            case 1: 
                    Console.WriteLine("Insira seu email: ");
                    EmailInserido = Console.ReadLine();
                    Console.WriteLine("Insira sua senha: ");
                    SenhaInserida = Console.ReadLine();

                    if(usuarios.ContainsKey(EmailInserido) && usuarios[EmailInserido] == SenhaInserida)
                    {
                        Console.WriteLine("Acesso permitido.");
                    }
                    else
                    { Console.WriteLine("Email ou senha errada.");}
                break;

            case 2: Console.WriteLine("Caso 2");
                break;

            case 3: Console.WriteLine("Até breve!");
                    Environment.Exit(0);
                break;        

                default:
                Console.WriteLine("Opção invalida.");
                break;
        }
      
    }
}
