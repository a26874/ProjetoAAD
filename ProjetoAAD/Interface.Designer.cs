namespace ProjetoAAD
{
    partial class Interface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button queryButton;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InserirDadosButton = new System.Windows.Forms.Button();
            this.MostrarDadosButton = new System.Windows.Forms.Button();
            this.dataGridDados = new System.Windows.Forms.DataGridView();
            this.MostrarBDTextBox = new System.Windows.Forms.TextBox();
            this.alterarDadosButton = new System.Windows.Forms.Button();
            this.queryButton = new System.Windows.Forms.Button();
            this.apagarValoresButton = new System.Windows.Forms.Button();
            this.removerTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDados)).BeginInit();
            this.SuspendLayout();
            // 
            // InserirDadosButton
            // 
            this.InserirDadosButton.Location = new System.Drawing.Point(56, 23);
            this.InserirDadosButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InserirDadosButton.Name = "InserirDadosButton";
            this.InserirDadosButton.Size = new System.Drawing.Size(90, 19);
            this.InserirDadosButton.TabIndex = 0;
            this.InserirDadosButton.Text = "Inserir Cliente";
            this.InserirDadosButton.UseVisualStyleBackColor = true;
            this.InserirDadosButton.Click += new System.EventHandler(this.InserirDadosButton_Click);
            // 
            // MostrarDadosButton
            // 
            this.MostrarDadosButton.Location = new System.Drawing.Point(56, 162);
            this.MostrarDadosButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MostrarDadosButton.Name = "MostrarDadosButton";
            this.MostrarDadosButton.Size = new System.Drawing.Size(90, 20);
            this.MostrarDadosButton.TabIndex = 1;
            this.MostrarDadosButton.Text = "Mostrar";
            this.MostrarDadosButton.UseVisualStyleBackColor = true;
            this.MostrarDadosButton.Click += new System.EventHandler(this.MostrarDadosButton_Click);
            // 
            // dataGridDados
            // 
            this.dataGridDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridDados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDados.Location = new System.Drawing.Point(56, 206);
            this.dataGridDados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridDados.Name = "dataGridDados";
            this.dataGridDados.RowHeadersWidth = 51;
            this.dataGridDados.RowTemplate.Height = 24;
            this.dataGridDados.Size = new System.Drawing.Size(503, 124);
            this.dataGridDados.TabIndex = 2;
            // 
            // MostrarBDTextBox
            // 
            this.MostrarBDTextBox.Location = new System.Drawing.Point(159, 162);
            this.MostrarBDTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MostrarBDTextBox.Name = "MostrarBDTextBox";
            this.MostrarBDTextBox.Size = new System.Drawing.Size(76, 20);
            this.MostrarBDTextBox.TabIndex = 3;
            // 
            // alterarDadosButton
            // 
            this.alterarDadosButton.Location = new System.Drawing.Point(56, 72);
            this.alterarDadosButton.Name = "alterarDadosButton";
            this.alterarDadosButton.Size = new System.Drawing.Size(90, 23);
            this.alterarDadosButton.TabIndex = 4;
            this.alterarDadosButton.Text = "Alterar Dados";
            this.alterarDadosButton.UseVisualStyleBackColor = true;
            this.alterarDadosButton.Click += new System.EventHandler(this.alterarDadosButton_Click);
            // 
            // queryButton
            // 
            this.queryButton.Location = new System.Drawing.Point(281, 162);
            this.queryButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(90, 19);
            this.queryButton.TabIndex = 0;
            this.queryButton.Text = "Query";
            this.queryButton.UseVisualStyleBackColor = true;
            this.queryButton.Click += new System.EventHandler(this.QueryButton_Click);
            // 
            // apagarValoresButton
            // 
            this.apagarValoresButton.Location = new System.Drawing.Point(56, 116);
            this.apagarValoresButton.Name = "apagarValoresButton";
            this.apagarValoresButton.Size = new System.Drawing.Size(90, 23);
            this.apagarValoresButton.TabIndex = 5;
            this.apagarValoresButton.Text = "Remover";
            this.apagarValoresButton.UseVisualStyleBackColor = true;
            this.apagarValoresButton.Click += new System.EventHandler(this.apagarValoresButton_Click);
            // 
            // removerTextBox
            // 
            this.removerTextBox.Location = new System.Drawing.Point(159, 118);
            this.removerTextBox.Name = "removerTextBox";
            this.removerTextBox.Size = new System.Drawing.Size(76, 20);
            this.removerTextBox.TabIndex = 6;
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.removerTextBox);
            this.Controls.Add(this.apagarValoresButton);
            this.Controls.Add(this.queryButton);
            this.Controls.Add(this.alterarDadosButton);
            this.Controls.Add(this.MostrarBDTextBox);
            this.Controls.Add(this.dataGridDados);
            this.Controls.Add(this.MostrarDadosButton);
            this.Controls.Add(this.InserirDadosButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Interface";
            this.Text = "InterfaceAAD";
            this.Load += new System.EventHandler(this.Interface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InserirDadosButton;
        private System.Windows.Forms.Button MostrarDadosButton;
        private System.Windows.Forms.DataGridView dataGridDados;
        private System.Windows.Forms.TextBox MostrarBDTextBox;
        private System.Windows.Forms.Button alterarDadosButton;
        private System.Windows.Forms.Button apagarValoresButton;
        private System.Windows.Forms.TextBox removerTextBox;
    }
}

