namespace LocacaoLaboratorio
{
    partial class FormCadastroVendas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDCorretorLabel;
            System.Windows.Forms.Label Terreno;
            System.Windows.Forms.Label nomeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroVendas));
            this.labelCadastroVendas = new System.Windows.Forms.Label();
            this.buttonSalvarVenda = new System.Windows.Forms.Button();
            this.buttonCancelarCadVenda = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.vendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonBuscarCliente = new System.Windows.Forms.Button();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.buttonBuscarCorretor = new System.Windows.Forms.Button();
            this.buttonBuscarTerreno = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            iDCorretorLabel = new System.Windows.Forms.Label();
            Terreno = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iDCorretorLabel
            // 
            iDCorretorLabel.AutoSize = true;
            iDCorretorLabel.BackColor = System.Drawing.Color.Gold;
            iDCorretorLabel.Location = new System.Drawing.Point(224, 68);
            iDCorretorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            iDCorretorLabel.Name = "iDCorretorLabel";
            iDCorretorLabel.Size = new System.Drawing.Size(44, 13);
            iDCorretorLabel.TabIndex = 7;
            iDCorretorLabel.Text = "Corretor";
            // 
            // Terreno
            // 
            Terreno.AutoSize = true;
            Terreno.BackColor = System.Drawing.Color.Gold;
            Terreno.Location = new System.Drawing.Point(32, 119);
            Terreno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            Terreno.Name = "Terreno";
            Terreno.Size = new System.Drawing.Size(44, 13);
            Terreno.TabIndex = 8;
            Terreno.Text = "Terreno";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.BackColor = System.Drawing.Color.Gold;
            nomeLabel.Location = new System.Drawing.Point(35, 68);
            nomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(39, 13);
            nomeLabel.TabIndex = 17;
            nomeLabel.Text = "Cliente";
            // 
            // labelCadastroVendas
            // 
            this.labelCadastroVendas.AutoSize = true;
            this.labelCadastroVendas.BackColor = System.Drawing.Color.Gold;
            this.labelCadastroVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastroVendas.Location = new System.Drawing.Point(47, 9);
            this.labelCadastroVendas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCadastroVendas.Name = "labelCadastroVendas";
            this.labelCadastroVendas.Size = new System.Drawing.Size(303, 37);
            this.labelCadastroVendas.TabIndex = 10;
            this.labelCadastroVendas.Text = "Cadastro de vendas";
            // 
            // buttonSalvarVenda
            // 
            this.buttonSalvarVenda.Location = new System.Drawing.Point(263, 176);
            this.buttonSalvarVenda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSalvarVenda.Name = "buttonSalvarVenda";
            this.buttonSalvarVenda.Size = new System.Drawing.Size(56, 19);
            this.buttonSalvarVenda.TabIndex = 11;
            this.buttonSalvarVenda.Text = "Salvar";
            this.buttonSalvarVenda.UseVisualStyleBackColor = true;
            this.buttonSalvarVenda.Click += new System.EventHandler(this.buttonSalvarVenda_Click);
            // 
            // buttonCancelarCadVenda
            // 
            this.buttonCancelarCadVenda.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelarCadVenda.Location = new System.Drawing.Point(323, 176);
            this.buttonCancelarCadVenda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancelarCadVenda.Name = "buttonCancelarCadVenda";
            this.buttonCancelarCadVenda.Size = new System.Drawing.Size(65, 19);
            this.buttonCancelarCadVenda.TabIndex = 12;
            this.buttonCancelarCadVenda.Text = "Cancelar";
            this.buttonCancelarCadVenda.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "NomeCorretor", true));
            this.textBox1.Location = new System.Drawing.Point(226, 84);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 14;
            // 
            // vendasBindingSource
            // 
            this.vendasBindingSource.DataSource = typeof(Models.Vendas);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "Endereco", true));
            this.textBox2.Location = new System.Drawing.Point(34, 134);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(329, 20);
            this.textBox2.TabIndex = 15;
            // 
            // buttonBuscarCliente
            // 
            this.buttonBuscarCliente.Location = new System.Drawing.Point(188, 83);
            this.buttonBuscarCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBuscarCliente.Name = "buttonBuscarCliente";
            this.buttonBuscarCliente.Size = new System.Drawing.Size(22, 19);
            this.buttonBuscarCliente.TabIndex = 17;
            this.buttonBuscarCliente.Text = "...";
            this.buttonBuscarCliente.UseVisualStyleBackColor = true;
            this.buttonBuscarCliente.Click += new System.EventHandler(this.buttonBuscarCliente_Click);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "NomeCliente", true));
            this.nomeTextBox.Location = new System.Drawing.Point(34, 84);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(150, 20);
            this.nomeTextBox.TabIndex = 18;
            // 
            // buttonBuscarCorretor
            // 
            this.buttonBuscarCorretor.Location = new System.Drawing.Point(367, 84);
            this.buttonBuscarCorretor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBuscarCorretor.Name = "buttonBuscarCorretor";
            this.buttonBuscarCorretor.Size = new System.Drawing.Size(22, 19);
            this.buttonBuscarCorretor.TabIndex = 19;
            this.buttonBuscarCorretor.Text = "...";
            this.buttonBuscarCorretor.UseVisualStyleBackColor = true;
            this.buttonBuscarCorretor.Click += new System.EventHandler(this.buttonBuscarCorretor_Click);
            // 
            // buttonBuscarTerreno
            // 
            this.buttonBuscarTerreno.Location = new System.Drawing.Point(367, 133);
            this.buttonBuscarTerreno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBuscarTerreno.Name = "buttonBuscarTerreno";
            this.buttonBuscarTerreno.Size = new System.Drawing.Size(22, 19);
            this.buttonBuscarTerreno.TabIndex = 20;
            this.buttonBuscarTerreno.Text = "...";
            this.buttonBuscarTerreno.UseVisualStyleBackColor = true;
            this.buttonBuscarTerreno.Click += new System.EventHandler(this.buttonBuscarTerreno_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LocacaoLaboratorio.Properties.Resources.Foto_de_fundo_2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(434, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // FormCadastroVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 227);
            this.Controls.Add(this.buttonBuscarTerreno);
            this.Controls.Add(this.buttonBuscarCorretor);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.buttonBuscarCliente);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonCancelarCadVenda);
            this.Controls.Add(this.buttonSalvarVenda);
            this.Controls.Add(this.labelCadastroVendas);
            this.Controls.Add(Terreno);
            this.Controls.Add(iDCorretorLabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCadastroVendas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de vendas";
            this.Load += new System.EventHandler(this.FormCadastroVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource vendasBindingSource;
        private System.Windows.Forms.Label labelCadastroVendas;
        private System.Windows.Forms.Button buttonSalvarVenda;
        private System.Windows.Forms.Button buttonCancelarCadVenda;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonBuscarCliente;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Button buttonBuscarCorretor;
        private System.Windows.Forms.Button buttonBuscarTerreno;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}