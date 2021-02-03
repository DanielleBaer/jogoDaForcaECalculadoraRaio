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
    public partial class frmJogoForca : Form
    {
        private string[] palavrasChaves = new string[8]; //vetor das palavras chaves
        private string[] dicas = new string[8]; //vetor de dicas das palavras chaves
        private string palavraChaveSelecionada; //palavra a ser encontrada
        private string textoPalavraChave; //armazena o texto do textbox
        private int tentativas; //qtd de tentativas 
        private int posPalavraChave; //posicao da palavra

        public frmJogoForca()
        {
            InitializeComponent();
            this.VetorPalavras();
        }
        private void VetorPalavras()
        {
            palavrasChaves[0] = "LAPIS";
            dicas[0] = "Utilizado para pintar, desenhar ou escrever";

            palavrasChaves[1] = "CHOCOLATE";
            dicas[1] = "Sua principal matéria-prima é o cacau";

            palavrasChaves[2] = "CAPIVARA";
            dicas[2] = "Animal que não é de estimação, comum em Blumenau";

            palavrasChaves[3] = "ROXO";
            dicas[3] = "Junção de vermelho com azul";

            palavrasChaves[4] = "CHUVA";
            dicas[4] = "Cai em pé e corre deitado";

            palavrasChaves[5] = "WINDOWS";
            dicas[5] = "Janela em inglês";

            palavrasChaves[6] = "LINUX";
            dicas[6] = "Uma de suas distribuições é Ubuntu";

            palavrasChaves[7] = "DIAMETRO";
            dicas[7] = "Duas vezes o raio de uma circunferência";
        }
        private void Conferencia()
        {
            bool tratamento = false;
            char letra = '0';
            try
            {
                letra = Convert.ToChar(txbLetra.Text); //atribuindo a letra a ser conferida
            }
            catch (Exception)
            {
                txbLetra.Focus();
                tratamento = true;
            }
            bool achou = false;
            int posLetra;
            string temp = "";
            for (int i = 0; i < palavraChaveSelecionada.Length; i++) //percorre a palavra
            {
                if (letra == palavraChaveSelecionada[i]) //se encontrou a letra digitada
                {
                    achou = true;
                    posLetra = i; //armazena a posicao em que a letra foi encontrada
                    temp += txbLetra.Text;
                }
                else
                {
                    temp += textoPalavraChave[i];
                }
            }
            textoPalavraChave = temp;
            txbPalavraChave.Text = textoPalavraChave;
            txbLetra.Text = ""; //limpando o textbox da letra
            txbLetra.Focus(); //manter o cursor no textbox p/ digitar letra
            if (achou == false && tratamento == false)
            {
                tentativas--; //decrementa as tentativas
                lbTentativas.Text = Convert.ToString(tentativas);
                lbLetrasErradas.Text += letra + " ";
                lbLetrasErradas.Visible = true;
            }
            if (tentativas <= 2)
            {
                gbTentativas.BackColor = Color.IndianRed;
                gbTentativas.ForeColor = Color.White;
                lbTentativas.ForeColor = Color.White;
            }
            if (tentativas == 0)
            {
                MessageBox.Show("Você perdeu!");
                btConfereLetra.Enabled = false;
                txbLetra.Enabled = false;
                btJogar.Visible = true;
            }
            else
            {
                for (int i = 0; i < textoPalavraChave.Length; i++)
                {
                    if (textoPalavraChave == palavraChaveSelecionada)
                    {
                        MessageBox.Show("Parabéns. Você acertou a palavra!");
                        btConfereLetra.Enabled = false;
                        txbLetra.Enabled = false;
                        btJogar.Visible = true;
                        break;
                    }
                }
            }    
        }
        private void InicioJogo()
        {
            Random ran = new Random();
            //selecionando palavra aleatoriamente
            posPalavraChave = ran.Next(0, 8);
            palavraChaveSelecionada = palavrasChaves[posPalavraChave];
            textoPalavraChave = "";
            for(int i = 0; i < palavraChaveSelecionada.Length; i++)
            {
                textoPalavraChave = textoPalavraChave + "-";
            }
            txbPalavraChave.Text = textoPalavraChave; //text box da palavra chave a ser encontrada
            lbDica.Text = dicas[posPalavraChave]; //mostrando a dica da palavra a ser encontrada
            tentativas = 6; //tentativas possiveis para descobrir palavra
            lbTentativas.Text = tentativas.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btConfereLetra;
        }

        private void btJogar_Click(object sender, EventArgs e)
        {
            gbTentativas.BackColor = Color.Transparent;
            gbTentativas.ForeColor = Color.DarkSlateGray;
            lbTentativas.ForeColor = Color.DarkSlateGray;
            lbLetrasErradas.Text = "";
            btJogar.Visible = false;
            lbDica.Visible = true;
            txbLetra.Enabled = true;
            txbLetra.Focus();
            btConfereLetra.Enabled = true;
            this.InicioJogo();
        }

        private void btConfereLetra_Click(object sender, EventArgs e)
        {
            Conferencia();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            var frmInicial = new frmInicial();
            this.Hide();
            frmInicial.Show();
        }

        private void frmJogoForca_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
