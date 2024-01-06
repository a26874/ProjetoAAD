/*
*	<copyright file="SQL" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2024 1/4/2024 4:21:55 PM</date>
*	<description></description>
**/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjetoAAD
{
    public class SQL
    {
        #region ATRIBUTOS
        private SqlConnection baseDadosAad;
        #endregion

        
        #region COMPORTAMENTO

        #region CONSTRUTORES

        /// <summary>
        /// Construtor com parametros
        /// </summary>
        /// <param name="source"></param>
        /// <param name="user"></param>
        /// <param name="catalog"></param>
        public SQL(string source, string user, string catalog)
        {
            SqlConnectionStringBuilder novaConexao = new SqlConnectionStringBuilder();
            novaConexao.DataSource = source;
            novaConexao.UserID = user;
            novaConexao.IntegratedSecurity = true;
            novaConexao.InitialCatalog = catalog;
            baseDadosAad = new SqlConnection(novaConexao.ConnectionString);
        }
        #endregion

        #region PROPRIEDADES

        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS
        /// <summary>
        /// Conexão à base de dados
        /// </summary>
        /// <returns></returns>
        public bool Conectar()
        {
            try
            {
                baseDadosAad.Open();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }
        /// <summary>
        /// Fechar conexão à base de dados
        /// </summary>
        public void FecharConexao()
        {
            baseDadosAad.Close();
        }

        /// <summary>
        /// Insere dados em tabelas.
        /// </summary>
        /// <param name="nomeTabela"></param>
        /// <returns></returns>
        public bool InsereDados()
        {
            List<string> listaComandos = new List<string>();

            listaComandos.Add("insert into CodigoPostal(CodPostal, Localidade) values('4211-123','asdasd');");
            listaComandos.Add("insert into TiposContacto(DescContacto) values ('Telemovel');");
            listaComandos.Add("insert into TiposContacto(DescContacto) values ('Telefone');");
            listaComandos.Add("insert into TiposContacto(DescContacto) values ('Email');");
            listaComandos.Add("insert into TiposContacto(DescContacto) values ('Fax');");
            SqlCommand inserirDados = new SqlCommand();
            foreach (string comando in listaComandos)
            {
                inserirDados.CommandText = comando;
                inserirDados.Connection = baseDadosAad;
                try
                {
                    inserirDados.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    
                }
            }
            //SqlCommand inserirDados = new SqlCommand("insert into CodigoPostal (CodPostal, Localidade) values ('4211-123','asdasd');",baseDadosAad);
            //inserirDados = new SqlCommand("insert into TipoContacto (TCID, DescContacto) values (1,'Telemovel');", baseDadosAad);
            //inserirDados = new SqlCommand("insert into TipoContacto (TCID, DescContacto) values (2,'Telefone');", baseDadosAad);
            //inserirDados = new SqlCommand("insert into TipoContacto (TCID, DescContacto) values (3,'Email');", baseDadosAad);
            //inserirDados = new SqlCommand("insert into TipoContacto (TCID, DescContacto) values (4,'Fax');", baseDadosAad);
            //inserirDados.ExecuteNonQuery();
            return true;
        }
        /// <summary>
        /// Dado nome de uma tabela mostra todos os dados
        /// </summary>
        /// <param name="dadosMostrar"></param>
        public DataGridView MostrarDados(string dadosMostrar, DataGridView auxDataGrid)
        {
            SqlCommand mostraDados = new SqlCommand($"Select * from {dadosMostrar};", baseDadosAad);

            var adaptadorDados = new SqlDataAdapter(mostraDados);
            var auxDataSet = new DataSet();

            adaptadorDados.Fill(auxDataSet);

            if (auxDataSet.Tables.Count > 0)
            {
                auxDataGrid.DataSource = auxDataSet.Tables[0];
                auxDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                auxDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            else
                auxDataGrid = null;

            return auxDataGrid;
        }
        #endregion

        #endregion
    }
}