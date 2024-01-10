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
            this.MostrarBDTextBox = new System.Windows.Forms.TextBox();
            this.menuTipoContacto = new System.Windows.Forms.MenuStrip();
            this.selecioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDados)).BeginInit();
            this.menuTipoContacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // InserirDadosButton
            // 
            this.InserirDadosButton.Location = new System.Drawing.Point(56, 31);
            this.InserirDadosButton.Margin = new System.Windows.Forms.Padding(2);
            this.InserirDadosButton.Name = "InserirDadosButton";
            this.InserirDadosButton.Size = new System.Drawing.Size(56, 19);
            this.InserirDadosButton.TabIndex = 0;
            this.InserirDadosButton.Text = "Inserir";
            this.InserirDadosButton.UseVisualStyleBackColor = true;
            this.InserirDadosButton.Click += new System.EventHandler(this.InserirDadosButton_Click);
            // 
            // MostrarDadosButton
            // 
            this.MostrarDadosButton.Location = new System.Drawing.Point(56, 127);
            this.MostrarDadosButton.Margin = new System.Windows.Forms.Padding(2);
            this.MostrarDadosButton.Name = "MostrarDadosButton";
            this.MostrarDadosButton.Size = new System.Drawing.Size(56, 19);
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
            this.dataGridDados.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridDados.Name = "dataGridDados";
            this.dataGridDados.RowHeadersWidth = 51;
            this.dataGridDados.RowTemplate.Height = 24;
            this.dataGridDados.Size = new System.Drawing.Size(503, 124);
            this.dataGridDados.TabIndex = 2;
            // 
            // MostrarBDTextBox
            // 
            this.MostrarBDTextBox.Location = new System.Drawing.Point(200, 127);
            this.MostrarBDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MostrarBDTextBox.Name = "MostrarBDTextBox";
            this.MostrarBDTextBox.Size = new System.Drawing.Size(76, 20);
            this.MostrarBDTextBox.TabIndex = 3;
            // 
            // menuTipoContacto
            // 
            this.menuTipoContacto.Dock = System.Windows.Forms.DockStyle.None;
            this.menuTipoContacto.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTipoContacto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selecioneToolStripMenuItem});
            this.menuTipoContacto.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuTipoContacto.Location = new System.Drawing.Point(266, 171);
            this.menuTipoContacto.Name = "menuTipoContacto";
            this.menuTipoContacto.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuTipoContacto.Size = new System.Drawing.Size(73, 23);
            this.menuTipoContacto.TabIndex = 16;
            this.menuTipoContacto.Text = "TipoContacto";
            // 
            // selecioneToolStripMenuItem
            // 
            this.selecioneToolStripMenuItem.Name = "selecioneToolStripMenuItem";
            this.selecioneToolStripMenuItem.Size = new System.Drawing.Size(69, 19);
            this.selecioneToolStripMenuItem.Text = "Selecione";
            this.selecioneToolStripMenuItem.Click += new System.EventHandler(this.selecioneToolStripMenuItem_Click);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.menuTipoContacto);
            this.Controls.Add(this.MostrarBDTextBox);
            this.Controls.Add(this.dataGridDados);
            this.Controls.Add(this.MostrarDadosButton);
            this.Controls.Add(this.InserirDadosButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Interface";
            this.Text = "InterfaceAAD";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDados)).EndInit();
            this.menuTipoContacto.ResumeLayout(false);
            this.menuTipoContacto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InserirDadosButton;
        private System.Windows.Forms.Button MostrarDadosButton;
        private System.Windows.Forms.DataGridView dataGridDados;
        private System.Windows.Forms.TextBox MostrarBDTextBox;
        private System.Windows.Forms.MenuStrip menuTipoContacto;
        private System.Windows.Forms.ToolStripMenuItem selecioneToolStripMenuItem;
    }
}

