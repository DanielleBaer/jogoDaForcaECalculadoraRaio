using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanielleBaer_Recuperacao
{

    //Calcular os raios de 5 argolas de um alvo com 6 argolas a partir do raio da maior argola, 
    //onde a maior argola é a de número 6
    //sendo o raio da maior argola definido pelo usuário
    public partial class frmCalculadoraAlvo : Form
    {
        public frmCalculadoraAlvo()
        {
            InitializeComponent();
        }
        private void btCalcular_Click(object sender, EventArgs e)
        {
            double r6 = 0; 
            double r5, r4, r3, r2, r1;
            try
            {
                r6 = Convert.ToDouble(txbRaio.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números!");
                txbRaio.Focus();
                txbRaio.Text = "";
            }
            //calcular o raio das demais argolas
            r5 = (r6 / 6) * 5;
            r4 = (r6 / 6) * 4;
            r3 = (r6 / 6) * 3;
            r2 = (r6 / 6) * 2;
            r1 = r6 / 6;

            txb6.Text = Convert.ToString(r6);
            txb5.Text = Convert.ToString(r5);
            txb4.Text = Convert.ToString(r4);
            txb3.Text = Convert.ToString(r3);
            txb2.Text = Convert.ToString(r2);
            txb1.Text = Convert.ToString(r1);
            txbRaio.Text = "";
            txbRaio.Focus();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            var frmInicial = new frmInicial();
            this.Hide();
            frmInicial.Show();
        }

        private void frmCalculadoraAlvo_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btCalcular;
        }

        private void frmCalculadoraAlvo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txb1.Clear();
            txb2.Clear();
            txb3.Clear();
            txb4.Clear();
            txb5.Clear();
            txb6.Clear();
        }
    }
}
