using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraTurmaTerca2020_1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // instanciando o formulário a ser aberto
            FrmCadastroCliente frmCadastroCliente = new FrmCadastroCliente();

            // informando que a janela desse form criado
            // será aberta dentro do FrmPrincipal
            frmCadastroCliente.MdiParent = this;

            // mandando o formulário ser aberto
            frmCadastroCliente.Show();

        }

        private void veículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // instanciando o formulário a ser aberto
            FrmCadastroVeiculo frmCadastroVeiculo = new FrmCadastroVeiculo();

            // informando que a janela desse form criado
            // será aberta dentro do FrmPrincipal
            frmCadastroVeiculo.MdiParent = this;

            // mandando o formulário ser aberto
            frmCadastroVeiculo.Show();

        }
    }
}
