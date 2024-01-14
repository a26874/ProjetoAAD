using System;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetoAAD
{
    public partial class Interface : Form
    {
        private SQL baseDados;
        private SqlConnection baseDadosConection;
        public Interface()
        {
            InitializeComponent();
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
    }
}
