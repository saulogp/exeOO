namespace exe02
{
    public class Cliente
    {
        public string CPF { get; set; }
        public string Name { get; set; }
        public Conta conta;

        public override string ToString()
        {
            return ("Nome: "+Name+"\nCPF: "+CPF);
        }
    }
    
}