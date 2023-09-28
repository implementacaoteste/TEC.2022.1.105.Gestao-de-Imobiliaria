namespace LocacaoLaboratorio
{
    partial class FormBuscarReserva
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
            this.reservaDataGridView = new System.Windows.Forms.DataGridView();
            this.idReservaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDaReservaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prazoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataReservaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCorretor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TerrenoDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonExcluirUsuario = new System.Windows.Forms.Button();
            this.buttonAdicionarUsuario = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.comboBoxBuscarPor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.reservaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reservaDataGridView
            // 
            this.reservaDataGridView.AllowUserToAddRows = false;
            this.reservaDataGridView.AllowUserToDeleteRows = false;
            this.reservaDataGridView.AllowUserToOrderColumns = true;
            this.reservaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reservaDataGridView.AutoGenerateColumns = false;
            this.reservaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idReservaDataGridViewTextBoxColumn,
            this.statusDaReservaDataGridViewTextBoxColumn,
            this.prazoDataGridViewTextBoxColumn,
            this.dataReservaDataGridViewTextBoxColumn,
            this.NomeCorretor,
            this.TerrenoDescricao});
            this.reservaDataGridView.DataSource = this.reservaBindingSource;
            this.reservaDataGridView.Location = new System.Drawing.Point(38, 140);
            this.reservaDataGridView.Name = "reservaDataGridView";
            this.reservaDataGridView.ReadOnly = true;
            this.reservaDataGridView.RowHeadersWidth = 51;
            this.reservaDataGridView.RowTemplate.Height = 24;
            this.reservaDataGridView.Size = new System.Drawing.Size(809, 310);
            this.reservaDataGridView.TabIndex = 1;
            // 
            // idReservaDataGridViewTextBoxColumn
            // 
            this.idReservaDataGridViewTextBoxColumn.DataPropertyName = "IdReserva";
            this.idReservaDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idReservaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idReservaDataGridViewTextBoxColumn.Name = "idReservaDataGridViewTextBoxColumn";
            this.idReservaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idReservaDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDaReservaDataGridViewTextBoxColumn
            // 
            this.statusDaReservaDataGridViewTextBoxColumn.DataPropertyName = "StatusDaReserva";
            this.statusDaReservaDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDaReservaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDaReservaDataGridViewTextBoxColumn.Name = "statusDaReservaDataGridViewTextBoxColumn";
            this.statusDaReservaDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDaReservaDataGridViewTextBoxColumn.Width = 200;
            // 
            // prazoDataGridViewTextBoxColumn
            // 
            this.prazoDataGridViewTextBoxColumn.DataPropertyName = "Prazo";
            this.prazoDataGridViewTextBoxColumn.HeaderText = "Prazo";
            this.prazoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prazoDataGridViewTextBoxColumn.Name = "prazoDataGridViewTextBoxColumn";
            this.prazoDataGridViewTextBoxColumn.ReadOnly = true;
            this.prazoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataReservaDataGridViewTextBoxColumn
            // 
            this.dataReservaDataGridViewTextBoxColumn.DataPropertyName = "DataReserva";
            this.dataReservaDataGridViewTextBoxColumn.HeaderText = "Data reserva";
            this.dataReservaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataReservaDataGridViewTextBoxColumn.Name = "dataReservaDataGridViewTextBoxColumn";
            this.dataReservaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataReservaDataGridViewTextBoxColumn.Width = 120;
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
            // TerrenoDescricao
            // 
            this.TerrenoDescricao.DataPropertyName = "TerrenoDescricao";
            this.TerrenoDescricao.HeaderText = "Terreno";
            this.TerrenoDescricao.MinimumWidth = 6;
            this.TerrenoDescricao.Name = "TerrenoDescricao";
            this.TerrenoDescricao.ReadOnly = true;
            this.TerrenoDescricao.Width = 350;
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataSource = typeof(Models.Reserva);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(879, 67);
            this.label1.TabIndex = 13;
            this.label1.Text = "Gestão de Reserva";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "O &que deseja buscar?";
            // 
            // buttonExcluirUsuario
            // 
            this.buttonExcluirUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcluirUsuario.Location = new System.Drawing.Point(770, 107);
            this.buttonExcluirUsuario.Name = "buttonExcluirUsuario";
            this.buttonExcluirUsuario.Size = new System.Drawing.Size(75, 28);
            this.buttonExcluirUsuario.TabIndex = 19;
            this.buttonExcluirUsuario.Text = "&Excluir";
            this.buttonExcluirUsuario.UseVisualStyleBackColor = true;
            this.buttonExcluirUsuario.Click += new System.EventHandler(this.buttonExcluir_click);
            // 
            // buttonAdicionarUsuario
            // 
            this.buttonAdicionarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdicionarUsuario.Location = new System.Drawing.Point(689, 107);
            this.buttonAdicionarUsuario.Name = "buttonAdicionarUsuario";
            this.buttonAdicionarUsuario.Size = new System.Drawing.Size(75, 28);
            this.buttonAdicionarUsuario.TabIndex = 18;
            this.buttonAdicionarUsuario.Text = "Inserir";
            this.buttonAdicionarUsuario.UseVisualStyleBackColor = true;
            this.buttonAdicionarUsuario.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAlterar.Location = new System.Drawing.Point(608, 107);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 28);
            this.buttonAlterar.TabIndex = 17;
            this.buttonAlterar.Text = "Al&terar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.ButtonAlterar_click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscar.Location = new System.Drawing.Point(527, 108);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 27);
            this.buttonBuscar.TabIndex = 16;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.ButtonBuscar_click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBuscar.Location = new System.Drawing.Point(162, 111);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(359, 22);
            this.textBoxBuscar.TabIndex = 15;
            // 
            // comboBoxBuscarPor
            // 
            this.comboBoxBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBuscarPor.FormattingEnabled = true;
            this.comboBoxBuscarPor.Items.AddRange(new object[] {
            "Id",
            "BuscarTodos"});
            this.comboBoxBuscarPor.Location = new System.Drawing.Point(38, 110);
            this.comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            this.comboBoxBuscarPor.Size = new System.Drawing.Size(118, 24);
            this.comboBoxBuscarPor.TabIndex = 20;
            // 
            // FormBuscarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 472);
            this.Controls.Add(this.comboBoxBuscarPor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonExcluirUsuario);
            this.Controls.Add(this.buttonAdicionarUsuario);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reservaDataGridView);
            this.MinimizeBox = false;
            this.Name = "FormBuscarReserva";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.FormBuscarReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView reservaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonExcluirUsuario;
        private System.Windows.Forms.Button buttonAdicionarUsuario;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.ComboBox comboBoxBuscarPor;
        private System.Windows.Forms.BindingSource reservaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReservaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDaReservaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prazoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataReservaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCorretor;
        private System.Windows.Forms.DataGridViewTextBoxColumn TerrenoDescricao;
    }
}