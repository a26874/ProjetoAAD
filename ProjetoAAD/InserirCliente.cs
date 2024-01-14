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
        private static List<Tuple<string, string>> listaContactosInserir = new List<Tuple<string, string>>();

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

            ////Fixo
            //SqlCommand inserirCliente = new SqlCommand($"insert into Cliente(NomeCliente, DataNascimento, Rua, CodPostal) values('{nomeCliente}', '{teste.ToString("yyyy-MM-dd HH:mm:ss")}', '{ruaCliente}', '4211-123');", baseDadosAad);

            //Portatil
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
            string valorContacto = contactoTextBox.Text;
            string tipoContacto = string.Empty;
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
                    break;
                }
            }
            Tuple<string, string> contactoInserir = new Tuple<string, string>(tipoContacto, valorContacto);
            
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
                dataGridListaInserirContactos.DataSource = listaContactosInserir;
                dataGridListaInserirContactos.AutoGenerateColumns = true;
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

        /// <summary>
        /// Insere o contacto selecionado na base de dados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inserirBDButton_Click(object sender, EventArgs e)
        {
            string nomeCliente = nomeClienteInserirContactosTextBox.Text;
            SqlCommand verificarCliente = new SqlCommand($"Select ClienteID from Cliente where NomeCliente = '{nomeCliente}';", baseDadosAad);
            baseDadosAad.Open();
            object idCliente = verificarCliente.ExecuteScalar();
            if (idCliente != null)
                idCliente = (int)idCliente;
            int indexLinha = dataGridListaInserirContactos.SelectedRows[0].Index;
            DataGridViewRow linha = dataGridListaInserirContactos.Rows[indexLinha];
            string tipoContacto = Convert.ToString(linha.Cells["Item1"].Value);
            string valorContacto = Convert.ToString(linha.Cells["Item2"].Value);
            int tcID = 0;
            foreach (ComboItem a in comboBoxTiposContacto.Items)
            {
                if (a.Texto == tipoContacto)
                {
                    tcID = a.ID;
                    break;
                }
            }
            ObterTipoDeContactos(valorContacto, tcID, out int contactoInserir, out string contactoEmailInserir);

            ////Fixo
            if (contactoInserir != 0)
            {
                SqlCommand inserirContactos = new SqlCommand($"insert into Contacto(ClienteID, TCID, Valor) values('{idCliente}', '{tcID}','{contactoInserir}')", baseDadosAad);
                inserirContactos.ExecuteNonQuery();
            }
            else
            {
                SqlCommand inserirContactos = new SqlCommand($"insert into Contacto(ClienteID, TCID, Valor) values('{idCliente}', '{tcID}','{contactoEmailInserir}')", baseDadosAad);
                inserirContactos.ExecuteNonQuery();
            }



            //Portatil
            //SqlCommand inserirContactos = new SqlCommand($"insert into Contacto(ClienteID, TCID, ValorContacto) values('{idCliente}', '{tcId}','{valorContacto}')", baseDadosAad);

            baseDadosAad.Close();

        }

        /// <summary>
        /// Conforme o tipo de contactos existentes, vai verificar o seu tipo e mudar para inteiro/string.
        /// </summary>
        /// <param name="tipoContacto"></param>
        /// <param name="valorContacto"></param>
        /// <param name="tcID"></param>
        public bool ObterTipoDeContactos(string valorContacto, int tcID, out int contactoInserirAux, out string contactoEmailInserirAux)
        {
            int aux = 0;
            switch (tcID)
            {
                case 1:
                    if (int.TryParse(valorContacto, out aux))
                    {
                        contactoInserirAux = aux;
                        contactoEmailInserirAux = string.Empty;
                        return true;
                    }
                    break;

                case 2:
                    if (int.TryParse(valorContacto, out aux))
                    {
                        contactoInserirAux = aux;
                        contactoEmailInserirAux = string.Empty;
                        return true;
                    }
                    break;
                case 3:
                    contactoInserirAux = 0;
                    contactoEmailInserirAux = valorContacto;
                    return true;
                case 4:
                    if (int.TryParse(valorContacto, out aux))
                    {
                        contactoInserirAux = aux;
                        contactoEmailInserirAux = string.Empty;
                        return true;
                    }
                    break;
            }
            contactoInserirAux = 0;
            contactoEmailInserirAux = string.Empty;
            return false;
        }
    }
}
