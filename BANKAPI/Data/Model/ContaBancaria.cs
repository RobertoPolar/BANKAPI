namespace BANKAPI.Data.Model
{
    public class ContaBancaria
    {
        public double Saldo { get; set; }
        public DateTime DataAbertura { get; set; }

        public string RetornaDataAberturaFormatada()
        {
            return this.DataAbertura.ToString("yyyy/MM/dd");
        }

        public void Depositar(double saldo)
        {
            this.Saldo += saldo;
        }

        public string RetornaSaldoFormatado()
        {
            return string.Format("R$ {0:C}", this.Saldo);
        }

        public void Sacar(double monto)
        {
            if (monto < this.Saldo)
                this.Saldo -= monto;
        }
    }
}
