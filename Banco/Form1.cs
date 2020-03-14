using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Conta c1;

        private void Form1_Load(object sender, EventArgs e)
        {
            //criando a conta
            c1 = new Conta();
            c1.Titular = "Maria";
            c1.Numero = 1;

            //imprimar os dados
            textoTitular.Text = c1.Titular;
            textoNumero.Text = Convert.ToString(c1.Numero);
            textoSaldo.Text = Convert.ToString(c1.Saldo);
            
            
        }

        private void btn_Depositar_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(ValorOperecao.Text);
            c1.Depositar(valor);

            textoSaldo.Text = Convert.ToString(c1.Saldo);


        }

        private void btn_Sacar_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(ValorOperecao.Text);
            c1.Sacar(valor);

            textoSaldo.Text = Convert.ToString(c1.Saldo);

        }
    }
}
