using Treinamento.CSharp.Application.Interfaces;

namespace Treinamento.CSharp.Application.Services
{
    public class ConsoleApplication : IConsoleApplication
    {
        public char TelaPreLogin()
        {
            Console.WriteLine("#--------------------------#");
            Console.WriteLine("|      Banco da Berger     |");
            Console.WriteLine("#--------------------------#");
            Console.WriteLine("|        1 - Cadastro      |");
            Console.WriteLine("|        2 - Login         |");
            Console.WriteLine("#--------------------------#");

            return Console.ReadKey().KeyChar;
        }

        public char TelaHome()
        {
            Console.WriteLine("#--------------------------#");
            Console.WriteLine("|   O que deseja fazer ?   |");
            Console.WriteLine("#--------------------------#");
            Console.WriteLine("|     1 - Pagar contas     |");
            Console.WriteLine("|   2 - Ver contas pagas   |");
            Console.WriteLine("#--------------------------#");

            return Console.ReadKey().KeyChar;
        }

        public Dictionary<string, string> TelaLogin()
        {
            Console.WriteLine("\n#--------------------------#");
            Console.Write("Digite seu login: ");
            var login = Console.ReadLine();
            Console.WriteLine("#--------------------------#");
            Console.Write("Digite sua senha: ");
            var senha = Console.ReadLine();
            Console.WriteLine();

            return new Dictionary<string, string> 
            { 
                { login, senha } 
            };
        }

        public Dictionary<string, string> TelaCadastro()
        {
            Console.WriteLine("#--------------------------#");
            Console.Write("Digite seu login: ");
            var login = Console.ReadLine();
            Console.WriteLine("#--------------------------#");
            Console.Write("Digite sua senha: ");
            var senha = Console.ReadLine();

            return new Dictionary<string, string>
            {
                { login, senha }
            };
        }
    }
}
