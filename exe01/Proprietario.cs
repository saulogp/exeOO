namespace exe01
{
    public class Proprietario
    {
        public string Nome {get;set;}
        public string CPF {get;set;}
        public string Endereco {get;set;}
        public string DataNasc {get;set;}
        public string DataCompra {get;set;}
        public Veiculo veiculo;

        public override string ToString()
        {
            return ("Nome: "+Nome+"\nCPF: "+CPF+"\nEndereço: "+Endereco+"\nData de Nasc: "+DataNasc+"\nData de Compra: "+DataCompra);
        }
    }
}