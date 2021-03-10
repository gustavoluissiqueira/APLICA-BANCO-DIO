using System;

namespace DIO.Bank
{
    public class Conta
    {

        private TipoConta TipoConta{ get; set; }
        private double Credito { get; set; }
        private double Saldo { get; set; }
        private string Nome { get; set; }


        //Contrutor
       
        
        public Conta(TipoConta tipoConta, double credito, double saldo, string nome)
        {
            this.TipoConta = tipoConta;
            this.Credito = credito;
            this.Saldo = saldo;
            this.Nome = nome;
        }

        //Sacar
        public bool Sacar(double valorSaque)
        {
            //Validação saldo insuficiente
            if(this.Saldo - valorSaque < (this.Credito *-1))
            {
                Console.WriteLine("Saldo Insuficiente!");
                return false;
            }

            this.Saldo -= valorSaque;
            Console.WriteLine("Saldo atual da conta de {0} é  {1}", this.Nome, this.Saldo);
            return true;
        }

        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;
            Console.WriteLine("Saldo atual da conta de {0} é  {1}", this.Nome, this.Saldo);
        }


        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            if(this.Sacar(valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia);
            }
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Tipo Conta: " + this.TipoConta  +  " | ";
            retorno += "Nome: " + this.Nome  +  " | ";
            retorno += "Saldo: " + this.Saldo  +  " | " ;
            retorno += "Crédito: " + this.Credito  +  " | ";
            return retorno;
        }





























































    }
}