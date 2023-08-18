using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv_heranca.Contas
{
    internal class Empresa : Conta
    {
        public double taxa_anuidade { get; set; }
        public double limite_emprestimo { get; set; }
        public double total_emprestimo { get; set; }

        public bool Emprestimo(double valor)
        {
            if (total_emprestimo < limite_emprestimo)
            {
                if ((total_emprestimo - limite_emprestimo) <= valor)
                {
                    total_emprestimo += valor;
                    saldoConta += valor;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public override bool Saque(double valor)
        {
            if (valor <= saldoConta)
            {
                if (valor > 5000)
                {
                    saldoConta = saldoConta - (valor + 5);
                    return true;
                }
                else
                {
                    saldoConta = saldoConta - valor;
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
