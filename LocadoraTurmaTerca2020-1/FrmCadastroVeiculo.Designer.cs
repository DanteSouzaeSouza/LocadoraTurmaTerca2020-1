namespace LocadoraTurmaTerca2020_1
{
    partial class FrmCadastroVeiculo
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
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.mskAno = new System.Windows.Forms.MaskedTextBox();
            this.lblCor = new System.Windows.Forms.Label();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(464, 136);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(319, 136);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(84, 23);
            this.btnConsultar.TabIndex = 9;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(221, 136);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(124, 136);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(29, 136);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 6;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(319, 88);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(220, 22);
            this.txtCor.TabIndex = 5;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(29, 31);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 22);
            this.txtPlaca.TabIndex = 1;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(26, 68);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(37, 17);
            this.lblAno.TabIndex = 17;
            this.lblAno.Text = "Ano:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(340, 12);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(58, 17);
            this.lblModelo.TabIndex = 16;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Location = new System.Drawing.Point(132, 11);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(79, 17);
            this.lblFabricante.TabIndex = 15;
            this.lblFabricante.Text = "Fabricante:";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(26, 12);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(47, 17);
            this.lblPlaca.TabIndex = 14;
            this.lblPlaca.Text = "Placa:";
            // 
            // mskAno
            // 
            this.mskAno.Location = new System.Drawing.Point(29, 87);
            this.mskAno.Mask = "9999/9999";
            this.mskAno.Name = "mskAno";
            this.mskAno.Size = new System.Drawing.Size(100, 22);
            this.mskAno.TabIndex = 4;
            this.mskAno.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(317, 68);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(34, 17);
            this.lblCor.TabIndex = 28;
            this.lblCor.Text = "Cor:";
            // 
            // txtFabricante
            // 
            this.txtFabricante.Location = new System.Drawing.Point(135, 31);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.Size = new System.Drawing.Size(200, 22);
            this.txtFabricante.TabIndex = 2;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(343, 31);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(196, 22);
            this.txtModelo.TabIndex = 3;
            // 
            // FrmCadastroVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 182);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtFabricante);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.mskAno);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblFabricante);
            this.Controls.Add(this.lblPlaca);
            this.Name = "FrmCadastroVeiculo";
            this.Text = "Cadastro de Veículo";
            this.Load += new System.EventHandler(this.FrmCadastroVeiculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        internal System.Windows.Forms.TextBox txtCor;
        internal System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.Label lblPlaca;
        internal System.Windows.Forms.MaskedTextBox mskAno;
        private System.Windows.Forms.Label lblCor;
        internal System.Windows.Forms.TextBox txtFabricante;
        internal System.Windows.Forms.TextBox txtModelo;
    }
}