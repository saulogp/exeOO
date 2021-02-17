namespace exe02
{
    public class Conta
    {
        public long Agency { get; set; }
        public int Number { get; set; }
        public double Saldo { get; set; } = 0.0;


        public void Deposito(double value){
            this.Saldo += value;
        }

        public void Saque(double value){
            this.Saldo -= value;
        }

        public void transfere(Conta c1, Conta c2, double value)
        {
            
            
            if ((c1.Saldo > 0) && (value <= c1.Saldo))
            {
                c1.Saque(value);
                c2.Deposito(value);
            }
        }

        public override string ToString()
        {
            return ("Agência: " + Agency + "\nNúmero: " + Number + "\nSaldo: " + Saldo);
        }
    }
}