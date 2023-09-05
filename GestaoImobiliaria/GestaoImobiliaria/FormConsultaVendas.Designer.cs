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
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.vendasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vendasDataGridView
            // 
            this.vendasDataGridView.AutoGenerateColumns = false;
            this.vendasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.vendasDataGridView.DataSource = this.vendasBindingSource;
            this.vendasDataGridView.Location = new System.Drawing.Point(12, 130);
            this.vendasDataGridView.Name = "vendasDataGridView";
            this.vendasDataGridView.RowHeadersWidth = 51;
            this.vendasDataGridView.RowTemplate.Height = 24;
            this.vendasDataGridView.Size = new System.Drawing.Size(776, 269);
            this.vendasDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDVenda";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDVenda";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IDTerreno";
            this.dataGridViewTextBoxColumn2.HeaderText = "IDTerreno";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IDCliente";
            this.dataGridViewTextBoxColumn3.HeaderText = "IDCliente";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IDCorretor";
            this.dataGridViewTextBoxColumn4.HeaderText = "IDCorretor";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // vendasBindingSource
            // 
            this.vendasBindingSource.DataSource = typeof(Models.Vendas);
            // 
            // labelConsultaVendas
            // 
            this.labelConsultaVendas.AutoSize = true;
            this.labelConsultaVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsultaVendas.Location = new System.Drawing.Point(305, 9);
            this.labelConsultaVendas.Name = "labelConsultaVendas";
            this.labelConsultaVendas.Size = new System.Drawing.Size(221, 31);
            this.labelConsultaVendas.TabIndex = 2;
            this.labelConsultaVendas.Text = "Consulta Vendas";
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(131, 102);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(305, 22);
            this.textBoxBuscar.TabIndex = 3;
            // 
            // buttonBuscarVenda
            // 
            this.buttonBuscarVenda.Location = new System.Drawing.Point(451, 101);
            this.buttonBuscarVenda.Name = "buttonBuscarVenda";
            this.buttonBuscarVenda.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarVenda.TabIndex = 4;
            this.buttonBuscarVenda.Text = "Buscar";
            this.buttonBuscarVenda.UseVisualStyleBackColor = true;
            this.buttonBuscarVenda.Click += new System.EventHandler(this.buttonBuscarVenda_Click);
            // 
            // buttonAlterarVenda
            // 
            this.buttonAlterarVenda.Location = new System.Drawing.Point(532, 101);
            this.buttonAlterarVenda.Name = "buttonAlterarVenda";
            this.buttonAlterarVenda.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarVenda.TabIndex = 5;
            this.buttonAlterarVenda.Text = "Alterar";
            this.buttonAlterarVenda.UseVisualStyleBackColor = true;
            this.buttonAlterarVenda.Click += new System.EventHandler(this.buttonAlterarVenda_Click);
            // 
            // buttonInserirVenda
            // 
            this.buttonInserirVenda.Location = new System.Drawing.Point(613, 102);
            this.buttonInserirVenda.Name = "buttonInserirVenda";
            this.buttonInserirVenda.Size = new System.Drawing.Size(75, 23);
            this.buttonInserirVenda.TabIndex = 6;
            this.buttonInserirVenda.Text = "Inserir";
            this.buttonInserirVenda.UseVisualStyleBackColor = true;
            this.buttonInserirVenda.Click += new System.EventHandler(this.buttonInserirVenda_Click);
            // 
            // buttonExcluirVenda
            // 
            this.buttonExcluirVenda.Location = new System.Drawing.Point(694, 101);
            this.buttonExcluirVenda.Name = "buttonExcluirVenda";
            this.buttonExcluirVenda.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirVenda.TabIndex = 7;
            this.buttonExcluirVenda.Text = "Excluir";
            this.buttonExcluirVenda.UseVisualStyleBackColor = true;
            this.buttonExcluirVenda.Click += new System.EventHandler(this.buttonExcluirVenda_Click);
            // 
            // comboBoxBuscarPor
            // 
            this.comboBoxBuscarPor.FormattingEnabled = true;
            this.comboBoxBuscarPor.Location = new System.Drawing.Point(12, 100);
            this.comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            this.comboBoxBuscarPor.Size = new System.Drawing.Size(113, 24);
            this.comboBoxBuscarPor.TabIndex = 8;
            // 
            // buttonSelecionarVenda
            // 
            this.buttonSelecionarVenda.Location = new System.Drawing.Point(602, 415);
            this.buttonSelecionarVenda.Name = "buttonSelecionarVenda";
            this.buttonSelecionarVenda.Size = new System.Drawing.Size(86, 23);
            this.buttonSelecionarVenda.TabIndex = 9;
            this.buttonSelecionarVenda.Text = "Selecionar";
            this.buttonSelecionarVenda.UseVisualStyleBackColor = true;
            this.buttonSelecionarVenda.Click += new System.EventHandler(this.buttonSelecionarVenda_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Location = new System.Drawing.Point(702, 415);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(86, 23);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "BuscarPor";
            // 
            // FormConsultaVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "FormConsultaVendas";
            this.Text = "FormConsultaVendas";
            ((System.ComponentModel.ISupportInitialize)(this.vendasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource vendasBindingSource;
        private System.Windows.Forms.DataGridView vendasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
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
    }
}