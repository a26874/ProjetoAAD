using System;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace ProjetoAAD
{
    public partial class Interface : Form
    {
        private SQL baseDados;
        private SqlConnection baseDadosConection;
        public Interface()
        {
            InitializeComponent();
            //Goncalo:
            //baseDados = new SQL("GONCALO", "GONCALO\\gonca", "projeto", out baseDadosConection);


            //fixo:
            baseDados = new SQL("DESKTOP-4IUUJPT", "DESKTOP-4IUUJPT\\marco", "ImobiliariaMDG", out baseDadosConection);

            //portatil:
            //baseDados = new SQL("MARCO\\MARCO", "MARCO\\marco", "ProjetoAAD", out baseDadosConection);
            if (baseDados.Conectar())
                MessageBox.Show("Conectado");
            else
            {
                MessageBox.Show("Falha na conexão");
                Application.Exit();
            }
            
            
            FormClosing += Interface_FormClosing;
            //baseDados.CriarComboBox(comboBoxTiposContacto);

        }

        /// <summary>
        /// Quando a aplicação encerrar será fechada a conexão.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Interface_FormClosing(object sender, FormClosingEventArgs e)
        {
            baseDados.FecharConexao();
        }

        /// <summary>
        /// Ao clicar no botão, insere dados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InserirDadosButton_Click(object sender, EventArgs e)
        {
            baseDados.InsereDados(this);
            InserirCliente novoCliente = new InserirCliente(this, baseDadosConection);
            novoCliente.Show();
            Hide();

        }
        /// <summary>
        /// Ao clicar no botão, mostra dados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MostrarDadosButton_Click(object sender, EventArgs e)
        {
            dataGridDados.DataSource = null;
            string aux = string.Empty;

            aux = MostrarBDTextBox.Text;
            baseDados.MostrarDados(aux,dataGridDados);

        }

        /// <summary>
        /// Abre uma nova interface para alterar dados.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void alterarDadosButton_Click(object sender, EventArgs e)
        {
            AlterarDados novoAlterarDados = new AlterarDados(this, baseDadosConection);
            novoAlterarDados.Show();
            Hide();
        }


        /// <summary>
        /// Ao clicar no botao, faz a query
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryButton_Click(object sender, EventArgs e)
        {
            baseDadosConection.Open();

            string query = "SELECT CP.Localidade, COUNT(C.ClienteID) AS NumeroClientes " +
                            "FROM CodigoPostal CP " +
                            "JOIN Cliente C ON CP.CodPostal = C.CodPostal " +
                            "GROUP BY CP.Localidade;";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, baseDadosConection);

            DataTable dataTable = new DataTable();

            // Preenche o DataTable com os dados do SqlDataAdapter
            dataAdapter.Fill(dataTable);

            // Fecha a conexão com o banco de dados após o preenchimento do DataTable
            baseDadosConection.Close();

            // Exibe os resultados, por exemplo, em um DataGridView
            dataGridDados.DataSource = dataTable;
        }
        /// <summary>
        /// Executa a stored procedure e apaga todos os contactos e o cliente.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void apagarValoresButton_Click(object sender, EventArgs e)
        {

        }




        private void Interface_Load(object sender, EventArgs e)
        {

        }

    }
}
