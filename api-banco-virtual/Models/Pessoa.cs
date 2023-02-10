namespace api_banco_virtual.Models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public string? SobreNome { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }

        public Pessoa()
        {

        }
        public Pessoa(string nome, string sobreNome, string telefone, string email)
        {
            Nome = nome;
            SobreNome = sobreNome;
            Telefone = telefone;
            Email = email;
        }
    }
}
