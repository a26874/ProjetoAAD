namespace ProjetoAAD
{
    partial class Interface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDados)).BeginInit();
            this.SuspendLayout();
            // 
            // InserirDadosButton
            // 
            this.InserirDadosButton.Location = new System.Drawing.Point(74, 76);
            this.InserirDadosButton.Name = "InserirDadosButton";
            this.InserirDadosButton.Size = new System.Drawing.Size(75, 23);
            this.InserirDadosButton.TabIndex = 0;
            this.InserirDadosButton.Text = "Inserir";
            this.InserirDadosButton.UseVisualStyleBackColor = true;
            this.InserirDadosButton.Click += new System.EventHandler(this.InserirDadosButton_Click);
            // 
            // MostrarDadosButton
            // 
            this.MostrarDadosButton.Location = new System.Drawing.Point(74, 156);
            this.MostrarDadosButton.Name = "MostrarDadosButton";
            this.MostrarDadosButton.Size = new System.Drawing.Size(75, 23);
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
            this.dataGridDados.Location = new System.Drawing.Point(74, 254);
            this.dataGridDados.Name = "dataGridDados";
            this.dataGridDados.RowHeadersWidth = 51;
            this.dataGridDados.RowTemplate.Height = 24;
            this.dataGridDados.Size = new System.Drawing.Size(671, 153);
            this.dataGridDados.TabIndex = 2;
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridDados);
            this.Controls.Add(this.MostrarDadosButton);
            this.Controls.Add(this.InserirDadosButton);
            this.Name = "Interface";
            this.Text = "InterfaceAAD";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InserirDadosButton;
        private System.Windows.Forms.Button MostrarDadosButton;
        private System.Windows.Forms.DataGridView dataGridDados;
    }
}

