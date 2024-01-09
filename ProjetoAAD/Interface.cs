using System;
using System.Windows.Forms;

namespace ProjetoAAD
{
    public partial class Interface : Form
    {
        private SQL baseDados;
        public Interface()
        {
            InitializeComponent();

            baseDados = new SQL("MARCO\\MARCO","MARCO\\marco","ProjetoAAD");
            if (baseDados.Conectar())
                MessageBox.Show("Conectado");
            else
                MessageBox.Show("Falha na conexão");
            
            
            FormClosing += Interface_FormClosing;
            baseDados.CriarDropDown(selecioneToolStripMenuItem);
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
            baseDados.InsereDados();
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

        
    }
}
