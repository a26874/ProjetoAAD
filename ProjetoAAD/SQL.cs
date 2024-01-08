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
using System.Security.Cryptography;
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
        /// Insere o codigoPostal.
        /// </summary>
        /// <param name="listaAux"></param>
        /// <returns></returns>
        public bool InserirCodigoPostal(List<string> listaAux)
        {
            foreach (string comando in listaAux)
            {
                using (SqlCommand checkCommand = new SqlCommand($"SELECT COUNT(*) FROM CodigoPostal WHERE CodPostal = '{comando.Split('\'')[1]}'", baseDadosAad))
                {
                    try
                    {
                        int count = (int)checkCommand.ExecuteScalar();

                        if (count == 0)
                        {
                            using (SqlCommand inserirDados = new SqlCommand(comando, baseDadosAad))
                            {
                                inserirDados.ExecuteNonQuery();
                            }
                        }
                    }
                    catch (SqlException)
                    {
                    }
                }
            }
            return true;
        }
        public bool InserirTiposContacto(List<string> listaAux)
        {
            foreach (string comando in listaAux)
            {
                using (SqlCommand checkCommand = new SqlCommand($"SELECT COUNT(*) FROM TiposContacto WHERE DescContacto = '{comando.Split('\'')[1]}'", baseDadosAad))
                {
                    try
                    {
                        int count = (int)checkCommand.ExecuteScalar();

                        if (count == 0)
                        {
                            using (SqlCommand inserirDados = new SqlCommand(comando, baseDadosAad))
                            {
                                inserirDados.ExecuteNonQuery();
                            }
                        }
                    }
                    catch (SqlException)
                    {
                    }
                }
            }
            return true;
        }

        
        /// <summary>
        /// Insere dados em tabelas.
        /// </summary>
        /// <param name="nomeTabela"></param>
        /// <returns></returns>
        public bool InsereDados()
        {
            
            List<string> listaComandosLocalidade = new List<string>();
            List<string> listaComandosTiposContacto = new List<string>();
            listaComandosLocalidade.Add("insert into CodigoPostal(CodPostal, Localidade) values('4211-123','asdasd');");
            InserirCodigoPostal(listaComandosLocalidade);
            listaComandosTiposContacto.Add("insert into TiposContacto(DescContacto) values ('Telemovel');");
            listaComandosTiposContacto.Add("insert into TiposContacto(DescContacto) values ('Telefone');");
            listaComandosTiposContacto.Add("insert into TiposContacto(DescContacto) values ('Email');");
            listaComandosTiposContacto.Add("insert into TiposContacto(DescContacto) values ('Fax');");
            InserirTiposContacto(listaComandosTiposContacto);
            Dictionary<int, string> listaComandosCliente = new Dictionary<int, string>();
            listaComandosCliente.Add(1, "insert into Cliente(NomeCliente, DataNascimento, Rua, CodPostal) values('Marco', 01/01/2022, 'ASD', '4700-888';");
            //InserirClientes(listaComandosCliente);

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