namespace LocadoraTurmaTerca2020_1
{
    partial class FrmCadastroCliente
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblDtNasc = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.mskDtNasc = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(27, 21);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 17);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(219, 21);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(38, 17);
            this.lblCpf.TabIndex = 1;
            this.lblCpf.Text = "CPF:";
            // 
            // lblDtNasc
            // 
            this.lblDtNasc.AutoSize = true;
            this.lblDtNasc.Location = new System.Drawing.Point(400, 21);
            this.lblDtNasc.Name = "lblDtNasc";
            this.lblDtNasc.Size = new System.Drawing.Size(140, 17);
            this.lblDtNasc.TabIndex = 2;
            this.lblDtNasc.Text = "Data de Nascimento:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(27, 77);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 17);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(30, 41);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(152, 22);
            this.txtCodigo.TabIndex = 4;
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(222, 41);
            this.mskCPF.Mask = "999.999.999-99";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(142, 22);
            this.mskCPF.TabIndex = 6;
            this.mskCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mskDtNasc
            // 
            this.mskDtNasc.Location = new System.Drawing.Point(403, 41);
            this.mskDtNasc.Mask = "00/00/0000";
            this.mskDtNasc.Name = "mskDtNasc";
            this.mskDtNasc.Size = new System.Drawing.Size(137, 22);
            this.mskDtNasc.TabIndex = 7;
            this.mskDtNasc.ValidatingType = typeof(System.DateTime);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(30, 97);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(510, 22);
            this.txtNome.TabIndex = 8;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(30, 145);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 9;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(125, 145);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 10;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(222, 145);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(320, 145);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(84, 23);
            this.btnConsultar.TabIndex = 12;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(465, 145);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 13;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FrmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 190);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.mskDtNasc);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblDtNasc);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblCodigo);
            this.Name = "FrmCadastroCliente";
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.FrmCadastroCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblDtNasc;
        private System.Windows.Forms.Label lblNome;
        internal System.Windows.Forms.TextBox txtCodigo;
        internal System.Windows.Forms.MaskedTextBox mskCPF;
        internal System.Windows.Forms.MaskedTextBox mskDtNasc;
        internal System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnFechar;
    }
}