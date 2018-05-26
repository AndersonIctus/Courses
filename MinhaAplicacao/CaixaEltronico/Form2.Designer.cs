namespace Caelum.CaixaEltronico
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumConta = new System.Windows.Forms.TextBox();
            this.btDepositar = new System.Windows.Forms.Button();
            this.txtValorDepositar = new System.Windows.Forms.TextBox();
            this.btSacar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(94, 12);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(100, 20);
            this.textoTitular.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Saldo: ";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(94, 64);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Num Conta:";
            // 
            // txtNumConta
            // 
            this.txtNumConta.Location = new System.Drawing.Point(94, 38);
            this.txtNumConta.Name = "txtNumConta";
            this.txtNumConta.Size = new System.Drawing.Size(100, 20);
            this.txtNumConta.TabIndex = 4;
            // 
            // btDepositar
            // 
            this.btDepositar.Location = new System.Drawing.Point(315, 42);
            this.btDepositar.Name = "btDepositar";
            this.btDepositar.Size = new System.Drawing.Size(75, 23);
            this.btDepositar.TabIndex = 6;
            this.btDepositar.Text = "Depositar Valor";
            this.btDepositar.UseVisualStyleBackColor = true;
            this.btDepositar.Click += new System.EventHandler(this.btDepositar_Click);
            // 
            // txtValorDepositar
            // 
            this.txtValorDepositar.Location = new System.Drawing.Point(315, 13);
            this.txtValorDepositar.Name = "txtValorDepositar";
            this.txtValorDepositar.Size = new System.Drawing.Size(64, 20);
            this.txtValorDepositar.TabIndex = 7;
            this.txtValorDepositar.Text = "0,0";
            // 
            // btSacar
            // 
            this.btSacar.Location = new System.Drawing.Point(396, 42);
            this.btSacar.Name = "btSacar";
            this.btSacar.Size = new System.Drawing.Size(75, 23);
            this.btSacar.TabIndex = 8;
            this.btSacar.Text = "Sacar Valor";
            this.btSacar.UseVisualStyleBackColor = true;
            this.btSacar.Click += new System.EventHandler(this.btSacar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 229);
            this.Controls.Add(this.btSacar);
            this.Controls.Add(this.txtValorDepositar);
            this.Controls.Add(this.btDepositar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumConta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textoTitular);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumConta;
        private System.Windows.Forms.Button btDepositar;
        private System.Windows.Forms.TextBox txtValorDepositar;
        private System.Windows.Forms.Button btSacar;
    }
}