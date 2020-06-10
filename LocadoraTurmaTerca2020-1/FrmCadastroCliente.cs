using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LocadoraTurmaTerca2020_1
{
    public partial class FrmCadastroCliente : Form
    {
        public FrmCadastroCliente()
        {
            InitializeComponent();
        }
        // subrotinas (funções, procedimentos ou métodos) ficam aqui nessa área


        //sub-rotina para habilitar os controles
        private void Habilitar()
        {
            // txtCodigo sempre será desabilitado, pois será gerado automaticamente
            txtCodigo.Enabled = false;
            //altera a propriedade Enabled dos controles para true, habilitando o controles
            txtNome.Enabled = true;
            mskCPF.Enabled = true;
            mskDtNasc.Enabled = true;
        }

        //sub-rotina para desabilitar os controles
        private void Desabilitar()
        {
            //txtCodigo sempre será desabilitado, pois será gerado automaticamente
            txtCodigo.Enabled = false;

            //altera a propriedade Enabled dos controles para ficarem desabilitados
            txtNome.Enabled = false;
            mskCPF.Enabled = false;
            mskDtNasc.Enabled = false;
        }

        // sub-rotina para limpar os controles do formulário
        // chamada quando precisamos reutilizar o formulário
        private void LimparControles()
        {
            //desabilita o TextBox
            txtCodigo.Enabled = false;

            //limpa os textos dos TextBox e MaskedTextBox
            txtNome.Clear();
            txtCodigo.Clear();
            mskCPF.Clear();
            mskDtNasc.Clear();
            //coloca o foco no mskCPF
            mskCPF.Focus();
        }

        // Função para validar os campos de entrada do form.
        // retorna True ou False dependendo da situação:
        private bool ValidaDados()
        {
            //verificar se mskCPF está preenchido, se não estiver preenchido
            if (string.IsNullOrEmpty(mskCPF.Text))
            {
                //mensagem ao usuário
                MessageBox.Show("Campo CPF é de preenchimento obrigatório!",
                    "ACR Rental Car", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                //limpa o mskCPF
                mskCPF.Clear();

                //coloca o cursor no mskCPF
                mskCPF.Focus();

                //retorna falso
                return false;
            }

            // verifica se o que foi digitado em data de nascimento é uma data válida 
            DateTime auxData; // variável auxiliar
            // se não for uma data válida ou se não digitar nenhuma data
            if (!DateTime.TryParse(mskDtNasc.Text, out auxData))
            {
                // mensagem ao usuário
                MessageBox.Show("Campo Data de Aniversário é de preenchimento obrigatório",
                    "ACR Rental Car", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // limpa o mskDtNasc
                mskDtNasc.Clear();

                // coloca o cursor no mskDtNasc
                mskDtNasc.Focus();

                // retorna falso
                return false;
            }

            // verifica se o txtNome está preenchido, Se for nulo ou vazio retorna falso
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                //mensagem ao usuário
                MessageBox.Show("Campo Nome é de preenchimento obrigatório",
                    "ACR Rental Car", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                //limpa o txtNome
                txtNome.Clear();

                //coloca o cursor no txtNome
                txtNome.Focus();

                //retorna falso
                return false;
            }

            // se todas as validações passaram no teste, retorna verdadeiro
            return true;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            // mandando fechar este Form
            Close();
        }

        private void FrmCadastroCliente_Load(object sender, EventArgs e)
        {
            // mandando os controles serem habilitados no carregamento do Form
            Habilitar();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            // Se há um código no txtCódigo, fazer:
            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                // se txtCodigo não estiver vazio, significa que já foi consultado um cliente.
                // a instrução a seguir captura se foi clicado o botão Yes (SIM) como resposta da pergunta.
                if (MessageBox.Show("Você está editando um registro existente. Deseja incluir um registro novo?",
                    "ACR Rental Car",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                    LimparControles();
                return; //encerra a sub-rotina
            }

            // antes de incluir é preciso validar os dados de preenchimento obrigatório
            // chama o método para validar a entrada de dados
            // se retornou falso, interrompe o processamento para incluir no banco de dados

            if (ValidaDados() == false) return; //interrompe a sub-rotina

            //cria conexão chamando o método getConnection da classe Conexao
            var conCliente = Conexao.GetConnection();

            //cria a instrução sql, parametrizada
            var sqlQuery = "INSERT INTO cliente(nome,data_nasc,cpf) VALUES(@nome,@data_nasc,@cpf)";

            //Tratamento de exceções
            try
            {
                //abre a conexão com o banco de dados
                conCliente.Open();

                //cria um objeto do tipo SqlCommand com a instrução SQL e a conexão
                var cmd = new SqlCommand(sqlQuery, conCliente);

                // fazendo o binding (ligação) dos elementos da
                // string SQL com os dados dos controles do Form
                cmd.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
                cmd.Parameters.Add(new SqlParameter("@data_nasc", Convert.ToDateTime(mskDtNasc.Text)));
                cmd.Parameters.Add(new SqlParameter("@cpf", mskCPF.Text));

                // executa o commando
                // ExecuteNonQuery envia instruções para o banco de dados que estão em cmd
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente incluído com sucesso!",
                    "ACR Rental Car",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                //Limpa os campos para nova entrada de dados
                LimparControles();
            }
            catch (Exception ex) // se houve alguma exceção dentro do bloco try
            {
                MessageBox.Show("Problema ao incluir cliente: " + ex,
                    "ACR Rental Car",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            finally // independente se houve exceção ou não do bloco try é sempre executado
            {
                //se conexão não for nula, fecha conexão
                if (conCliente != null) conCliente.Close();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // os campos para serem alterados são preenchidos
            // por meio da consulta no grid do form Consulta de Cliente
            // verifica se tem o código do cliente no txtCodigo.
            // Se o campo estiver vazio, interrompe a sub-rotina
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Consulte o cliente que deseja alterar clicando no botão Consultar!",
                    "ACR Rental Car",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return; // interrompe a sub-rotina
            }

            // antes de alterar o registro é preciso validar
            // os dados de preenchimento obrigatório
            // chama o método para validar a entrada de dados
            // se retornou falso, interrompe o processamento
            if (ValidaDados() == false) return;

            //cria conexão chamando o método getConnection da classe Conexao
            var conCliente = Conexao.GetConnection();

            //cria a instrução sql, parametrizada
            const string sqlQuery =
                "UPDATE cliente SET nome=@nome, data_nasc=@data_nasc, cpf=@cpf WHERE id_cliente=@id_cliente";

            // Tratamento de exceções 
            // códigos semelhantes ao botão inserir com diferença na instrução SQL
            try
            {
                conCliente.Open();
                var cmd = new SqlCommand(sqlQuery, conCliente);
                //define, adiciona os parametros
                cmd.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
                cmd.Parameters.Add(new SqlParameter("@data_nasc", Convert.ToDateTime(mskDtNasc.Text)));
                cmd.Parameters.Add(new SqlParameter("@cpf", mskCPF.Text));
                cmd.Parameters.Add(new SqlParameter("@id_cliente", Convert.ToInt32(txtCodigo.Text)));

                //executa o comando
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente atualizado com sucesso!",
                    "ACR Rental Car",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                //Limpa os campos para nova entrada de dados
                LimparControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema ao atualizar cliente: " + ex,
                    "ACR Rental Car",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            finally
            {
                if (conCliente != null) conCliente.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //verifica se tem o código do cliente no txtCodigo
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Consulte o cliente que deseja excluir clicando no botão consultar!",
                    "ACR Rental Car",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                return;
            }

            //solicita confirmação de exclusão de registro
            if (MessageBox.Show("Deseja excluir permanentemente o registro?", 
                "ACR Rental Car",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //cria conexão chamando o método getConnection da classe Conexao
                var conCliente = Conexao.GetConnection();

                //cria a instrução sql, parametrizada
                const string sqlQuery = "DELETE FROM cliente WHERE id_cliente=@id_cliente";

                //Tratamento de exceções
                try
                {
                    conCliente.Open();
                    var cmd = new SqlCommand(sqlQuery, conCliente);

                    //define, adiciona os parametros
                    cmd.Parameters.Add(new SqlParameter("@id_cliente", Convert.ToInt32(txtCodigo.Text)));

                    //executa o commando
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cliente excluído com sucesso!",
                        "ACR Rental Car", 
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    //Limpa os campos para nova entrada de dados
                    LimparControles();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problema ao excluir cliente: " + ex,
                        "ACR Rental Car",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                finally
                {
                    if (conCliente != null) conCliente.Close();
                }
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Instanciando um objeto do tipo FrmConsultaCliente
            var frmConsultaCliente = new FrmConsultaCliente(this) {MdiParent = this.MdiParent};

            // Definindo quem é a janela-pai do novo Form

            // mandando abrir o novo form
            frmConsultaCliente.Show();

        }
    }
}