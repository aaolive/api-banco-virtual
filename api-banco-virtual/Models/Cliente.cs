namespace api_banco_virtual.Models
{
    public class Cliente : Pessoa
    {
        public int Id { get; set; }

        public Cliente()
        {
        }

        public Cliente(string nome, string sobreNome, string telefone, string email) : base(nome, sobreNome, telefone, email)
        {
        }
    }
}
