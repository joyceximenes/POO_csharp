using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    internal class ContaCorrente
    {     
            public string titular;
            public string conta;
            public string agencia;
            public double saldo;

            public bool sacar(double valor)
            {
            if (saldo < valor)
                return false;
            else
            {
                saldo = saldo - valor;
                return true;
            }
            }
    }
}

