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
            //fixo:
            baseDados = new SQL("DESKTOP-4IUUJPT", "DESKTOP-4IUUJPT\\marco", "ImobiliariaMDG");
            
            //portatil:
            //baseDados = new SQL("MARCO\\MARCO","MARCO\\marco","ProjetoAAD");
            if (baseDados.Conectar())
                MessageBox.Show("Conectado");
            else
                MessageBox.Show("Falha na conexão");
            
            
            FormClosing += Interface_FormClosing;
            baseDados.CriarDropDown(selecioneToolStripMenuItem);

            Timer t1 = new Timer();
            t1.Interval = 5000;
            t1.Tick += T1_Tick;
        }

        private void T1_Tick(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem s in selecioneToolStripMenuItem.DropDownItems)
            {
                if (s.Name == "TelefonedropDown" && s.Pressed)
                {
                    selecioneToolStripMenuItem.Text = s.Text;
                }
                Application.DoEvents();
            }
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

        private void selecioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
