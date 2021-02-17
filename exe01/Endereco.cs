namespace exe01
{
    public class Endereco
    {
        public string Logradouro {get;set;}
        public int Numero {get;set;}
        public string Localidade {get;set;}

        public override string ToString()
        {
            return ("Logradouro: "+Logradouro+"\nNúmero: "+Numero+"\nLocalidade: " + Localidade);
        }
    }
}