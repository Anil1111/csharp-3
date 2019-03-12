using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Bonificacao
    {
        private double _totalBonificacoes;

        public void registrar(Funcionario funcionario)
        {
            _totalBonificacoes += funcionario.GetBonificacao();
        }

        public double getTotalBonificacao()
        {
            return _totalBonificacoes;
        }
    }
}
