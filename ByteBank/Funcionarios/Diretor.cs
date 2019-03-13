using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Diretor : Funcionario
    {
        public Diretor(string cpf) : base(cpf, 5000)
        {
            Console.WriteLine("Criando Diretor");
        }
        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao();
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

    }
}
