﻿using System;

namespace exe02
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente[] clientes = new Cliente[10];
            int op, i=0, numero;
            long agencia;
            double value;
            Console.WriteLine("* Banco Tio Patinhas *");
            do{
                Menu();
                op = int.Parse(Console.ReadLine());
                switch(op){
                    case 1:
                        Console.WriteLine("Cadastrar Cliente/Conta");
                        clientes[i] = ReadCliente();
                        clientes[i].endereco = ReadEndereco();
                        clientes[i].conta = ReadConta();
                        i++;
                        break;
                    case 2:
                        Console.WriteLine("Impressão Geral");
                        for(int k=0; k<clientes.Length;k++){
                            if(clientes[k] ==null) break;
                            Console.WriteLine("--------------------");
                            Console.WriteLine(clientes[k].ToString());
                            Console.WriteLine(clientes[k].endereco.ToString());
                            Console.WriteLine(clientes[k].conta.ToString());
                            Console.WriteLine("--------------------");
                        }
                        break;
                    case 3:
                        //depósito
                        Console.WriteLine("Depósito");
                        Console.Write("Informe a Agência: ");
                        agencia = long.Parse(Console.ReadLine());
                        Console.Write("Informe o Número: ");
                        numero = int.Parse(Console.ReadLine());
                        for(int k=0; k<clientes.Length;k++){
                            if(clientes[k] ==null) {
                                Console.WriteLine("Conta desconhecida!");
                                break;
                            }
                            if((clientes[k].conta.Agency == agencia) && (clientes[k].conta.Number == numero)){
                                Console.Write("Valor do depósito: ");
                                value = double.Parse(Console.ReadLine());
                                clientes[k].conta.Deposito(value);
                                break;
                            }
                        }
                        break;
                    case 4:
                        //saque
                        Console.WriteLine("Saque");
                        Console.Write("Informe a Agência: ");
                        agencia = long.Parse(Console.ReadLine());
                        Console.Write("Informe o Número: ");
                        numero = int.Parse(Console.ReadLine());
                        for(int k=0; k<clientes.Length;k++){
                            if(clientes[k] ==null) {
                                Console.WriteLine("Conta desconhecida!");
                                break;
                            }
                            if((clientes[k].conta.Agency == agencia) && (clientes[k].conta.Number == numero)){
                                Console.Write("Valor do saque: ");
                                value = double.Parse(Console.ReadLine());
                                if((clientes[k].conta.Saldo > 0) && (value <= clientes[k].conta.Saldo)){
                                    clientes[k].conta.Saque(value);
                                    break;
                                }else{
                                    Console.WriteLine("Valor indisponivél para saque!");
                                }
                                break;
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("Saldo");
                        Console.Write("Informe a Agência: ");
                        agencia = long.Parse(Console.ReadLine());
                        Console.Write("Informe o Número: ");
                        numero = int.Parse(Console.ReadLine());
                        for(int k=0; k<clientes.Length;k++){
                            if(clientes[k] ==null) {
                                Console.WriteLine("Conta desconhecida!");
                                break;
                            }
                            if((clientes[k].conta.Agency == agencia) && (clientes[k].conta.Number == numero)){
                                Console.Write("\n{0} esse é o saldo da sua conta: R${1}\n\n", clientes[k].Name, clientes[k].conta.Saldo);
                                break;
                            }
                        }
                        break;
                }
            }while(op!=-1);
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

        static Endereco ReadEndereco(){
            Endereco e = new Endereco();
            Console.Write("Logradouro: ");
            e.Logradouro = Console.ReadLine();
            Console.Write("Numero: ");
            e.Numero = int.Parse(Console.ReadLine());
            Console.Write("Localidade: ");
            e.Localidade = Console.ReadLine();
            return e;
        }

        static void Menu(){
            Console.Write("Menu\n1- Cadastrar\n2- Impressão geral\n3- Depósito\n4- Saque\n5- Saldo\n>>");
        }
    }
}
