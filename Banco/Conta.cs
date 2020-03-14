using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public string Titular { get; set; }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if(valor <= Saldo)
            this.Saldo -= valor;

        }
    }
}
