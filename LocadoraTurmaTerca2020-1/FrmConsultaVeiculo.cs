using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LocadoraTurmaTerca2020_1
{
    public partial class FrmConsultaVeiculo : Form
    {
        private readonly FrmCadastroVeiculo frmCadastroVeiculo;

        public FrmConsultaVeiculo(FrmCadastroVeiculo frmCadastroVeiculo)
        {
            // passando o valor recebido no parâmetro para dentro de uma variável deste form
            this.frmCadastroVeiculo = frmCadastroVeiculo;

            InitializeComponent();
        }

        private void FrmConsultaVeiculo_Load(object sender, System.EventArgs e)
        {
            const string sqlQuery = "SELECT * FROM veiculo ORDER BY fabricante ASC";

            var conVeiculo = Conexao.GetConnection();

            var dataAdapter = new SqlDataAdapter(sqlQuery, conVeiculo);

            var dataTable = new DataTable();

            try
            {
                dataAdapter.Fill(dataTable);

                dgvVeiculo.DataSource = dataTable;

                dgvVeiculo.RowsDefaultCellStyle.BackColor = Color.Bisque;
                dgvVeiculo.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;

                dgvVeiculo.Columns[0].HeaderCell.Value = "PLACA";
                dgvVeiculo.Columns[1].HeaderCell.Value = "FABRICANTE";
                dgvVeiculo.Columns[2].HeaderCell.Value = "MODELO";
                dgvVeiculo.Columns[3].HeaderCell.Value = "ANO";
                dgvVeiculo.Columns[3].DefaultCellStyle.Format = "####/####";
                dgvVeiculo.Columns[4].HeaderCell.Value = "COR";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema ao listar registros: " + ex,
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

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            // criando variável para captar a placa do veículo
            var placaVeiculo = dgvVeiculo.CurrentRow.Cells[0].Value.ToString();

            const string sqlQuery = "SELECT * FROM veiculo WHERE placa=@placa";

            SqlDataReader dataReader = null;

            var conVeiculo = Conexao.GetConnection();

            try
            {
                // abrindo conexão
                conVeiculo.Open();

                // Criando um SqlCommand
                var command = new SqlCommand(sqlQuery, conVeiculo);

                // fazendo Binding dos elemento do form com os parâmetros SQL
                command.Parameters.Add("@placa", placaVeiculo);

                // executando o comando
                dataReader = command.ExecuteReader();

                if (dataReader.Read())
                {
                    frmCadastroVeiculo.txtPlaca.Text = dataReader["PLACA"].ToString();
                    frmCadastroVeiculo.txtFabricante.Text = dataReader["FABRICANTE"].ToString();
                    frmCadastroVeiculo.txtModelo.Text = dataReader["MODELO"].ToString();
                    frmCadastroVeiculo.mskAno.Text = dataReader["ANO"].ToString();
                    frmCadastroVeiculo.txtCor.Text = dataReader["COR"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema ao carregar registro: " + ex,
                    "ACR Rental Car",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            finally
            {
                //se conexão não for nula, fecha conexão
                dataReader?.Close();
                conVeiculo?.Close();
            }
            this.Close();
        }
    }
}