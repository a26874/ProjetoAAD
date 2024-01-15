using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjetoAAD
{
    public partial class AlterarDados : Form
    {
        private Interface menuInterface;
        private SqlConnection baseDadosAad;
        private string nomeOriginal;
        private string ruaOriginal;
        private string codPostalOriginal;
        /// <summary>
        /// Construtor por defeito.
        /// </summary>
        public AlterarDados()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Construtor com parametros.
        /// </summary>
        /// <param name="auxInterface">The aux interface.</param>
        /// <param name="auxConnection">The aux connection.</param>
        public AlterarDados(Interface auxInterface, SqlConnection auxConnection)
        {
            InitializeComponent();
            menuInterface = auxInterface;
            baseDadosAad = auxConnection;
        }

        /// <summary>
        /// Mostra os dados na datagrid, acerca de uma tabela.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void mostrarDadosButton_Click(object sender, System.EventArgs e)
        {
            string tabelaMostrar = tabelaAlterarTextBox.Text;

            SqlCommand mostrarTabelaCommand = new SqlCommand($"Select NomeCliente, Rua, CodPostal from {tabelaMostrar}", baseDadosAad);

            SqlDataAdapter adaptadorDados = new SqlDataAdapter(mostrarTabelaCommand);
            DataTable auxDataTable = new DataTable();

            adaptadorDados.Fill(auxDataTable);

            dataGridSelecionarLinha.DataSource = auxDataTable;
            dataGridSelecionarLinha.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridSelecionarLinha.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridSelecionarLinha.Show();
        }

        /// <summary>
        /// Seleciona os dados a alterar.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void selecionarDadosButton_Click(object sender, System.EventArgs e)
        {
            int indexLinha = dataGridSelecionarLinha.SelectedRows[0].Index;
            DataGridViewRow linha = dataGridSelecionarLinha.Rows[indexLinha];



            nomeClienteAlterarTextBox.Text = Convert.ToString(linha.Cells["NomeCliente"].Value);
            nomeOriginal = nomeClienteAlterarTextBox.Text;
            
            ruaAlterarTextBox.Text = Convert.ToString(linha.Cells["Rua"].Value);
            ruaOriginal = ruaAlterarTextBox.Text;

            alterarCodPostalTextBox.Text = Convert.ToString(linha.Cells["CodPostal"].Value);
            codPostalOriginal = alterarCodPostalTextBox.Text;
        }

        /// <summary>
        /// Mostra os codigos postais.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mostrarCodigosPostaisDisponiveisButton_Click(object sender, EventArgs e)
        {
            SqlCommand mostrarCodigosPostais = new SqlCommand("Select CodPostal from CodigoPostal",baseDadosAad);
            SqlDataAdapter adptadorDados = new SqlDataAdapter(mostrarCodigosPostais);
            DataTable auxDataTable = new DataTable();

            adptadorDados.Fill(auxDataTable);

            dataGridCodigosPostais.DataSource = auxDataTable;
            dataGridSelecionarLinha.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridSelecionarLinha.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridCodigosPostais.AutoSize = true;
            dataGridCodigosPostais.Show();
            codigoPostaisDisponiveisLabel.Show();
        }

        /// <summary>
        /// Conforme os dados inseridos, eles são alterados na base de dados.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void alterarDadosButton_Click(object sender, EventArgs e)
        {
            string tabelaMostrar = tabelaAlterarTextBox.Text;
            if(nomeOriginal == nomeClienteAlterarTextBox.Text || codPostalOriginal == alterarCodPostalTextBox.Text || ruaOriginal == ruaAlterarTextBox.Text)
            {
                MessageBox.Show("Necessita de fazer alguma alteração de dados.");
                return;
            }

            
            string nomeAlterar = nomeClienteAlterarTextBox.Text;
            string ruaAlterar = ruaAlterarTextBox.Text;
            string codPostalAlterar = alterarCodPostalTextBox.Text;
            SqlCommand verificarCliente = new SqlCommand($"Select ClienteID from Cliente where NomeCliente = '{nomeOriginal}';", baseDadosAad);
            baseDadosAad.Open();
            object idCliente = verificarCliente.ExecuteScalar();
            if (idCliente != null)
                idCliente = (int)idCliente;

            SqlCommand alterarDados = new SqlCommand($"Update {tabelaMostrar} set NomeCliente = '{nomeAlterar}', Rua = '{ruaAlterar}', CodPostal='{codPostalAlterar}' where " +
                $"ClienteID = {idCliente}", baseDadosAad);

            alterarDados.ExecuteNonQuery();
            alteradoComSucessoLabel.Text = "Cliente alterado com sucesso.";
            baseDadosAad.Close();
        }
    }
}
