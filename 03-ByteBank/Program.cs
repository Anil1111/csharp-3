using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaTeti = new ContaCorrente();
            contaDaTeti.titular = "Teti";
            contaDaTeti.agencia = 863;
            contaDaTeti.numero = 863452;

            ContaCorrente contaDoDunga = new ContaCorrente();
            contaDaTeti.titular = "Teti";
            contaDaTeti.agencia = 863;
            contaDaTeti.numero = 863452;

            Console.WriteLine(contaDaTeti == contaDoDunga);

            Console.ReadLine();


        }
    }
}
