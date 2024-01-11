using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAAD
{
    public partial class InserirCliente : Form
    {
        private Interface menuInterface;
        private SqlConnection baseDadosAad;
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
        private void InserirDadosButton_Click(object sender, EventArgs e)
        {

            string nomeCliente = nomeClienteTextBox.Text;
            string ruaCliente = nomeRuaTextBox.Text;
            DateTime teste = DateTime.Now;

            SqlCommand inserirCliente = new SqlCommand($"insert into Cliente(NomeCliente, DataNascimento, Rua, CodPostal) values('{nomeCliente}', '{teste}', '{ruaCliente}', '4211-123');", baseDadosAad);
            baseDadosAad.Open();
            inserirCliente.ExecuteNonQuery();
            object a = inserirCliente.ExecuteScalar();
            baseDadosAad.Close();


        }
    }
}
