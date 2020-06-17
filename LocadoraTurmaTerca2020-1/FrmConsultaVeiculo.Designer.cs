namespace LocadoraTurmaTerca2020_1
{
    partial class FrmConsultaVeiculo
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.dgvVeiculo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(615, 420);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(13, 420);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(115, 23);
            this.btnSelecionar.TabIndex = 4;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // dgvVeiculo
            // 
            this.dgvVeiculo.AllowDrop = true;
            this.dgvVeiculo.AllowUserToAddRows = false;
            this.dgvVeiculo.AllowUserToDeleteRows = false;
            this.dgvVeiculo.AllowUserToOrderColumns = true;
            this.dgvVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeiculo.Location = new System.Drawing.Point(12, 12);
            this.dgvVeiculo.Name = "dgvVeiculo";
            this.dgvVeiculo.ReadOnly = true;
            this.dgvVeiculo.RowTemplate.Height = 24;
            this.dgvVeiculo.Size = new System.Drawing.Size(711, 390);
            this.dgvVeiculo.TabIndex = 3;
            // 
            // FrmConsultaVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 455);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.dgvVeiculo);
            this.Name = "FrmConsultaVeiculo";
            this.Text = "Consulta de Veículos";
            this.Load += new System.EventHandler(this.FrmConsultaVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSelecionar;
        internal System.Windows.Forms.DataGridView dgvVeiculo;
    }
}