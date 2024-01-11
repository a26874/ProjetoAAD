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
            this.SuspendLayout();
            // 
            // nomeRuaTextBox
            // 
            this.nomeRuaTextBox.Location = new System.Drawing.Point(284, 50);
            this.nomeRuaTextBox.Name = "nomeRuaTextBox";
            this.nomeRuaTextBox.Size = new System.Drawing.Size(100, 22);
            this.nomeRuaTextBox.TabIndex = 25;
            // 
            // ruaLabel
            // 
            this.ruaLabel.AutoSize = true;
            this.ruaLabel.Location = new System.Drawing.Point(281, 23);
            this.ruaLabel.Name = "ruaLabel";
            this.ruaLabel.Size = new System.Drawing.Size(75, 16);
            this.ruaLabel.TabIndex = 24;
            this.ruaLabel.Text = "Nome Rua:";
            // 
            // nomeClienteTextBox
            // 
            this.nomeClienteTextBox.Location = new System.Drawing.Point(155, 49);
            this.nomeClienteTextBox.Name = "nomeClienteTextBox";
            this.nomeClienteTextBox.Size = new System.Drawing.Size(100, 22);
            this.nomeClienteTextBox.TabIndex = 23;
            // 
            // nomeClienteLabel
            // 
            this.nomeClienteLabel.AutoSize = true;
            this.nomeClienteLabel.Location = new System.Drawing.Point(152, 24);
            this.nomeClienteLabel.Name = "nomeClienteLabel";
            this.nomeClienteLabel.Size = new System.Drawing.Size(91, 16);
            this.nomeClienteLabel.TabIndex = 22;
            this.nomeClienteLabel.Text = "Nome Cliente:";
            // 
            // InserirDadosButton
            // 
            this.InserirDadosButton.Location = new System.Drawing.Point(41, 49);
            this.InserirDadosButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InserirDadosButton.Name = "InserirDadosButton";
            this.InserirDadosButton.Size = new System.Drawing.Size(75, 23);
            this.InserirDadosButton.TabIndex = 21;
            this.InserirDadosButton.Text = "Inserir";
            this.InserirDadosButton.UseVisualStyleBackColor = true;
            this.InserirDadosButton.Click += new System.EventHandler(this.InserirDadosButton_Click);
            // 
            // comboBoxTiposContacto
            // 
            this.comboBoxTiposContacto.FormattingEnabled = true;
            this.comboBoxTiposContacto.Location = new System.Drawing.Point(448, 47);
            this.comboBoxTiposContacto.Name = "comboBoxTiposContacto";
            this.comboBoxTiposContacto.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTiposContacto.TabIndex = 26;
            // 
            // InserirCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxTiposContacto);
            this.Controls.Add(this.nomeRuaTextBox);
            this.Controls.Add(this.ruaLabel);
            this.Controls.Add(this.nomeClienteTextBox);
            this.Controls.Add(this.nomeClienteLabel);
            this.Controls.Add(this.InserirDadosButton);
            this.Name = "InserirCliente";
            this.Text = "InserirCliente";
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
    }
}