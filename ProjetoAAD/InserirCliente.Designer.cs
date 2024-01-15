namespace ProjetoAAD
{
    partial class InserirCliente
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
            this.nomeRuaTextBox = new System.Windows.Forms.TextBox();
            this.ruaLabel = new System.Windows.Forms.Label();
            this.nomeClienteTextBox = new System.Windows.Forms.TextBox();
            this.nomeClienteLabel = new System.Windows.Forms.Label();
            this.InserirDadosButton = new System.Windows.Forms.Button();
            this.comboBoxTiposContacto = new System.Windows.Forms.ComboBox();
            this.NumeroContactosLabel = new System.Windows.Forms.Label();
            this.numeroContactosTextBox = new System.Windows.Forms.TextBox();
            this.contactoTextBox = new System.Windows.Forms.TextBox();
            this.ContactoLabel = new System.Windows.Forms.Label();
            this.inserirContactoButton = new System.Windows.Forms.Button();
            this.tiposContactoLabel = new System.Windows.Forms.Label();
            this.InserirContactosButton = new System.Windows.Forms.Button();
            this.contactoInseridoSucessoLabel = new System.Windows.Forms.Label();
            this.dataGridListaInserirContactos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaInserirContactos)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeRuaTextBox
            // 
            this.nomeRuaTextBox.Location = new System.Drawing.Point(60, 104);
            this.nomeRuaTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nomeRuaTextBox.Name = "nomeRuaTextBox";
            this.nomeRuaTextBox.Size = new System.Drawing.Size(76, 20);
            this.nomeRuaTextBox.TabIndex = 25;
            // 
            // ruaLabel
            // 
            this.ruaLabel.AutoSize = true;
            this.ruaLabel.Location = new System.Drawing.Point(57, 77);
            this.ruaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ruaLabel.Name = "ruaLabel";
            this.ruaLabel.Size = new System.Drawing.Size(61, 13);
            this.ruaLabel.TabIndex = 24;
            this.ruaLabel.Text = "Nome Rua:";
            // 
            // nomeClienteTextBox
            // 
            this.nomeClienteTextBox.Location = new System.Drawing.Point(60, 38);
            this.nomeClienteTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nomeClienteTextBox.Name = "nomeClienteTextBox";
            this.nomeClienteTextBox.Size = new System.Drawing.Size(76, 20);
            this.nomeClienteTextBox.TabIndex = 23;
            // 
            // nomeClienteLabel
            // 
            this.nomeClienteLabel.AutoSize = true;
            this.nomeClienteLabel.Location = new System.Drawing.Point(57, 17);
            this.nomeClienteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nomeClienteLabel.Name = "nomeClienteLabel";
            this.nomeClienteLabel.Size = new System.Drawing.Size(73, 13);
            this.nomeClienteLabel.TabIndex = 22;
            this.nomeClienteLabel.Text = "Nome Cliente:";
            // 
            // InserirDadosButton
            // 
            this.InserirDadosButton.Location = new System.Drawing.Point(845, 136);
            this.InserirDadosButton.Margin = new System.Windows.Forms.Padding(2);
            this.InserirDadosButton.Name = "InserirDadosButton";
            this.InserirDadosButton.Size = new System.Drawing.Size(75, 22);
            this.InserirDadosButton.TabIndex = 21;
            this.InserirDadosButton.Text = "Inserir Cliente";
            this.InserirDadosButton.UseVisualStyleBackColor = true;
            this.InserirDadosButton.Click += new System.EventHandler(this.InserirDadosButton_Click);
            // 
            // comboBoxTiposContacto
            // 
            this.comboBoxTiposContacto.FormattingEnabled = true;
            this.comboBoxTiposContacto.Location = new System.Drawing.Point(432, 103);
            this.comboBoxTiposContacto.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTiposContacto.Name = "comboBoxTiposContacto";
            this.comboBoxTiposContacto.Size = new System.Drawing.Size(92, 21);
            this.comboBoxTiposContacto.TabIndex = 26;
            this.comboBoxTiposContacto.Visible = false;
            // 
            // NumeroContactosLabel
            // 
            this.NumeroContactosLabel.AutoSize = true;
            this.NumeroContactosLabel.Location = new System.Drawing.Point(172, 77);
            this.NumeroContactosLabel.Name = "NumeroContactosLabel";
            this.NumeroContactosLabel.Size = new System.Drawing.Size(98, 13);
            this.NumeroContactosLabel.TabIndex = 27;
            this.NumeroContactosLabel.Text = "Numero Contactos:";
            // 
            // numeroContactosTextBox
            // 
            this.numeroContactosTextBox.Location = new System.Drawing.Point(175, 104);
            this.numeroContactosTextBox.Name = "numeroContactosTextBox";
            this.numeroContactosTextBox.Size = new System.Drawing.Size(73, 20);
            this.numeroContactosTextBox.TabIndex = 28;
            // 
            // contactoTextBox
            // 
            this.contactoTextBox.Location = new System.Drawing.Point(314, 102);
            this.contactoTextBox.Name = "contactoTextBox";
            this.contactoTextBox.Size = new System.Drawing.Size(92, 20);
            this.contactoTextBox.TabIndex = 29;
            this.contactoTextBox.Visible = false;
            // 
            // ContactoLabel
            // 
            this.ContactoLabel.AutoSize = true;
            this.ContactoLabel.Location = new System.Drawing.Point(312, 77);
            this.ContactoLabel.Name = "ContactoLabel";
            this.ContactoLabel.Size = new System.Drawing.Size(53, 13);
            this.ContactoLabel.TabIndex = 30;
            this.ContactoLabel.Text = "Contacto:";
            this.ContactoLabel.Visible = false;
            // 
            // inserirContactoButton
            // 
            this.inserirContactoButton.Location = new System.Drawing.Point(432, 136);
            this.inserirContactoButton.Name = "inserirContactoButton";
            this.inserirContactoButton.Size = new System.Drawing.Size(91, 23);
            this.inserirContactoButton.TabIndex = 31;
            this.inserirContactoButton.Text = "Inserir Contacto";
            this.inserirContactoButton.UseVisualStyleBackColor = true;
            this.inserirContactoButton.Visible = false;
            this.inserirContactoButton.Click += new System.EventHandler(this.inserirContactoButton_Click);
            // 
            // tiposContactoLabel
            // 
            this.tiposContactoLabel.AutoSize = true;
            this.tiposContactoLabel.Location = new System.Drawing.Point(430, 77);
            this.tiposContactoLabel.Name = "tiposContactoLabel";
            this.tiposContactoLabel.Size = new System.Drawing.Size(82, 13);
            this.tiposContactoLabel.TabIndex = 32;
            this.tiposContactoLabel.Text = "Tipos Contacto:";
            this.tiposContactoLabel.Visible = false;
            // 
            // InserirContactosButton
            // 
            this.InserirContactosButton.Location = new System.Drawing.Point(314, 12);
            this.InserirContactosButton.Name = "InserirContactosButton";
            this.InserirContactosButton.Size = new System.Drawing.Size(210, 23);
            this.InserirContactosButton.TabIndex = 33;
            this.InserirContactosButton.Text = "Inserir Contactos";
            this.InserirContactosButton.UseVisualStyleBackColor = true;
            this.InserirContactosButton.Click += new System.EventHandler(this.InserirContactosButton_Click);
            // 
            // contactoInseridoSucessoLabel
            // 
            this.contactoInseridoSucessoLabel.AutoSize = true;
            this.contactoInseridoSucessoLabel.Location = new System.Drawing.Point(312, 38);
            this.contactoInseridoSucessoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contactoInseridoSucessoLabel.Name = "contactoInseridoSucessoLabel";
            this.contactoInseridoSucessoLabel.Size = new System.Drawing.Size(35, 13);
            this.contactoInseridoSucessoLabel.TabIndex = 37;
            this.contactoInseridoSucessoLabel.Text = "label1";
            this.contactoInseridoSucessoLabel.Visible = false;
            // 
            // dataGridListaInserirContactos
            // 
            this.dataGridListaInserirContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListaInserirContactos.Location = new System.Drawing.Point(552, 8);
            this.dataGridListaInserirContactos.Name = "dataGridListaInserirContactos";
            this.dataGridListaInserirContactos.Size = new System.Drawing.Size(254, 151);
            this.dataGridListaInserirContactos.TabIndex = 38;
            // 
            // InserirCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 171);
            this.Controls.Add(this.dataGridListaInserirContactos);
            this.Controls.Add(this.contactoInseridoSucessoLabel);
            this.Controls.Add(this.InserirContactosButton);
            this.Controls.Add(this.tiposContactoLabel);
            this.Controls.Add(this.inserirContactoButton);
            this.Controls.Add(this.ContactoLabel);
            this.Controls.Add(this.contactoTextBox);
            this.Controls.Add(this.numeroContactosTextBox);
            this.Controls.Add(this.NumeroContactosLabel);
            this.Controls.Add(this.comboBoxTiposContacto);
            this.Controls.Add(this.nomeRuaTextBox);
            this.Controls.Add(this.ruaLabel);
            this.Controls.Add(this.nomeClienteTextBox);
            this.Controls.Add(this.nomeClienteLabel);
            this.Controls.Add(this.InserirDadosButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InserirCliente";
            this.Text = "Inserir Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaInserirContactos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomeRuaTextBox;
        private System.Windows.Forms.Label ruaLabel;
        private System.Windows.Forms.TextBox nomeClienteTextBox;
        private System.Windows.Forms.Label nomeClienteLabel;
        private System.Windows.Forms.Button InserirDadosButton;
        private System.Windows.Forms.ComboBox comboBoxTiposContacto;
        private System.Windows.Forms.Label NumeroContactosLabel;
        private System.Windows.Forms.TextBox numeroContactosTextBox;
        private System.Windows.Forms.TextBox contactoTextBox;
        private System.Windows.Forms.Label ContactoLabel;
        private System.Windows.Forms.Button inserirContactoButton;
        private System.Windows.Forms.Label tiposContactoLabel;
        private System.Windows.Forms.Button InserirContactosButton;
        private System.Windows.Forms.Label contactoInseridoSucessoLabel;
        private System.Windows.Forms.DataGridView dataGridListaInserirContactos;
    }
}