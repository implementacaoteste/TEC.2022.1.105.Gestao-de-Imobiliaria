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
            System.Windows.Forms.Label statusDaReservaLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label matriculaLabel;
            System.Windows.Forms.Label nomeEmpreendimentoLabel;
            this.dataReservaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prazoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.statusDaReservaTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.matriculaTextBox = new System.Windows.Forms.TextBox();
            this.nomeEmpreendimentoTextBox = new System.Windows.Forms.TextBox();
            this.buttonBuscarCorretor = new System.Windows.Forms.Button();
            this.buttonBuscarTerreno = new System.Windows.Forms.Button();
            dataReservaLabel = new System.Windows.Forms.Label();
            prazoLabel = new System.Windows.Forms.Label();
            statusDaReservaLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            matriculaLabel = new System.Windows.Forms.Label();
            nomeEmpreendimentoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataReservaLabel
            // 
            dataReservaLabel.AutoSize = true;
            dataReservaLabel.Location = new System.Drawing.Point(544, 94);
            dataReservaLabel.Name = "dataReservaLabel";
            dataReservaLabel.Size = new System.Drawing.Size(94, 16);
            dataReservaLabel.TabIndex = 3;
            dataReservaLabel.Text = "Data Reserva:";
            // 
            // prazoLabel
            // 
            prazoLabel.AutoSize = true;
            prazoLabel.Location = new System.Drawing.Point(681, 94);
            prazoLabel.Name = "prazoLabel";
            prazoLabel.Size = new System.Drawing.Size(45, 16);
            prazoLabel.TabIndex = 4;
            prazoLabel.Text = "Prazo:";
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
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(33, 147);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(55, 16);
            nomeLabel.TabIndex = 16;
            nomeLabel.Text = "Corretor";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(33, 219);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(69, 16);
            enderecoLabel.TabIndex = 17;
            enderecoLabel.Text = "Endereco:";
            // 
            // matriculaLabel
            // 
            matriculaLabel.AutoSize = true;
            matriculaLabel.Location = new System.Drawing.Point(327, 219);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.Size = new System.Drawing.Size(64, 16);
            matriculaLabel.TabIndex = 18;
            matriculaLabel.Text = "Matricula:";
            // 
            // nomeEmpreendimentoLabel
            // 
            nomeEmpreendimentoLabel.AutoSize = true;
            nomeEmpreendimentoLabel.Location = new System.Drawing.Point(433, 219);
            nomeEmpreendimentoLabel.Name = "nomeEmpreendimentoLabel";
            nomeEmpreendimentoLabel.Size = new System.Drawing.Size(153, 16);
            nomeEmpreendimentoLabel.TabIndex = 19;
            nomeEmpreendimentoLabel.Text = "Nome Empreendimento:";
            // 
            // dataReservaDateTimePicker
            // 
            this.dataReservaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservaBindingSource, "DataReserva", true));
            this.dataReservaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataReservaDateTimePicker.Location = new System.Drawing.Point(547, 113);
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
            this.prazoDateTimePicker.Location = new System.Drawing.Point(684, 113);
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
            // statusDaReservaTextBox
            // 
            this.statusDaReservaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "StatusDaReserva", true));
            this.statusDaReservaTextBox.Location = new System.Drawing.Point(36, 113);
            this.statusDaReservaTextBox.Name = "statusDaReservaTextBox";
            this.statusDaReservaTextBox.Size = new System.Drawing.Size(505, 22);
            this.statusDaReservaTextBox.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonSalvar_click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(688, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Corretor.Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(36, 166);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(285, 22);
            this.nomeTextBox.TabIndex = 17;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Terreno.Endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(36, 238);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(285, 22);
            this.enderecoTextBox.TabIndex = 18;
            // 
            // matriculaTextBox
            // 
            this.matriculaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Terreno.Matricula", true));
            this.matriculaTextBox.Location = new System.Drawing.Point(330, 238);
            this.matriculaTextBox.Name = "matriculaTextBox";
            this.matriculaTextBox.Size = new System.Drawing.Size(100, 22);
            this.matriculaTextBox.TabIndex = 19;
            // 
            // nomeEmpreendimentoTextBox
            // 
            this.nomeEmpreendimentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Terreno.NomeEmpreendimento", true));
            this.nomeEmpreendimentoTextBox.Location = new System.Drawing.Point(436, 238);
            this.nomeEmpreendimentoTextBox.Name = "nomeEmpreendimentoTextBox";
            this.nomeEmpreendimentoTextBox.Size = new System.Drawing.Size(246, 22);
            this.nomeEmpreendimentoTextBox.TabIndex = 20;
            // 
            // buttonBuscarCorretor
            // 
            this.buttonBuscarCorretor.Location = new System.Drawing.Point(327, 166);
            this.buttonBuscarCorretor.Name = "buttonBuscarCorretor";
            this.buttonBuscarCorretor.Size = new System.Drawing.Size(28, 23);
            this.buttonBuscarCorretor.TabIndex = 21;
            this.buttonBuscarCorretor.Text = "...";
            this.buttonBuscarCorretor.UseVisualStyleBackColor = true;
            this.buttonBuscarCorretor.Click += new System.EventHandler(this.buttonBuscarCorretor_Click);
            // 
            // buttonBuscarTerreno
            // 
            this.buttonBuscarTerreno.Location = new System.Drawing.Point(688, 238);
            this.buttonBuscarTerreno.Name = "buttonBuscarTerreno";
            this.buttonBuscarTerreno.Size = new System.Drawing.Size(28, 23);
            this.buttonBuscarTerreno.TabIndex = 21;
            this.buttonBuscarTerreno.Text = "...";
            this.buttonBuscarTerreno.UseVisualStyleBackColor = true;
            this.buttonBuscarTerreno.Click += new System.EventHandler(this.buttonBuscarTerreno_Click);
            // 
            // FormCadastroReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 433);
            this.Controls.Add(this.buttonBuscarTerreno);
            this.Controls.Add(this.buttonBuscarCorretor);
            this.Controls.Add(nomeEmpreendimentoLabel);
            this.Controls.Add(this.nomeEmpreendimentoTextBox);
            this.Controls.Add(matriculaLabel);
            this.Controls.Add(this.matriculaTextBox);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(statusDaReservaLabel);
            this.Controls.Add(this.statusDaReservaTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(prazoLabel);
            this.Controls.Add(this.prazoDateTimePicker);
            this.Controls.Add(dataReservaLabel);
            this.Controls.Add(this.dataReservaDateTimePicker);
            this.Name = "FormCadastroReserva";
            this.Text = "FormCadastroReserva";
            this.Load += new System.EventHandler(this.FormCadastroReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource reservaBindingSource;
        private System.Windows.Forms.DateTimePicker dataReservaDateTimePicker;
        private System.Windows.Forms.DateTimePicker prazoDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox statusDaReservaTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox matriculaTextBox;
        private System.Windows.Forms.TextBox nomeEmpreendimentoTextBox;
        private System.Windows.Forms.Button buttonBuscarCorretor;
        private System.Windows.Forms.Button buttonBuscarTerreno;
    }
}