namespace api_banco_virtual.Models
{
    public class Conta
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public decimal Saldo { get; set; }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public decimal Sacar(decimal valor)
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
                return valor;
            }
            else
            {
                return 0.0m;
            }
        }

        public void Transferir(decimal valor, Conta contaQueRecebeDinheiro)
        {
            contaQueRecebeDinheiro.Saldo += this.Sacar(valor);
        }

    }
}
