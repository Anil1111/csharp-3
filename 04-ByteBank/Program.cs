using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.titular = "Vivi";
            Console.WriteLine(conta.saldo);
            bool resultadoSaque = conta.Sacar(500);
            Console.WriteLine(conta.saldo);
            Console.WriteLine(resultadoSaque);

            conta.Depositar(1000);
            Console.WriteLine(conta.saldo);


            ContaCorrente novaConta = new ContaCorrente();

            novaConta.titular = "Alemão";

            conta.Transferir(200, novaConta);

            Console.WriteLine(conta.saldo);
            Console.WriteLine(novaConta.saldo);

            Console.ReadLine();
        }
    }
}
