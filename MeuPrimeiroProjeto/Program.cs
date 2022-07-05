using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta_yasmin = new ContaCorrente ("Yasmin", 12345, 514, 100);    // variável do tipo conta corrente 
            ContaCorrente conta_andre = new ContaCorrente ("andre", 12345, 587, 187);    // variável do tipo conta corrente 
            ContaCorrente conta_vitor = new ContaCorrente ("Vitor", 12345, 741, 963);    // variável do tipo conta corrente 

            
            Console.WriteLine("A conta é do (a) " + conta_yasmin.Titular + 
            ", a agência é " + conta_yasmin.Agencia + " e o número é " + conta_yasmin.Numero + " Saldo: " + conta_yasmin.Saldo);

            Console.WriteLine("A conta é do (a) " + conta_andre.Titular + 
            ", a agência é " + conta_andre.Agencia + " e o número é " + conta_andre.Numero + " Saldo: " + conta_andre.Saldo);

            Console.WriteLine("A conta é do (a) " + conta_vitor.Titular + 
            ", a agência é " + conta_vitor.Agencia + " e o número é " + conta_vitor.Numero + " Saldo: " + conta_vitor.Saldo);


            bool sacar_conta = conta_yasmin.Sacar(100);
            bool sacar_conta1 = conta_andre.Sacar(100);
            bool sacar_conta2 = conta_vitor.Sacar(100);


             Console.WriteLine("A conta é do (a) " + conta_yasmin.Titular + 
            ", a agência é " + conta_yasmin.Agencia + " e o número é " + conta_yasmin.Numero + " Saldo: " + conta_yasmin.Saldo);

            Console.WriteLine("A conta é do (a) " + conta_andre.Titular + 
            ", a agência é " + conta_andre.Agencia + " e o número é " + conta_andre.Numero + " Saldo: " + conta_andre.Saldo);

             Console.WriteLine("A conta é do (a) " + conta_vitor.Titular + 
            ", a agência é " + conta_vitor.Agencia + " e o número é " + conta_vitor.Numero + " Saldo: " + conta_vitor.Saldo);

           

        }
    }    
}
