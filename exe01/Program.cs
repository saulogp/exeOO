using System;

namespace exe01
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            Proprietario p = new Proprietario();
            do
            {
                Menu();
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        //cadastro
                        p  = CadastrarProprietario();
                        p.endereco = CadastrarEndereco();
                        p.veiculo = CadastrarVeiculo();
                        break;
                    case 2:
                        Console.WriteLine("Impressão dos dados do Proprietário:");
                        Console.WriteLine(p.ToString());
                        Console.WriteLine("Impressão dos dados do Veiculo:");
                        Console.WriteLine(p.veiculo.ToString());                        
                        break;
                    case 3:
                        Console.WriteLine("Saindo!!!");
                        break;
                    default:
                        Console.WriteLine("Valor informado não é válido!");
                        break;

                }
            } while (op != 3);
        }

        static void Menu()
        {
            Console.Write("Escolha uma opção:\n1- Cadastrar\n2- Imprimir\n3- Sair\n>>>");
        }

        static Proprietario CadastrarProprietario()
        {
            Proprietario p = new Proprietario();
            Console.WriteLine("* Cadastro do Proprietário *");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("CPF: ");
            p.CPF = Console.ReadLine();
            Console.Write("Data de Nasc: ");
            p.DataNasc = Console.ReadLine();
            Console.Write("Data de Compra: ");
            p.DataCompra = Console.ReadLine();
            return p;
        }

        static Endereco CadastrarEndereco()
        {
            Endereco e = new Endereco();
            Console.Write("Logradouro: ");
            e.Logradouro = Console.ReadLine();
            Console.Write("Numero: ");
            e.Numero = int.Parse(Console.ReadLine());
            Console.Write("Localidade: ");
            e.Localidade = Console.ReadLine();
            return e;
        }

        static Veiculo CadastrarVeiculo()
        {
            Veiculo v = new Veiculo();
            Console.WriteLine("* Cadastro do Veiculo *");
            Console.Write("Renavam: ");
            v.Renavam = long.Parse(Console.ReadLine());
            Console.Write("Chassis: ");
            v.Chassis = Console.ReadLine();
            Console.Write("Placa: ");
            v.Placa = Console.ReadLine();
            Console.Write("Marca: ");
            v.Marca = Console.ReadLine();
            Console.Write("Modelo: ");
            v.Modelo = Console.ReadLine();
            Console.Write("Cor: ");
            v.Cor = Console.ReadLine();
            Console.Write("Ano: ");
            v.Ano = int.Parse(Console.ReadLine());
            return v;
        }
    }
}
