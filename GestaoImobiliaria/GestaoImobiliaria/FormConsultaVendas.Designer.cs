namespace LocacaoLaboratorio
{
    partial class FormConsultaVendas
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
            this.vendasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeEmpreendimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCorretor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelConsultaVendas = new System.Windows.Forms.Label();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.buttonBuscarVenda = new System.Windows.Forms.Button();
            this.buttonAlterarVenda = new System.Windows.Forms.Button();
            this.buttonInserirVenda = new System.Windows.Forms.Button();
            this.buttonExcluirVenda = new System.Windows.Forms.Button();
            this.comboBoxBuscarPor = new System.Windows.Forms.ComboBox();
            this.buttonSelecionarVenda = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.vendasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // vendasDataGridView
            // 
            this.vendasDataGridView.AllowUserToAddRows = false;
            this.vendasDataGridView.AllowUserToDeleteRows = false;
            this.vendasDataGridView.AllowUserToOrderColumns = true;
            this.vendasDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vendasDataGridView.AutoGenerateColumns = false;
            this.vendasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.NomeEmpreendimento,
            this.Endereco,
            this.NomeCliente,
            this.NomeCorretor});
            this.vendasDataGridView.DataSource = this.vendasBindingSource;
            this.vendasDataGridView.Location = new System.Drawing.Point(12, 130);
            this.vendasDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vendasDataGridView.Name = "vendasDataGridView";
            this.vendasDataGridView.ReadOnly = true;
            this.vendasDataGridView.RowHeadersWidth = 51;
            this.vendasDataGridView.RowTemplate.Height = 24;
            this.vendasDataGridView.Size = new System.Drawing.Size(1307, 426);
            this.vendasDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDVenda";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // NomeEmpreendimento
            // 
            this.NomeEmpreendimento.DataPropertyName = "NomeEmpreendimento";
            this.NomeEmpreendimento.HeaderText = "Empreendimento";
            this.NomeEmpreendimento.MinimumWidth = 6;
            this.NomeEmpreendimento.Name = "NomeEmpreendimento";
            this.NomeEmpreendimento.ReadOnly = true;
            this.NomeEmpreendimento.Width = 200;
            // 
            // Endereco
            // 
            this.Endereco.DataPropertyName = "Endereco";
            this.Endereco.HeaderText = "Endereço";
            this.Endereco.MinimumWidth = 6;
            this.Endereco.Name = "Endereco";
            this.Endereco.ReadOnly = true;
            this.Endereco.Width = 200;
            // 
            // NomeCliente
            // 
            this.NomeCliente.DataPropertyName = "NomeCliente";
            this.NomeCliente.HeaderText = "Cliente";
            this.NomeCliente.MinimumWidth = 6;
            this.NomeCliente.Name = "NomeCliente";
            this.NomeCliente.ReadOnly = true;
            this.NomeCliente.Width = 200;
            // 
            // NomeCorretor
            // 
            this.NomeCorretor.DataPropertyName = "NomeCorretor";
            this.NomeCorretor.HeaderText = "Corretor";
            this.NomeCorretor.MinimumWidth = 6;
            this.NomeCorretor.Name = "NomeCorretor";
            this.NomeCorretor.ReadOnly = true;
            this.NomeCorretor.Width = 200;
            // 
            // vendasBindingSource
            // 
            this.vendasBindingSource.DataSource = typeof(Models.Vendas);
            // 
            // labelConsultaVendas
            // 
            this.labelConsultaVendas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelConsultaVendas.BackColor = System.Drawing.Color.Gold;
            this.labelConsultaVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsultaVendas.Location = new System.Drawing.Point(415, 0);
            this.labelConsultaVendas.Name = "labelConsultaVendas";
            this.labelConsultaVendas.Size = new System.Drawing.Size(509, 75);
            this.labelConsultaVendas.TabIndex = 2;
            this.labelConsultaVendas.Text = "Consulta vendas";
            this.labelConsultaVendas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBuscar.Location = new System.Drawing.Point(229, 102);
            this.textBoxBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(736, 22);
            this.textBoxBuscar.TabIndex = 3;
            // 
            // buttonBuscarVenda
            // 
            this.buttonBuscarVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscarVenda.Location = new System.Drawing.Point(981, 101);
            this.buttonBuscarVenda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscarVenda.Name = "buttonBuscarVenda";
            this.buttonBuscarVenda.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarVenda.TabIndex = 4;
            this.buttonBuscarVenda.Text = "Buscar";
            this.buttonBuscarVenda.UseVisualStyleBackColor = true;
            this.buttonBuscarVenda.Click += new System.EventHandler(this.buttonBuscarVenda_Click);
            // 
            // buttonAlterarVenda
            // 
            this.buttonAlterarVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAlterarVenda.Location = new System.Drawing.Point(1061, 101);
            this.buttonAlterarVenda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAlterarVenda.Name = "buttonAlterarVenda";
            this.buttonAlterarVenda.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarVenda.TabIndex = 5;
            this.buttonAlterarVenda.Text = "Alterar";
            this.buttonAlterarVenda.UseVisualStyleBackColor = true;
            this.buttonAlterarVenda.Click += new System.EventHandler(this.buttonAlterarVenda_Click);
            // 
            // buttonInserirVenda
            // 
            this.buttonInserirVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInserirVenda.Location = new System.Drawing.Point(1143, 102);
            this.buttonInserirVenda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInserirVenda.Name = "buttonInserirVenda";
            this.buttonInserirVenda.Size = new System.Drawing.Size(75, 23);
            this.buttonInserirVenda.TabIndex = 6;
            this.buttonInserirVenda.Text = "Inserir";
            this.buttonInserirVenda.UseVisualStyleBackColor = true;
            this.buttonInserirVenda.Click += new System.EventHandler(this.buttonInserirVenda_Click_1);
            // 
            // buttonExcluirVenda
            // 
            this.buttonExcluirVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcluirVenda.Location = new System.Drawing.Point(1224, 101);
            this.buttonExcluirVenda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExcluirVenda.Name = "buttonExcluirVenda";
            this.buttonExcluirVenda.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirVenda.TabIndex = 7;
            this.buttonExcluirVenda.Text = "Excluir";
            this.buttonExcluirVenda.UseVisualStyleBackColor = true;
            this.buttonExcluirVenda.Click += new System.EventHandler(this.buttonExcluirVenda_Click);
            // 
            // comboBoxBuscarPor
            // 
            this.comboBoxBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBuscarPor.FormattingEnabled = true;
            this.comboBoxBuscarPor.Items.AddRange(new object[] {
            "ID",
            "Nome Cliente",
            "Nome Corretor",
            "Nome Empreendimento",
            "Endereço",
            "Todos"});
            this.comboBoxBuscarPor.Location = new System.Drawing.Point(12, 100);
            this.comboBoxBuscarPor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            this.comboBoxBuscarPor.Size = new System.Drawing.Size(212, 24);
            this.comboBoxBuscarPor.TabIndex = 8;
            // 
            // buttonSelecionarVenda
            // 
            this.buttonSelecionarVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelecionarVenda.Location = new System.Drawing.Point(1132, 572);
            this.buttonSelecionarVenda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelecionarVenda.Name = "buttonSelecionarVenda";
            this.buttonSelecionarVenda.Size = new System.Drawing.Size(85, 23);
            this.buttonSelecionarVenda.TabIndex = 9;
            this.buttonSelecionarVenda.Text = "Selecionar";
            this.buttonSelecionarVenda.UseVisualStyleBackColor = true;
            this.buttonSelecionarVenda.Click += new System.EventHandler(this.buttonSelecionarVenda_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Location = new System.Drawing.Point(1232, 572);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(85, 23);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Buscar por";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LocacaoLaboratorio.Properties.Resources.Foto_de_fundo_2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1331, 607);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FormConsultaVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 607);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSelecionarVenda);
            this.Controls.Add(this.comboBoxBuscarPor);
            this.Controls.Add(this.buttonExcluirVenda);
            this.Controls.Add(this.buttonInserirVenda);
            this.Controls.Add(this.buttonAlterarVenda);
            this.Controls.Add(this.buttonBuscarVenda);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.labelConsultaVendas);
            this.Controls.Add(this.vendasDataGridView);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "FormConsultaVendas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormConsultaVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource vendasBindingSource;
        private System.Windows.Forms.DataGridView vendasDataGridView;
        private System.Windows.Forms.Label labelConsultaVendas;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button buttonBuscarVenda;
        private System.Windows.Forms.Button buttonAlterarVenda;
        private System.Windows.Forms.Button buttonInserirVenda;
        private System.Windows.Forms.Button buttonExcluirVenda;
        private System.Windows.Forms.ComboBox comboBoxBuscarPor;
        private System.Windows.Forms.Button buttonSelecionarVenda;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeEmpreendimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCorretor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}