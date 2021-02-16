using System;

namespace exe02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("* Banco Tio Patinhas *");
            Console.ReadKey();
        }

        static Conta ReadConta(){
            Conta c = new Conta();
            
            Console.WriteLine("Dados da Conta");
            Console.Write("Agência: ");
            c.Agency = long.Parse(Console.ReadLine());
            Console.Write("Número: ");
            c.Number = int.Parse(Console.ReadLine());

            return c;
        }
        static Cliente ReadCliente(){
            Cliente c = new Cliente();
            
            Console.WriteLine("Dados do Cliente");
            Console.Write("Nome: ");
            c.Name = Console.ReadLine();
            Console.Write("CPF: ");
            c.CPF = Console.ReadLine();

            return c;
        }
    }
}
