namespace Treinamento.CSharp.Application.Interfaces
{
    public interface IConsoleApplication
    {
        char TelaPreLogin();
        char TelaHome();
        Dictionary<string, string> TelaLogin();
        Dictionary<string, string> TelaCadastro();
    }
}
