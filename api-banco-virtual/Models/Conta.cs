namespace api_banco_virtual.Models
{
    public abstract class Conta
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public decimal Saldo { get; set; }

        public virtual void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public virtual string Sacar(decimal valor)
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
                return $"O saque foi feito. Valor: {valor}";
            }
            else
            {
                return $"Saque não realizado.";
            }
        }

        public virtual string Transferir(decimal valor, Conta contaDeDestino)
        {
            if (valor > 0 && valor <= this.Saldo)
            {
                // subtrai o valor do saldo e envia a conta de destino
                this.Saldo -= valor;
                contaDeDestino.Saldo += valor;

                return "Transferência realizada com sucesso.";
            }

            return "Transferência não foi realizada.";
        }

    }
}
