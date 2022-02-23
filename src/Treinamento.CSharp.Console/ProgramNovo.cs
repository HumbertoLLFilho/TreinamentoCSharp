using Treinamento.CSharp.Application.Interfaces;
using Treinamento.CSharp.Application.Services;

IConsoleApplication console = new ConsoleApplication();

bool login = true;

while (login)
{
    var option = console.TelaPreLogin();

    Console.WriteLine();

    switch (option)
    {
        case '1':
            IniciaCadastro();
            login = false;
            break;
        case '2':
            IniciaLogin();
            login = false;
            break;
        default:
            Console.WriteLine("Por favor digite uma opção valida...");
            break;
    }
}

void IniciaLogin()
{
    Console.WriteLine("Iniciando login");

    var login = console.TelaLogin();
}

void IniciaCadastro()
{
    Console.WriteLine("Iniciando cadastro");

    var cadastro = console.TelaCadastro();
}
