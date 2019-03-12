using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            double saldo = conta.Saldo;

            conta.Saldo = -10;

            Console.WriteLine(conta.Saldo);

            Cliente cliente = new Cliente();
            cliente.nome = "Rafael";
            cliente.cpf = "99988877722";
            cliente.profissao = "Desenvolvedor";

            conta.Titular = cliente;

            Console.WriteLine(conta.Titular.nome);
            Console.ReadLine();
        }
    }
}
