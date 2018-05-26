namespace Caelum.CaixaEltronico
{
    partial class CadastroDeContas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitularConta = new System.Windows.Forms.TextBox();
            this.txtNumConta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btNovaConta = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipoConta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cta";
            // 
            // txtTitularConta
            // 
            this.txtTitularConta.Location = new System.Drawing.Point(12, 82);
            this.txtTitularConta.Name = "txtTitularConta";
            this.txtTitularConta.Size = new System.Drawing.Size(225, 20);
            this.txtTitularConta.TabIndex = 2;
            // 
            // txtNumConta
            // 
            this.txtNumConta.Location = new System.Drawing.Point(12, 31);
            this.txtNumConta.Name = "txtNumConta";
            this.txtNumConta.Size = new System.Drawing.Size(43, 20);
            this.txtNumConta.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Titular da Conta";
            // 
            // btNovaConta
            // 
            this.btNovaConta.Location = new System.Drawing.Point(81, 108);
            this.btNovaConta.Name = "btNovaConta";
            this.btNovaConta.Size = new System.Drawing.Size(75, 23);
            this.btNovaConta.TabIndex = 3;
            this.btNovaConta.Text = "Cadastrar";
            this.btNovaConta.UseVisualStyleBackColor = true;
            this.btNovaConta.Click += new System.EventHandler(this.btNovaConta_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btCancelar.Location = new System.Drawing.Point(162, 108);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo de Conta";
            // 
            // cbTipoConta
            // 
            this.cbTipoConta.FormattingEnabled = true;
            this.cbTipoConta.Location = new System.Drawing.Point(61, 31);
            this.cbTipoConta.Name = "cbTipoConta";
            this.cbTipoConta.Size = new System.Drawing.Size(176, 21);
            this.cbTipoConta.TabIndex = 6;
            // 
            // CadastroDeContas
            // 
            this.ClientSize = new System.Drawing.Size(254, 155);
            this.Controls.Add(this.cbTipoConta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btNovaConta);
            this.Controls.Add(this.txtNumConta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitularConta);
            this.Controls.Add(this.label1);
            this.Name = "CadastroDeContas";
            this.Load += new System.EventHandler(this.CadastroDeContas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitularConta;
        private System.Windows.Forms.TextBox txtNumConta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btNovaConta;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTipoConta;
    }
}