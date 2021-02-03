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
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frmJogoForca = new frmJogoForca();
            this.Hide();
            frmJogoForca.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frmCalculadoraAlvo = new frmCalculadoraAlvo();
            this.Hide();
            frmCalculadoraAlvo.Show();
        }

        private void frmInicial_Load(object sender, EventArgs e)
        {
        }

        private void frmInicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
