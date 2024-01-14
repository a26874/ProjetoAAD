using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjetoAAD
{
    public partial class InserirCliente : Form
    {
        private Interface menuInterface;
        private SqlConnection baseDadosAad;
        private static int numerosInserir = 0;
        private static bool jaDefinidoNumerosInserir = false;
        public InserirCliente()
        {
            InitializeComponent();
        }
        public InserirCliente(Interface Menu, SqlConnection conexaoBd)
        {
            InitializeComponent();
            menuInterface = Menu;
            baseDadosAad = conexaoBd;
            FormClosing += InserirCliente_FormClosing;
            CriarComboBox(comboBoxTiposContacto);
        }

        private void InserirCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            menuInterface.Show();
        }
        /// <summary>
        /// Cria item/cliques para o dropdown.
        /// </summary>
        /// <param name="aux">The aux.</param>
        /// <param name="tiposContacto">The tipos contacto.</param>
        public void CriarItem(ComboBox aux, List<ComboItem> tiposContacto)
        {
            aux.DataSource = tiposContacto;
        }
        /// <summary>
        /// Cria o dropdown com os tipos de contacto existentes.
        /// </summary>
        /// <param name="aux"></param>
        public void CriarComboBox(ComboBox aux)
        {
            SqlCommand obterDadosTipoContacto = new SqlCommand("Select TCID, DescContacto from TiposContacto", baseDadosAad);
            var adaptadorDados = new SqlDataAdapter(obterDadosTipoContacto);
            var auxDataSet = new DataSet();
            List<ComboItem> listaTipos = new List<ComboItem>();
            adaptadorDados.Fill(auxDataSet);
            foreach (DataRow linhaId in auxDataSet.Tables[0].Rows)
            {
                ComboItem c = new ComboItem();
                c.ID = (int)linhaId.ItemArray[0];
                c.Texto = (string)linhaId.ItemArray[1];
                listaTipos.Add(c);
            }
            CriarItem(aux, listaTipos);
        }
        /// <summary>
        /// Insere dados de um cliente, na base de dados.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void InserirDadosButton_Click(object sender, EventArgs e)
        {

            string nomeCliente = nomeClienteTextBox.Text;
            string ruaCliente = nomeRuaTextBox.Text;
            DateTime teste = DateTime.Now;

            SqlCommand inserirCliente = new SqlCommand($"insert into Cliente(NomeCliente, DataNascimento, Rua, CodPostal) values('{nomeCliente}', '{teste.ToString("yyyy-MM-dd HH:mm:ss")}', '{ruaCliente}', '4211-123');", baseDadosAad);
            baseDadosAad.Open();
            inserirCliente.ExecuteNonQuery();
            baseDadosAad.Close();


        }

        /// <summary>
        /// Handles the Click event of the inserirContactoButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void inserirContactoButton_Click(object sender, EventArgs e)
        {
            string nomeCliente = nomeClienteTextBox.Text;
            int valorContacto = 0;
            string tipoContacto = string.Empty;
            if (numerosInserir == 0 && !jaDefinidoNumerosInserir)
            {
                if (int.TryParse(numeroContactosTextBox.Text, out int numeroContactos))
                    numerosInserir = numeroContactos;
                jaDefinidoNumerosInserir = true;
            }
            if (numerosInserir == 0 && jaDefinidoNumerosInserir)
                return;
            List<Tuple<string, int>> listaContactosInserir = new List<Tuple<string, int>>();
            int tcId = 0;
            
            foreach (ComboItem a in comboBoxTiposContacto.Items)
            {
                if (comboBoxTiposContacto.SelectedItem.ToString() == a.Texto)
                {
                    tipoContacto = a.Texto;
                    break;
                }
            }
            if (int.TryParse(contactoTextBox.Text, out int valorContactoAux))
                valorContacto = valorContactoAux;
            Tuple<string,int> contactoInserir = new Tuple<string,int>(tipoContacto, valorContacto);
            listaContactosInserir.Add(contactoInserir);

            dataGridListaContactosInserir.DataSource = listaContactosInserir;
            dataGridListaContactosInserir.AutoGenerateColumns = true;
            dataGridListaContactosInserir.Refresh();

            //SqlCommand verificarCliente = new SqlCommand($"Select ClienteID from Cliente where NomeCliente = '{nomeCliente}';", baseDadosAad);
            //baseDadosAad.Open();
            //object idCliente = verificarCliente.ExecuteScalar();
            //if (idCliente != null)
            //    idCliente = (int)idCliente;

            //int tcId = 0;
            //foreach (ComboItem a in comboBoxTiposContacto.Items)
            //{
            //    if (comboBoxTiposContacto.SelectedItem.ToString() == a.Texto)
            //    {
            //        tcId = a.ID;
            //        break;
            //    }
            //}
            //if (int.TryParse(contactoTextBox.Text, out int valorContactoAux))
            //    valorContacto = valorContactoAux;
            //SqlCommand inserirContactos = new SqlCommand($"insert into Contacto(ClienteID, TCID, Valor) values('{idCliente}', '{tcId}','{valorContacto}')", baseDadosAad);
            //inserirContactos.ExecuteNonQuery();

            baseDadosAad.Close();
            numerosInserir--;
        }


        /// <summary>
        /// Mostra o necessário para inserir contactos.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void InserirContactosButton_Click(object sender, EventArgs e)
        {
            int numerosInserir = 0;
            if (int.TryParse(numeroContactosTextBox.Text, out int numeroContactos))
                numerosInserir = numeroContactos;
            if (numerosInserir > 0)
            {
                contactoTextBox.Show();
                ContactoLabel.Show();
                inserirContactoButton.Show();
                tiposContactoLabel.Show();
                comboBoxTiposContacto.Show();
            }
        }
    }
}
