using Treinamento.CSharp.Application.Interfaces;
using Treinamento.CSharp.Application.Services;

namespace Treinamento.CSharp.Console
{
    internal class ProgamAntigo
    {
        internal void MainAntiga(string[] args)
        {
            IConsoleApplication console = new ConsoleApplication();

            bool login = true;

            while (login)
            {
                console.TelaPreLogin();

                var option = System.Console.ReadKey().KeyChar;

                System.Console.WriteLine();

                switch (option)
                {
                    case '1':
                        IniciaCadastro();
                        return;
                    case '2':
                        IniciaLogin();
                        return;
                    default:
                        System.Console.WriteLine("Por favor digite uma opção valida...");
                        break;
                }
            }

            void IniciaLogin()
            {
                System.Console.WriteLine("Iniciando login");

            }

            void IniciaCadastro()
            {
                System.Console.WriteLine("Iniciando cadastro");
            }
        }
    }
}