using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv_heranca.Contas
{
    internal class Conta
    {
        public int numero_conta { get; set; }
        public string agencia { get; set; }
        public string titular_conta { get; set; }
        public double saldoConta { get; set; }

        public virtual bool Saque(double valor)
        {
            if (valor <= saldoConta)
            {
                saldoConta = saldoConta - valor;
                return true;
            }
            else
            {
                return false;
            }
        }
        public virtual void Deposito(double valor)
        {
            saldoConta += valor;
        }
    }
}
