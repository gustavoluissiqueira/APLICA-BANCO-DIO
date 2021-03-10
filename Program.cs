﻿using System;
using System.Collections.Generic;

namespace DIO.Bank
{
    class Program
    {   
        static List<Conta> listContas = new List<Conta>();
        static void Main(string[] args)
        {   
            
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        ListarContas();
                    break;
                    case "2":
                        InserirConta();
                        break;
                    case "3":
                        Transferir();
                        break;
                    case "4":
                        Sacar();
                    break;
                    case "5":
                        Depositar();
                    break;
                    case "C":

                    break;
                    
                    default: 
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
           Console.WriteLine("Obrigado por utilizar o Banco DIO.");
           Console.ReadLine();
        }

       

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Bank a seu dispor");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1 - Listar Contas");
            Console.WriteLine("2 - Inserir nova conta");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("4 - Sacar");
            Console.WriteLine("5 - Depositar");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }

         private static void ListarContas()
        {
            Console.WriteLine("Listar Contas");

            if(listContas.Count == 0)
            {
                Console.WriteLine("Não possui contas.");
                return;
            }

            for(int i = 0; i < listContas.Count; i++)
            {
                Conta conta = listContas[i];
                Console.Write("#{0} - ", i);
                Console.WriteLine(conta);
            }

        }
         private static void InserirConta()
        {
            Console.WriteLine("inseri nova Conta");

            Console.WriteLine("Digite 1 para Conta Física ou 2 para Jurídica: ");
            int entradaTipoConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Nome do Cliente: ");
            string entradaNome = Console.ReadLine();

            Console.WriteLine("Digite o Saldo inicial: ");
            double entradaSaldoInicial = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Crédito: ");
            double entradaCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoConta,
                                saldo: entradaSaldoInicial,
                                credito: entradaCredito,
                                nome: entradaNome);

            listContas.Add(novaConta);
            
        }

        private static void Sacar()
        {
            Console.WriteLine("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor a ser sacado: ");
            double valorSaque = double.Parse(Console.ReadLine());

            listContas[indiceConta].Sacar(valorSaque);
        }

        private static void Depositar()
        {
           

            Console.WriteLine("Qual conta você deseja depositar:");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do depósito:");
            double valorDeposito = double.Parse(Console.ReadLine());

            Console.WriteLine("O valor a ser depositado é R${0}", valorDeposito);

           
            listContas[indiceConta].Depositar(valorDeposito);  

        }

        private static void Transferir()
        {

            Console.WriteLine("Qual a conta de origem: ");
            int indiceContaOrigem = int.Parse(Console.ReadLine());

            Console.WriteLine("Para qual conta você deseja transferir: ");
            int indiceContaDestino = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Qual valor você deseja transferir: ");
            double valorTransferencia = int.Parse(Console.ReadLine());


            listContas[indiceContaOrigem].Transferir(valorTransferencia, listContas[indiceContaDestino]);

            

        }






















    }
}
  