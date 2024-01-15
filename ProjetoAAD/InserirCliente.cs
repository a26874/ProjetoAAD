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
        private static List<Tuple<int, string, string>> listaContactosInserir = new List<Tuple<int, string, string>>();

        public InserirCliente()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Construtor por parametros.
        /// </summary>
        /// <param name="Menu"></param>
        /// <param name="conexaoBd"></param>
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
            string tipoContacto = string.Empty;
            ////Fixo
            SqlCommand inserirCliente = new SqlCommand($"insert into Cliente(NomeCliente, DataNascimento, Rua, CodPostal) output inserted.clienteID values('{nomeCliente}', '{teste.ToString("yyyy-MM-dd HH:mm:ss")}', '{ruaCliente}', '4211-123');", baseDadosAad);

            //Portatil
            //SqlCommand inserirCliente = new SqlCommand($"insert into Cliente(NomeCliente, DataNascimento, Rua, CodPostal) values('{nomeCliente}', '{teste.ToString("yyyy-MM-dd HH:mm:ss")}', '{ruaCliente}', '4211-123');", baseDadosAad);
            baseDadosAad.Open();
            int idCliente= (int)inserirCliente.ExecuteScalar();
            inserirCliente.ExecuteNonQuery();

            
            foreach (Tuple<int,string,string> s in listaContactosInserir)
            {
                SqlCommand inserirContactos = new SqlCommand($"insert into Contacto(ClienteID, TCID, Valor) values('{idCliente}', '{s.Item1}','{s.Item3}')", baseDadosAad);
                inserirContactos.ExecuteNonQuery();
            }
            baseDadosAad.Close();
            Close();
            menuInterface.Show();
        }

        /// <summary>
        /// Handles the Click event of the inserirContactoButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void inserirContactoButton_Click(object sender, EventArgs e)
        {
            string valorContacto = contactoTextBox.Text;
            string tipoContacto = string.Empty;
            int tcID = 0;
            if (numerosInserir == 0 && !jaDefinidoNumerosInserir)
            {
                if (int.TryParse(numeroContactosTextBox.Text, out int numeroContactos))
                    numerosInserir = numeroContactos;
                jaDefinidoNumerosInserir = true;
            }

            foreach (ComboItem a in comboBoxTiposContacto.Items)
            {
                if (comboBoxTiposContacto.SelectedItem.ToString() == a.Texto)
                {
                    tipoContacto = a.Texto;
                    tcID = a.ID;
                    break;
                }
            }
            Tuple<int,string, string> contactoInserir = new Tuple<int,string, string>(tcID,tipoContacto, valorContacto);
            
            listaContactosInserir.Add(contactoInserir);
            contactoInseridoSucessoLabel.Show();
            contactoInseridoSucessoLabel.Text = $"Contacto {valorContacto} inserido com sucesso na lista.";
            baseDadosAad.Close();
            numerosInserir--;
            if (numerosInserir == 0 && jaDefinidoNumerosInserir)
            {
                contactoTextBox.Hide();
                ContactoLabel.Hide();
                inserirContactoButton.Hide();
                tiposContactoLabel.Hide();
                comboBoxTiposContacto.Hide();
                jaDefinidoNumerosInserir = false;
                numeroContactosTextBox.Text = null;
                contactoInseridoSucessoLabel.Text = "Todos os contactos inseridos.";
                contactoTextBox.Text = null;
                dataGridListaInserirContactos.DataSource = null;
                dataGridListaInserirContactos.Columns.Clear();
                List<Tuple<string, string>> listaContactosInserirAux = new List<Tuple<string, string>>();
                foreach(var contactoAux in listaContactosInserir)
                {
                    listaContactosInserirAux.Add(new Tuple<string,string>(contactoAux.Item2, contactoAux.Item3));
                }
                dataGridListaInserirContactos.DataSource = listaContactosInserirAux;
                dataGridListaInserirContactos.AutoGenerateColumns = true;
                dataGridListaInserirContactos.AutoSize = true;
                dataGridListaInserirContactos.Refresh();
                return;
            }
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
