using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente cliente = new Cliente();
            //cliente.nome = "teti";
            //cliente.cpf = "00579195341";
            //cliente.profissao = "Arquiteta";

            ContaCorrente conta = new ContaCorrente();
            conta.titular = new Cliente();
            conta.titular.nome = "Teti";
            conta.titular.cpf = "5555555";
            conta.titular.profissao = "Arquiteta";

            conta.saldo = 500;
            conta.agencia = 863;
            conta.numero = 863425;

            Console.WriteLine(conta.titular.nome);

            Console.ReadLine();

        }
    }
}
