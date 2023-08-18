using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv_heranca.Contas
{
    internal class Estudante : Conta
    {
        public string cpf { get; set; }
        public string instituicao_ensino { get; set; }
        public double cheque_especial { get; set; }

        public override bool Saque(double valor)
        {
            if (valor <= saldoConta)
            {
                saldoConta = saldoConta;
                return true;
            }
            else if (valor > saldoConta && valor < (saldoConta + cheque_especial))
            {
                saldoConta -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
