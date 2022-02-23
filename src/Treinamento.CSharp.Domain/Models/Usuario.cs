namespace Treinamento.CSharp.Domain.Models
{
    public class Usuario
    {
        public Guid ID { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public double Dinheiro { get; set; }
        public DateTime Criado { get; set; }
        public DateTime Atualizado { get; set; }
        public bool Deleteado { get; set; }

        public void AdicionarDinheiro(double dinheiro)
        {
            
        }

        public void SacarDinheiro(float dinheiro)
        {
            
        }
    }
}
