
namespace DanielleBaer_Recuperacao
{
    partial class frmJogoForca
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btJogar = new System.Windows.Forms.Button();
            this.pnJogo = new System.Windows.Forms.Panel();
            this.gbLetrasDigitadas = new System.Windows.Forms.GroupBox();
            this.lbLetrasErradas = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbDica = new System.Windows.Forms.Label();
            this.txbPalavraChave = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbLetra = new System.Windows.Forms.TextBox();
            this.btConfereLetra = new System.Windows.Forms.Button();
            this.gbTentativas = new System.Windows.Forms.GroupBox();
            this.lbTentativas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btSair = new System.Windows.Forms.Button();
            this.pnJogo.SuspendLayout();
            this.gbLetrasDigitadas.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbTentativas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btJogar
            // 
            this.btJogar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btJogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btJogar.ForeColor = System.Drawing.Color.SkyBlue;
            this.btJogar.Location = new System.Drawing.Point(174, 314);
            this.btJogar.Name = "btJogar";
            this.btJogar.Size = new System.Drawing.Size(174, 43);
            this.btJogar.TabIndex = 0;
            this.btJogar.Text = "Jogar";
            this.btJogar.UseVisualStyleBackColor = false;
            this.btJogar.Click += new System.EventHandler(this.btJogar_Click);
            // 
            // pnJogo
            // 
            this.pnJogo.Controls.Add(this.gbLetrasDigitadas);
            this.pnJogo.Controls.Add(this.groupBox2);
            this.pnJogo.Controls.Add(this.txbPalavraChave);
            this.pnJogo.Controls.Add(this.groupBox1);
            this.pnJogo.Controls.Add(this.gbTentativas);
            this.pnJogo.Controls.Add(this.label1);
            this.pnJogo.Location = new System.Drawing.Point(9, 12);
            this.pnJogo.Name = "pnJogo";
            this.pnJogo.Size = new System.Drawing.Size(500, 326);
            this.pnJogo.TabIndex = 1;
            // 
            // gbLetrasDigitadas
            // 
            this.gbLetrasDigitadas.Controls.Add(this.lbLetrasErradas);
            this.gbLetrasDigitadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLetrasDigitadas.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.gbLetrasDigitadas.Location = new System.Drawing.Point(8, 99);
            this.gbLetrasDigitadas.Name = "gbLetrasDigitadas";
            this.gbLetrasDigitadas.Size = new System.Drawing.Size(235, 54);
            this.gbLetrasDigitadas.TabIndex = 6;
            this.gbLetrasDigitadas.TabStop = false;
            this.gbLetrasDigitadas.Text = "Erros:";
            // 
            // lbLetrasErradas
            // 
            this.lbLetrasErradas.AutoSize = true;
            this.lbLetrasErradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLetrasErradas.Location = new System.Drawing.Point(6, 20);
            this.lbLetrasErradas.Name = "lbLetrasErradas";
            this.lbLetrasErradas.Size = new System.Drawing.Size(0, 24);
            this.lbLetrasErradas.TabIndex = 0;
            this.lbLetrasErradas.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbDica);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox2.Location = new System.Drawing.Point(10, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 54);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dica:";
            // 
            // lbDica
            // 
            this.lbDica.AutoSize = true;
            this.lbDica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDica.Location = new System.Drawing.Point(6, 20);
            this.lbDica.Name = "lbDica";
            this.lbDica.Size = new System.Drawing.Size(87, 24);
            this.lbDica.TabIndex = 0;
            this.lbDica.Text = "textoDica";
            this.lbDica.Visible = false;
            // 
            // txbPalavraChave
            // 
            this.txbPalavraChave.BackColor = System.Drawing.Color.LightBlue;
            this.txbPalavraChave.Enabled = false;
            this.txbPalavraChave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPalavraChave.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txbPalavraChave.Location = new System.Drawing.Point(156, 9);
            this.txbPalavraChave.Name = "txbPalavraChave";
            this.txbPalavraChave.Size = new System.Drawing.Size(282, 30);
            this.txbPalavraChave.TabIndex = 8;
            this.txbPalavraChave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbLetra);
            this.groupBox1.Controls.Add(this.btConfereLetra);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(263, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 168);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "      Digite uma letra";
            // 
            // txbLetra
            // 
            this.txbLetra.BackColor = System.Drawing.Color.LightBlue;
            this.txbLetra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbLetra.Enabled = false;
            this.txbLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLetra.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txbLetra.Location = new System.Drawing.Point(65, 41);
            this.txbLetra.MaxLength = 1;
            this.txbLetra.Name = "txbLetra";
            this.txbLetra.Size = new System.Drawing.Size(89, 30);
            this.txbLetra.TabIndex = 5;
            this.txbLetra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btConfereLetra
            // 
            this.btConfereLetra.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btConfereLetra.Enabled = false;
            this.btConfereLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfereLetra.ForeColor = System.Drawing.Color.SkyBlue;
            this.btConfereLetra.Location = new System.Drawing.Point(65, 88);
            this.btConfereLetra.Name = "btConfereLetra";
            this.btConfereLetra.Size = new System.Drawing.Size(89, 37);
            this.btConfereLetra.TabIndex = 6;
            this.btConfereLetra.Text = "Conferir";
            this.btConfereLetra.UseVisualStyleBackColor = false;
            this.btConfereLetra.Click += new System.EventHandler(this.btConfereLetra_Click);
            // 
            // gbTentativas
            // 
            this.gbTentativas.Controls.Add(this.lbTentativas);
            this.gbTentativas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTentativas.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.gbTentativas.Location = new System.Drawing.Point(20, 159);
            this.gbTentativas.Name = "gbTentativas";
            this.gbTentativas.Size = new System.Drawing.Size(157, 137);
            this.gbTentativas.TabIndex = 4;
            this.gbTentativas.TabStop = false;
            this.gbTentativas.Text = "Tentativas";
            // 
            // lbTentativas
            // 
            this.lbTentativas.AutoSize = true;
            this.lbTentativas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTentativas.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbTentativas.Location = new System.Drawing.Point(64, 62);
            this.lbTentativas.Name = "lbTentativas";
            this.lbTentativas.Size = new System.Drawing.Size(29, 31);
            this.lbTentativas.TabIndex = 0;
            this.lbTentativas.Text = "6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Palavra chave:";
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.ForeColor = System.Drawing.Color.SkyBlue;
            this.btSair.Location = new System.Drawing.Point(397, 344);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(88, 31);
            this.btSair.TabIndex = 2;
            this.btSair.Text = "Voltar";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // frmJogoForca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(521, 400);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btJogar);
            this.Controls.Add(this.pnJogo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmJogoForca";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Jogo da Forca";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmJogoForca_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnJogo.ResumeLayout(false);
            this.pnJogo.PerformLayout();
            this.gbLetrasDigitadas.ResumeLayout(false);
            this.gbLetrasDigitadas.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbTentativas.ResumeLayout(false);
            this.gbTentativas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btJogar;
        private System.Windows.Forms.Panel pnJogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbTentativas;
        private System.Windows.Forms.Label lbTentativas;
        private System.Windows.Forms.TextBox txbLetra;
        private System.Windows.Forms.Button btConfereLetra;
        private System.Windows.Forms.TextBox txbPalavraChave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbDica;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.GroupBox gbLetrasDigitadas;
        private System.Windows.Forms.Label lbLetrasErradas;
    }
}

