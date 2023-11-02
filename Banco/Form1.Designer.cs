namespace Banco
{
    partial class Form1
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
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.buttonDeposita = new System.Windows.Forms.Button();
            this.buttonSaque = new System.Windows.Forms.Button();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Conta = new System.Windows.Forms.GroupBox();
            this.Conta.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(62, 46);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(100, 20);
            this.textoTitular.TabIndex = 0;
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(62, 72);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(100, 20);
            this.textoNumero.TabIndex = 0;
            // 
            // buttonDeposita
            // 
            this.buttonDeposita.Location = new System.Drawing.Point(24, 177);
            this.buttonDeposita.Name = "buttonDeposita";
            this.buttonDeposita.Size = new System.Drawing.Size(75, 23);
            this.buttonDeposita.TabIndex = 1;
            this.buttonDeposita.Text = "Depositar";
            this.buttonDeposita.UseVisualStyleBackColor = true;
            this.buttonDeposita.Click += new System.EventHandler(this.buttonDeposita_Click);
            // 
            // buttonSaque
            // 
            this.buttonSaque.Location = new System.Drawing.Point(126, 177);
            this.buttonSaque.Name = "buttonSaque";
            this.buttonSaque.Size = new System.Drawing.Size(75, 23);
            this.buttonSaque.TabIndex = 1;
            this.buttonSaque.Text = "Saque";
            this.buttonSaque.UseVisualStyleBackColor = true;
            this.buttonSaque.Click += new System.EventHandler(this.buttonSaque_Click);
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(62, 98);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(100, 20);
            this.textoSaldo.TabIndex = 0;
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(62, 124);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(100, 20);
            this.textoValor.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saldo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Titular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Valor";
            // 
            // Conta
            // 
            this.Conta.Controls.Add(this.textoTitular);
            this.Conta.Controls.Add(this.label4);
            this.Conta.Controls.Add(this.textoNumero);
            this.Conta.Controls.Add(this.label3);
            this.Conta.Controls.Add(this.textoSaldo);
            this.Conta.Controls.Add(this.label1);
            this.Conta.Controls.Add(this.textoValor);
            this.Conta.Controls.Add(this.label2);
            this.Conta.Controls.Add(this.buttonDeposita);
            this.Conta.Controls.Add(this.buttonSaque);
            this.Conta.Location = new System.Drawing.Point(12, 12);
            this.Conta.Name = "Conta";
            this.Conta.Size = new System.Drawing.Size(207, 252);
            this.Conta.TabIndex = 3;
            this.Conta.TabStop = false;
            this.Conta.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 375);
            this.Controls.Add(this.Conta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Conta.ResumeLayout(false);
            this.Conta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.Button buttonDeposita;
        private System.Windows.Forms.Button buttonSaque;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox Conta;
    }
}

