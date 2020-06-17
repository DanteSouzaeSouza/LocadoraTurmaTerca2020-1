using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraTurmaTerca2020_1
{
    public partial class FrmCadastroVeiculo : Form
    {
        public FrmCadastroVeiculo()
        {
            InitializeComponent();
        }


        // métodos multiuso:

        private void Habilitar()
        {
            txtPlaca.Enabled = true;
            txtFabricante.Enabled = true;
            txtModelo.Enabled = true;
            mskAno.Enabled = true;
            txtCor.Enabled = true;

        }

        private void Desabilitar()
        {
            txtPlaca.Enabled = false;
            txtFabricante.Enabled = false;
            txtModelo.Enabled = false;
            mskAno.Enabled = false;
            txtCor.Enabled = false;
        }


        private void LimparControles()
        {
            txtPlaca.Clear();
            txtFabricante.Clear();
            txtModelo.Clear();
            mskAno.Clear();
            txtCor.Clear();
        }

        private bool ValidaDados()
        {
            //verificar se txtPlaca está preenchido, se não estiver preenchido
            if (string.IsNullOrEmpty(txtPlaca.Text))
            {
                //mensagem ao usuário
                MessageBox.Show("Campo Placa é de preenchimento obrigatório!",
                    "ACR Rental Car", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                //limpa o txtPlaca
                txtPlaca.Clear();

                //coloca o cursor no txtPlaca
                txtPlaca.Focus();

                //retorna falso
                return false;
            }

            //verificar se txtFabricante está preenchido, se não estiver preenchido
            if (string.IsNullOrEmpty(txtFabricante.Text))
            {
                //mensagem ao usuário
                MessageBox.Show("Campo Fabricante é de preenchimento obrigatório!",
                    "ACR Rental Car", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                //limpa o txtFabricante
                txtFabricante.Clear();

                //coloca o cursor no txtFabricante
                txtFabricante.Focus();

                //retorna falso
                return false;
            }

            //verificar se txtModelo está preenchido, se não estiver preenchido
            if (string.IsNullOrEmpty(txtModelo.Text))
            {
                //mensagem ao usuário
                MessageBox.Show("Campo Modelo é de preenchimento obrigatório!",
                    "ACR Rental Car", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                //limpa o txtModelo
                txtModelo.Clear();

                //coloca o cursor no txtModelo
                txtModelo.Focus();

                //retorna falso
                return false;
            }

            //verificar se mskAno está preenchido, se não estiver preenchido
            if (string.IsNullOrEmpty(mskAno.Text))
            {
                //mensagem ao usuário
                MessageBox.Show("Campo Ano é de preenchimento obrigatório!",
                    "ACR Rental Car", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                //limpa o mskAno
                mskAno.Clear();

                //coloca o cursor no mskAno
                mskAno.Focus();

                //retorna falso
                return false;
            }

            //verificar se txtCor está preenchido, se não estiver preenchido
            if (string.IsNullOrEmpty(txtCor.Text))
            {
                //mensagem ao usuário
                MessageBox.Show("Campo Cor é de preenchimento obrigatório!",
                    "ACR Rental Car", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                //limpa o txtCor
                txtCor.Clear();

                //coloca o cursor no txtCor
                txtCor.Focus();

                //retorna falso
                return false;
            }
            // se todas as validações passaram no teste, retorna verdadeiro
            return true;
        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCadastroVeiculo_Load(object sender, EventArgs e)
        {
            Habilitar();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            // se houver algum capo vazio, pare tudo
            if (ValidaDados() == false) return;

            const string sqlQuery = "INSERT INTO veiculo VALUES (@placa, @fabricante, @modelo, @ano, @cor)";

            var conVeiculo = Conexao.GetConnection();

            try
            {
                // abrindo conexão
                conVeiculo.Open();

                // Criando um SqlCommand
                var command = new SqlCommand(sqlQuery, conVeiculo);

                // fazendo Binding dos elemento do form com os parâmetros SQL
                command.Parameters.Add("@placa", txtPlaca.Text);
                command.Parameters.Add("@fabricante", txtFabricante.Text);
                command.Parameters.Add("@modelo", txtModelo.Text);
                command.Parameters.Add("@ano", Convert.ToInt32(mskAno.Text));
                command.Parameters.Add("@cor", txtCor.Text);

                // executando o comando
                command.ExecuteNonQuery();

                MessageBox.Show("Registro incluso com sucesso! ",
                    "ACR Rental Car",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // limpando os controles
                LimparControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema ao incluir registro: " + ex,
                    "ACR Rental Car", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            finally
            {
                //se conexão não for nula, fecha conexão
                conVeiculo?.Close();
            }



        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // Verificando se há dados a alterar
            if (string.IsNullOrEmpty(txtPlaca.Text))
            {
                MessageBox.Show("Consulte o veículo que deseja alterar clicando no botão Consultar!",
                    "ACR Rental Car",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return; // interrompe a sub-rotina
            }


            // se houver algum capo vazio, pare tudo
            if (ValidaDados() == false) return;


            const string sqlQuery = "UPDATE veiculo SET placa=@placa, fabricante=@fabricante, modelo=@modelo, ano=@ano, cor=@cor WHERE placa=@placa";

            var conVeiculo = Conexao.GetConnection();

            try
            {
                // abrindo conexão
                conVeiculo.Open();

                // Criando um SqlCommand
                var command = new SqlCommand(sqlQuery, conVeiculo);

                // fazendo Binding dos elemento do form com os parâmetros SQL
                command.Parameters.Add("@placa", txtPlaca.Text);
                command.Parameters.Add("@fabricante", txtFabricante.Text);
                command.Parameters.Add("@modelo", txtModelo.Text);
                command.Parameters.Add("@ano", Convert.ToInt32(mskAno.Text));
                command.Parameters.Add("@cor", txtCor.Text);

                // executando o comando
                command.ExecuteNonQuery();

                MessageBox.Show("Veículo alterado com sucesso! ",
                    "ACR Rental Car",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // limpando os controles
                LimparControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema ao alterar registro: " + ex,
                    "ACR Rental Car",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            finally
            {
                //se conexão não for nula, fecha conexão
                conVeiculo?.Close();
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Verificando se há dados a excluir
            if (string.IsNullOrEmpty(txtPlaca.Text))
            {
                MessageBox.Show("Consulte o veículo que deseja excluir clicando no botão Consultar!",
                    "ACR Rental Car",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return; // interrompe a sub-rotina
            }


            // se houver algum capo vazio, pare tudo
            if (ValidaDados() == false) return;


            const string sqlQuery = "DELETE FROM veiculo WHERE placa=@placa";

            var conVeiculo = Conexao.GetConnection();

            try
            {
                // abrindo conexão
                conVeiculo.Open();

                // Criando um SqlCommand
                var command = new SqlCommand(sqlQuery, conVeiculo);

                // fazendo Binding dos elemento do form com os parâmetros SQL
                command.Parameters.Add("@placa", txtPlaca.Text);

                // executando o comando
                command.ExecuteNonQuery();

                MessageBox.Show("Veículo excluído com sucesso! ",
                    "ACR Rental Car",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // limpando os controles
                LimparControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema ao excluir registro: " + ex,
                    "ACR Rental Car",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            finally
            {
                //se conexão não for nula, fecha conexão
                conVeiculo?.Close();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // cria uma instãncia do form de consulta e passa o form atual como parâmetro
            var frmConsulta = new FrmConsultaVeiculo(this);
            // dizendo que a janela pai do formulário novo é a mesma do atual
            frmConsulta.MdiParent = this.MdiParent;
            // mandando mostrar o novo Form
            frmConsulta.Show();

        }
    }
}
