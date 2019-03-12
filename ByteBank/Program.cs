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

            Funcionario func = new Funcionario();
            func.Nome = "Rafael";
            func.CPF = "3399222132";
            func.Salario = 2000.0;
            Console.WriteLine(func.Nome);
            Console.WriteLine(func.GetBonificacao());
            bonificacao.registrar(func);

            Diretor dir = new Diretor();
            dir.Nome = "Teti";
            dir.CPF = "99988877722";
            dir.Salario = 5000.0;
            Console.WriteLine(dir.Nome);
            Console.WriteLine(dir.GetBonificacao());
            bonificacao.registrar(dir);

            Funcionario dunga = new Diretor();

            Console.Write("Total de bonificações: " + bonificacao.getTotalBonificacao());

            Console.ReadLine();
        }
    }
}
