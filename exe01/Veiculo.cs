namespace exe01
{
    public class Veiculo
    {
        public long Renavam { get; set; }
        public string Chassis { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public int Ano { get; set; }

        public override string ToString()
        {
            return ("Renavam: " + Renavam + "\nChassis: " + Chassis + "\nPlaca: " + Placa + "\nMarca: " + Marca + "\nModelo: " + Modelo + "\nCor: " + Cor + "\nAno: " + Ano);
        }
    }
}