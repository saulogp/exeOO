namespace exe01
{
    public class Proprietario
    {
        public string Nome {get;set;}
        public string CPF {get;set;}
        public string DataNasc {get;set;}
        public string DataCompra {get;set;}
        public Veiculo veiculo;
        public Endereco endereco;

        public override string ToString()
        {
            return ("Nome: "+Nome+"\nCPF: "+CPF+"\nData de Nasc: "+DataNasc+"\nData de Compra: "+DataCompra);
        }
    }
}