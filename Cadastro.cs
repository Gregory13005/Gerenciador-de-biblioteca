public class Cadastro
{
    // Dicionário único para armazenar usuários
    private static Dictionary<string, string> users = new Dictionary<string, string>
    {
        { "lucas13@gmail.com", "senha123" },
        { "gregory@positivo.com", "senha456" },
        { "silva@itau.com", "senha789" }
    };

    public void SignUp()
    {
        Console.Clear();
        Console.WriteLine("Insira seu email: ");
        string userEmail = Console.ReadLine(); // Entrada de email do usuário
        Console.WriteLine("Insira sua senha: ");
        string userPassword = Console.ReadLine(); // Entrada de senha do usuário

        // Verifica se o email já existe
        if (users.ContainsKey(userEmail))
        {
            Console.WriteLine("Erro: Usuário já existe."); // Mensagem de erro
            Thread.Sleep(2000); // Pausa para leitura da mensagem
        }
        else
        {
            users.Add(userEmail, userPassword); // Adiciona o novo usuário
            Console.WriteLine("Usuário registrado."); // Confirmação
            Thread.Sleep(2000); // Pausa para leitura da mensagem
        }
    }

    public void LogIn()
    {
        Console.WriteLine("Insira seu email: ");
        string emailInserido = Console.ReadLine(); // Entrada de email para login
        Console.WriteLine("Insira sua senha: ");
        string senhaInserida = Console.ReadLine(); // Entrada de senha para login

        // Verifica se o email e a senha estão corretos
        if (users.ContainsKey(emailInserido) && users[emailInserido] == senhaInserida)
        {
            Console.WriteLine("Acesso permitido."); // Confirmação de acesso
        }
        else
        {
            Console.WriteLine("Email ou senha errada."); // Mensagem de erro
        }
        Thread.Sleep(2000); // Pausa para leitura da mensagem
    }
}