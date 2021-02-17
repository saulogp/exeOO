namespace exe02
{
    public class Conta
    {
        public long Agency { get; set; }
        public int Number { get; set; }
        public double Saldo { get; set; } = 0.0;

        public override string ToString()
        {
            return ("Agência: " + Agency + "\nNúmero: " + Number + "\nSaldo: " + Saldo);
        }

        public void Deposito(double value){
            this.Saldo += value;
        }

    }
}