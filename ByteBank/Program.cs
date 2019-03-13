using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Bonificacao bonificacao = new Bonificacao();

            Funcionario func = new Funcionario("3399222132", 2000);
            func.Nome = "Rafael";
            Console.WriteLine(func.Nome);
            Console.WriteLine(func.GetBonificacao());
            bonificacao.registrar(func);
            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            Diretor dir = new Diretor("99988877722", 5000);
            dir.Nome = "Teti";
            Console.WriteLine(dir.Nome);
            Console.WriteLine(dir.GetBonificacao());
            bonificacao.registrar(dir);

            //Funcionario dunga = new Diretor();
            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            Console.Write("Total de bonificações: " + bonificacao.getTotalBonificacao());

            Console.ReadLine();
        }
    }
}
