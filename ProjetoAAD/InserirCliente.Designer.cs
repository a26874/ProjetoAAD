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
            this.painelSeparador = new System.Windows.Forms.Panel();
            this.nomeClienteInserirContactosLabel = new System.Windows.Forms.Label();
            this.nomeClienteInserirContactosTextBox = new System.Windows.Forms.TextBox();
            this.contactoInseridoSucessoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nomeRuaTextBox
            // 
            this.nomeRuaTextBox.Location = new System.Drawing.Point(12, 126);
            this.nomeRuaTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nomeRuaTextBox.Name = "nomeRuaTextBox";
            this.nomeRuaTextBox.Size = new System.Drawing.Size(100, 22);
            this.nomeRuaTextBox.TabIndex = 25;
            // 
            // ruaLabel
            // 
            this.ruaLabel.AutoSize = true;
            this.ruaLabel.Location = new System.Drawing.Point(9, 95);
            this.ruaLabel.Name = "ruaLabel";
            this.ruaLabel.Size = new System.Drawing.Size(75, 16);
            this.ruaLabel.TabIndex = 24;
            this.ruaLabel.Text = "Nome Rua:";
            // 
            // nomeClienteTextBox
            // 
            this.nomeClienteTextBox.Location = new System.Drawing.Point(12, 52);
            this.nomeClienteTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nomeClienteTextBox.Name = "nomeClienteTextBox";
            this.nomeClienteTextBox.Size = new System.Drawing.Size(100, 22);
            this.nomeClienteTextBox.TabIndex = 23;
            // 
            // nomeClienteLabel
            // 
            this.nomeClienteLabel.AutoSize = true;
            this.nomeClienteLabel.Location = new System.Drawing.Point(9, 21);
            this.nomeClienteLabel.Name = "nomeClienteLabel";
            this.nomeClienteLabel.Size = new System.Drawing.Size(91, 16);
            this.nomeClienteLabel.TabIndex = 22;
            this.nomeClienteLabel.Text = "Nome Cliente:";
            // 
            // InserirDadosButton
            // 
            this.InserirDadosButton.Location = new System.Drawing.Point(12, 167);
            this.InserirDadosButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InserirDadosButton.Name = "InserirDadosButton";
            this.InserirDadosButton.Size = new System.Drawing.Size(100, 27);
            this.InserirDadosButton.TabIndex = 21;
            this.InserirDadosButton.Text = "Inserir Cliente";
            this.InserirDadosButton.UseVisualStyleBackColor = true;
            this.InserirDadosButton.Click += new System.EventHandler(this.InserirDadosButton_Click);
            // 
            // comboBoxTiposContacto
            // 
            this.comboBoxTiposContacto.FormattingEnabled = true;
            this.comboBoxTiposContacto.Location = new System.Drawing.Point(576, 127);
            this.comboBoxTiposContacto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxTiposContacto.Name = "comboBoxTiposContacto";
            this.comboBoxTiposContacto.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTiposContacto.TabIndex = 26;
            this.comboBoxTiposContacto.Visible = false;
            // 
            // NumeroContactosLabel
            // 
            this.NumeroContactosLabel.AutoSize = true;
            this.NumeroContactosLabel.Location = new System.Drawing.Point(230, 95);
            this.NumeroContactosLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumeroContactosLabel.Name = "NumeroContactosLabel";
            this.NumeroContactosLabel.Size = new System.Drawing.Size(121, 16);
            this.NumeroContactosLabel.TabIndex = 27;
            this.NumeroContactosLabel.Text = "Numero Contactos:";
            // 
            // numeroContactosTextBox
            // 
            this.numeroContactosTextBox.Location = new System.Drawing.Point(233, 126);
            this.numeroContactosTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.numeroContactosTextBox.Name = "numeroContactosTextBox";
            this.numeroContactosTextBox.Size = new System.Drawing.Size(96, 22);
            this.numeroContactosTextBox.TabIndex = 28;
            // 
            // contactoTextBox
            // 
            this.contactoTextBox.Location = new System.Drawing.Point(419, 126);
            this.contactoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.contactoTextBox.Name = "contactoTextBox";
            this.contactoTextBox.Size = new System.Drawing.Size(121, 22);
            this.contactoTextBox.TabIndex = 29;
            this.contactoTextBox.Visible = false;
            // 
            // ContactoLabel
            // 
            this.ContactoLabel.AutoSize = true;
            this.ContactoLabel.Location = new System.Drawing.Point(416, 95);
            this.ContactoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ContactoLabel.Name = "ContactoLabel";
            this.ContactoLabel.Size = new System.Drawing.Size(63, 16);
            this.ContactoLabel.TabIndex = 30;
            this.ContactoLabel.Text = "Contacto:";
            this.ContactoLabel.Visible = false;
            // 
            // inserirContactoButton
            // 
            this.inserirContactoButton.Location = new System.Drawing.Point(576, 167);
            this.inserirContactoButton.Margin = new System.Windows.Forms.Padding(4);
            this.inserirContactoButton.Name = "inserirContactoButton";
            this.inserirContactoButton.Size = new System.Drawing.Size(121, 28);
            this.inserirContactoButton.TabIndex = 31;
            this.inserirContactoButton.Text = "Inserir Contacto";
            this.inserirContactoButton.UseVisualStyleBackColor = true;
            this.inserirContactoButton.Visible = false;
            this.inserirContactoButton.Click += new System.EventHandler(this.inserirContactoButton_Click);
            // 
            // tiposContactoLabel
            // 
            this.tiposContactoLabel.AutoSize = true;
            this.tiposContactoLabel.Location = new System.Drawing.Point(573, 95);
            this.tiposContactoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tiposContactoLabel.Name = "tiposContactoLabel";
            this.tiposContactoLabel.Size = new System.Drawing.Size(101, 16);
            this.tiposContactoLabel.TabIndex = 32;
            this.tiposContactoLabel.Text = "Tipos Contacto:";
            this.tiposContactoLabel.Visible = false;
            // 
            // InserirContactosButton
            // 
            this.InserirContactosButton.Location = new System.Drawing.Point(419, 15);
            this.InserirContactosButton.Margin = new System.Windows.Forms.Padding(4);
            this.InserirContactosButton.Name = "InserirContactosButton";
            this.InserirContactosButton.Size = new System.Drawing.Size(306, 28);
            this.InserirContactosButton.TabIndex = 33;
            this.InserirContactosButton.Text = "Inserir Contactos";
            this.InserirContactosButton.UseVisualStyleBackColor = true;
            this.InserirContactosButton.Click += new System.EventHandler(this.InserirContactosButton_Click);
            // 
            // painelSeparador
            // 
            this.painelSeparador.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.painelSeparador.Location = new System.Drawing.Point(158, 0);
            this.painelSeparador.Name = "painelSeparador";
            this.painelSeparador.Size = new System.Drawing.Size(3, 211);
            this.painelSeparador.TabIndex = 34;
            // 
            // nomeClienteInserirContactosLabel
            // 
            this.nomeClienteInserirContactosLabel.AutoSize = true;
            this.nomeClienteInserirContactosLabel.Location = new System.Drawing.Point(230, 21);
            this.nomeClienteInserirContactosLabel.Name = "nomeClienteInserirContactosLabel";
            this.nomeClienteInserirContactosLabel.Size = new System.Drawing.Size(91, 16);
            this.nomeClienteInserirContactosLabel.TabIndex = 35;
            this.nomeClienteInserirContactosLabel.Text = "Nome Cliente:";
            // 
            // nomeClienteInserirContactosTextBox
            // 
            this.nomeClienteInserirContactosTextBox.Location = new System.Drawing.Point(233, 52);
            this.nomeClienteInserirContactosTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomeClienteInserirContactosTextBox.Name = "nomeClienteInserirContactosTextBox";
            this.nomeClienteInserirContactosTextBox.Size = new System.Drawing.Size(96, 22);
            this.nomeClienteInserirContactosTextBox.TabIndex = 36;
            // 
            // contactoInseridoSucessoLabel
            // 
            this.contactoInseridoSucessoLabel.AutoSize = true;
            this.contactoInseridoSucessoLabel.Location = new System.Drawing.Point(416, 47);
            this.contactoInseridoSucessoLabel.Name = "contactoInseridoSucessoLabel";
            this.contactoInseridoSucessoLabel.Size = new System.Drawing.Size(44, 16);
            this.contactoInseridoSucessoLabel.TabIndex = 37;
            this.contactoInseridoSucessoLabel.Text = "label1";
            this.contactoInseridoSucessoLabel.Visible = false;
            // 
            // InserirCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 210);
            this.Controls.Add(this.contactoInseridoSucessoLabel);
            this.Controls.Add(this.nomeClienteInserirContactosTextBox);
            this.Controls.Add(this.nomeClienteInserirContactosLabel);
            this.Controls.Add(this.painelSeparador);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InserirCliente";
            this.Text = "Inserir Cliente";
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
        private System.Windows.Forms.Panel painelSeparador;
        private System.Windows.Forms.Label nomeClienteInserirContactosLabel;
        private System.Windows.Forms.TextBox nomeClienteInserirContactosTextBox;
        private System.Windows.Forms.Label contactoInseridoSucessoLabel;
    }
}