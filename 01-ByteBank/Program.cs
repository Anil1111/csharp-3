using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaTeti = new ContaCorrente();

            contaDaTeti.titular = "Teti";
            contaDaTeti.agencia = 863;
            contaDaTeti.numero = 863452;
            contaDaTeti.saldo = 100.0;

            Console.WriteLine("Titular: " + contaDaTeti.titular);
            Console.WriteLine("Agência: " + contaDaTeti.agencia);
            Console.WriteLine("Número: " + contaDaTeti.numero);
            Console.WriteLine("Saldo: " + contaDaTeti.saldo);


            Console.ReadLine();
        }
    }
}
