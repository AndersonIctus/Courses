namespace Caelum.CaixaEltronico
{
    partial class MeuCaixaEltronico
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
            this.cbContas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btSacar = new System.Windows.Forms.Button();
            this.btDepositar = new System.Windows.Forms.Button();
            this.cbContasTranferencia = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btTransferir = new System.Windows.Forms.Button();
            this.btCadNovaConta = new System.Windows.Forms.Button();
            this.btRemoveConta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbContas
            // 
            this.cbContas.FormattingEnabled = true;
            this.cbContas.Location = new System.Drawing.Point(15, 12);
            this.cbContas.Name = "cbContas";
            this.cbContas.Size = new System.Drawing.Size(264, 21);
            this.cbContas.TabIndex = 0;
            this.cbContas.SelectedIndexChanged += new System.EventHandler(this.cbContas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titular :";
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(15, 146);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(264, 20);
            this.txtTitular.TabIndex = 2;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(15, 101);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(162, 20);
            this.txtNumero.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero :";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(183, 101);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(96, 20);
            this.txtSaldo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Saldo :";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(16, 194);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(74, 20);
            this.txtValor.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor";
            // 
            // btSacar
            // 
            this.btSacar.Location = new System.Drawing.Point(42, 226);
            this.btSacar.Name = "btSacar";
            this.btSacar.Size = new System.Drawing.Size(75, 23);
            this.btSacar.TabIndex = 9;
            this.btSacar.Text = "Sacar";
            this.btSacar.UseVisualStyleBackColor = true;
            this.btSacar.Click += new System.EventHandler(this.btSacar_Click);
            // 
            // btDepositar
            // 
            this.btDepositar.Location = new System.Drawing.Point(123, 226);
            this.btDepositar.Name = "btDepositar";
            this.btDepositar.Size = new System.Drawing.Size(75, 23);
            this.btDepositar.TabIndex = 10;
            this.btDepositar.Text = "Depositar";
            this.btDepositar.UseVisualStyleBackColor = true;
            this.btDepositar.Click += new System.EventHandler(this.btDepositar_Click);
            // 
            // cbContasTranferencia
            // 
            this.cbContasTranferencia.FormattingEnabled = true;
            this.cbContasTranferencia.Location = new System.Drawing.Point(96, 193);
            this.cbContasTranferencia.Name = "cbContasTranferencia";
            this.cbContasTranferencia.Size = new System.Drawing.Size(183, 21);
            this.cbContasTranferencia.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tranferência";
            // 
            // btTransferir
            // 
            this.btTransferir.Location = new System.Drawing.Point(204, 226);
            this.btTransferir.Name = "btTransferir";
            this.btTransferir.Size = new System.Drawing.Size(75, 23);
            this.btTransferir.TabIndex = 14;
            this.btTransferir.Text = "Transferir";
            this.btTransferir.UseVisualStyleBackColor = true;
            this.btTransferir.Click += new System.EventHandler(this.btTransferir_Click);
            // 
            // btCadNovaConta
            // 
            this.btCadNovaConta.Location = new System.Drawing.Point(15, 39);
            this.btCadNovaConta.Name = "btCadNovaConta";
            this.btCadNovaConta.Size = new System.Drawing.Size(129, 37);
            this.btCadNovaConta.TabIndex = 15;
            this.btCadNovaConta.Text = "Cadastar Nova Conta";
            this.btCadNovaConta.UseVisualStyleBackColor = true;
            this.btCadNovaConta.Click += new System.EventHandler(this.btCadNovaConta_Click);
            // 
            // btRemoveConta
            // 
            this.btRemoveConta.Location = new System.Drawing.Point(150, 39);
            this.btRemoveConta.Name = "btRemoveConta";
            this.btRemoveConta.Size = new System.Drawing.Size(129, 37);
            this.btRemoveConta.TabIndex = 16;
            this.btRemoveConta.Text = "Remover Conta";
            this.btRemoveConta.UseVisualStyleBackColor = true;
            this.btRemoveConta.Click += new System.EventHandler(this.btRemoveConta_Click);
            // 
            // MeuCaixaEltronico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 263);
            this.Controls.Add(this.btRemoveConta);
            this.Controls.Add(this.btCadNovaConta);
            this.Controls.Add(this.btTransferir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbContasTranferencia);
            this.Controls.Add(this.btDepositar);
            this.Controls.Add(this.btSacar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbContas);
            this.Name = "MeuCaixaEltronico";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.CaixaEltronico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbContas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btSacar;
        private System.Windows.Forms.Button btDepositar;
        private System.Windows.Forms.ComboBox cbContasTranferencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btTransferir;
        private System.Windows.Forms.Button btCadNovaConta;
        private System.Windows.Forms.Button btRemoveConta;
    }
}