namespace LocacaoLaboratorio
{
    partial class FormCadastroReserva
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
            System.Windows.Forms.Label dataReservaLabel;
            System.Windows.Forms.Label prazoLabel;
            System.Windows.Forms.Label prazoDeRenovacaoLabel;
            System.Windows.Forms.Label statusDaReservaLabel;
            this.dataReservaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prazoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.prazoDeRenovacaoTextBox = new System.Windows.Forms.TextBox();
            this.statusDaReservaTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listTerrenoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listTerrenoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.listCorretorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            dataReservaLabel = new System.Windows.Forms.Label();
            prazoLabel = new System.Windows.Forms.Label();
            prazoDeRenovacaoLabel = new System.Windows.Forms.Label();
            statusDaReservaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listTerrenoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listTerrenoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCorretorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataReservaLabel
            // 
            dataReservaLabel.AutoSize = true;
            dataReservaLabel.Location = new System.Drawing.Point(671, 94);
            dataReservaLabel.Name = "dataReservaLabel";
            dataReservaLabel.Size = new System.Drawing.Size(94, 16);
            dataReservaLabel.TabIndex = 3;
            dataReservaLabel.Text = "Data Reserva:";
            // 
            // prazoLabel
            // 
            prazoLabel.AutoSize = true;
            prazoLabel.Location = new System.Drawing.Point(671, 144);
            prazoLabel.Name = "prazoLabel";
            prazoLabel.Size = new System.Drawing.Size(45, 16);
            prazoLabel.TabIndex = 4;
            prazoLabel.Text = "Prazo:";
            // 
            // prazoDeRenovacaoLabel
            // 
            prazoDeRenovacaoLabel.AutoSize = true;
            prazoDeRenovacaoLabel.Location = new System.Drawing.Point(33, 144);
            prazoDeRenovacaoLabel.Name = "prazoDeRenovacaoLabel";
            prazoDeRenovacaoLabel.Size = new System.Drawing.Size(140, 16);
            prazoDeRenovacaoLabel.TabIndex = 12;
            prazoDeRenovacaoLabel.Text = "Prazo De Renovacao:";
            // 
            // statusDaReservaLabel
            // 
            statusDaReservaLabel.AutoSize = true;
            statusDaReservaLabel.Location = new System.Drawing.Point(33, 94);
            statusDaReservaLabel.Name = "statusDaReservaLabel";
            statusDaReservaLabel.Size = new System.Drawing.Size(123, 16);
            statusDaReservaLabel.TabIndex = 13;
            statusDaReservaLabel.Text = "Status Da Reserva:";
            // 
            // dataReservaDateTimePicker
            // 
            this.dataReservaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservaBindingSource, "DataReserva", true));
            this.dataReservaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataReservaDateTimePicker.Location = new System.Drawing.Point(674, 113);
            this.dataReservaDateTimePicker.Name = "dataReservaDateTimePicker";
            this.dataReservaDateTimePicker.Size = new System.Drawing.Size(118, 22);
            this.dataReservaDateTimePicker.TabIndex = 4;
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataSource = typeof(Models.Reserva);
            // 
            // prazoDateTimePicker
            // 
            this.prazoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservaBindingSource, "Prazo", true));
            this.prazoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.prazoDateTimePicker.Location = new System.Drawing.Point(674, 163);
            this.prazoDateTimePicker.Name = "prazoDateTimePicker";
            this.prazoDateTimePicker.Size = new System.Drawing.Size(116, 22);
            this.prazoDateTimePicker.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(812, 67);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cadastro de Reserva";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prazoDeRenovacaoTextBox
            // 
            this.prazoDeRenovacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "PrazoDeRenovacao", true));
            this.prazoDeRenovacaoTextBox.Location = new System.Drawing.Point(36, 165);
            this.prazoDeRenovacaoTextBox.Name = "prazoDeRenovacaoTextBox";
            this.prazoDeRenovacaoTextBox.Size = new System.Drawing.Size(632, 22);
            this.prazoDeRenovacaoTextBox.TabIndex = 13;
            // 
            // statusDaReservaTextBox
            // 
            this.statusDaReservaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "StatusDaReserva", true));
            this.statusDaReservaTextBox.Location = new System.Drawing.Point(36, 113);
            this.statusDaReservaTextBox.Name = "statusDaReservaTextBox";
            this.statusDaReservaTextBox.Size = new System.Drawing.Size(632, 22);
            this.statusDaReservaTextBox.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonSalvar_click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(688, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // listTerrenoDataGridView
            // 
            this.listTerrenoDataGridView.AutoGenerateColumns = false;
            this.listTerrenoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listTerrenoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.listTerrenoDataGridView.DataSource = this.listTerrenoBindingSource;
            this.listTerrenoDataGridView.Location = new System.Drawing.Point(25, 242);
            this.listTerrenoDataGridView.Name = "listTerrenoDataGridView";
            this.listTerrenoDataGridView.RowHeadersWidth = 51;
            this.listTerrenoDataGridView.RowTemplate.Height = 24;
            this.listTerrenoDataGridView.Size = new System.Drawing.Size(767, 157);
            this.listTerrenoDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdTerreno";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdTerreno";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdEmpreendimnto";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdEmpreendimnto";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PrecoAVista";
            this.dataGridViewTextBoxColumn3.HeaderText = "PrecoAVista";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PrecoParcelado";
            this.dataGridViewTextBoxColumn4.HeaderText = "PrecoParcelado";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "RedeAguaEnergia";
            this.dataGridViewCheckBoxColumn1.HeaderText = "RedeAguaEnergia";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MetragemFrente";
            this.dataGridViewTextBoxColumn5.HeaderText = "MetragemFrente";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MetragemFundo";
            this.dataGridViewTextBoxColumn6.HeaderText = "MetragemFundo";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MetragemLaterais";
            this.dataGridViewTextBoxColumn7.HeaderText = "MetragemLaterais";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TamanhoTotal";
            this.dataGridViewTextBoxColumn8.HeaderText = "TamanhoTotal";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ConfrontacoesTerreno";
            this.dataGridViewTextBoxColumn9.HeaderText = "ConfrontacoesTerreno";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Endereco";
            this.dataGridViewTextBoxColumn10.HeaderText = "Endereco";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Matricula";
            this.dataGridViewTextBoxColumn11.HeaderText = "Matricula";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // listTerrenoBindingSource
            // 
            this.listTerrenoBindingSource.DataMember = "ListTerreno";
            this.listTerrenoBindingSource.DataSource = this.reservaBindingSource;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(586, 213);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(99, 23);
            this.buttonAdicionar.TabIndex = 15;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.ButtonAdicionarTerreno_Click);
            // 
            // buttonRemover
            // 
            this.buttonRemover.Location = new System.Drawing.Point(691, 213);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(99, 23);
            this.buttonRemover.TabIndex = 15;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            // 
            // listCorretorBindingSource
            // 
            this.listCorretorBindingSource.DataMember = "ListCorretor";
            this.listCorretorBindingSource.DataSource = this.reservaBindingSource;
            // 
            // FormCadastroReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 505);
            this.Controls.Add(this.listTerrenoDataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.button1);
            this.Controls.Add(statusDaReservaLabel);
            this.Controls.Add(this.statusDaReservaTextBox);
            this.Controls.Add(prazoDeRenovacaoLabel);
            this.Controls.Add(this.prazoDeRenovacaoTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(prazoLabel);
            this.Controls.Add(this.prazoDateTimePicker);
            this.Controls.Add(dataReservaLabel);
            this.Controls.Add(this.dataReservaDateTimePicker);
            this.Name = "FormCadastroReserva";
            this.Text = "FormCadastroReserva";
            this.Load += new System.EventHandler(this.FormCadastroReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listTerrenoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listTerrenoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCorretorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource reservaBindingSource;
        private System.Windows.Forms.DateTimePicker dataReservaDateTimePicker;
        private System.Windows.Forms.DateTimePicker prazoDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prazoDeRenovacaoTextBox;
        private System.Windows.Forms.TextBox statusDaReservaTextBox;
        private System.Windows.Forms.BindingSource listCorretorBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource listTerrenoBindingSource;
        private System.Windows.Forms.DataGridView listTerrenoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonRemover;
    }
}