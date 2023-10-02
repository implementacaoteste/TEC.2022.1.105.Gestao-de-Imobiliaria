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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroReserva));
            this.dataReservaDateTimePicker = new System.Windows.Forms.DateTimePicker();
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
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            dataReservaLabel = new System.Windows.Forms.Label();
            prazoLabel = new System.Windows.Forms.Label();
            statusDaReservaLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            matriculaLabel = new System.Windows.Forms.Label();
            nomeEmpreendimentoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataReservaLabel
            // 
            dataReservaLabel.AutoSize = true;
            dataReservaLabel.BackColor = System.Drawing.Color.Gold;
            dataReservaLabel.Location = new System.Drawing.Point(406, 86);
            dataReservaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dataReservaLabel.Name = "dataReservaLabel";
            dataReservaLabel.Size = new System.Drawing.Size(76, 13);
            dataReservaLabel.TabIndex = 3;
            dataReservaLabel.Text = "Data Reserva:";
            // 
            // prazoLabel
            // 
            prazoLabel.AutoSize = true;
            prazoLabel.BackColor = System.Drawing.Color.Gold;
            prazoLabel.Location = new System.Drawing.Point(509, 86);
            prazoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            prazoLabel.Name = "prazoLabel";
            prazoLabel.Size = new System.Drawing.Size(37, 13);
            prazoLabel.TabIndex = 4;
            prazoLabel.Text = "Prazo:";
            // 
            // statusDaReservaLabel
            // 
            statusDaReservaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            statusDaReservaLabel.AutoSize = true;
            statusDaReservaLabel.BackColor = System.Drawing.Color.Gold;
            statusDaReservaLabel.Location = new System.Drawing.Point(23, 86);
            statusDaReservaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            statusDaReservaLabel.Name = "statusDaReservaLabel";
            statusDaReservaLabel.Size = new System.Drawing.Size(37, 13);
            statusDaReservaLabel.TabIndex = 13;
            statusDaReservaLabel.Text = "Status";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.BackColor = System.Drawing.Color.Gold;
            nomeLabel.Location = new System.Drawing.Point(23, 129);
            nomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(44, 13);
            nomeLabel.TabIndex = 16;
            nomeLabel.Text = "Corretor";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.BackColor = System.Drawing.Color.Gold;
            enderecoLabel.Location = new System.Drawing.Point(23, 188);
            enderecoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(53, 13);
            enderecoLabel.TabIndex = 17;
            enderecoLabel.Text = "Endereço";
            // 
            // matriculaLabel
            // 
            matriculaLabel.AutoSize = true;
            matriculaLabel.BackColor = System.Drawing.Color.Gold;
            matriculaLabel.Location = new System.Drawing.Point(243, 188);
            matriculaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            matriculaLabel.Size = new System.Drawing.Size(52, 13);
            matriculaLabel.TabIndex = 18;
            matriculaLabel.Text = "Matrícula";
            // 
            // nomeEmpreendimentoLabel
            // 
            nomeEmpreendimentoLabel.AutoSize = true;
            nomeEmpreendimentoLabel.BackColor = System.Drawing.Color.Gold;
            nomeEmpreendimentoLabel.Location = new System.Drawing.Point(323, 188);
            nomeEmpreendimentoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nomeEmpreendimentoLabel.Name = "nomeEmpreendimentoLabel";
            nomeEmpreendimentoLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            nomeEmpreendimentoLabel.Size = new System.Drawing.Size(86, 13);
            nomeEmpreendimentoLabel.TabIndex = 19;
            nomeEmpreendimentoLabel.Text = "Empreendimento";
            // 
            // dataReservaDateTimePicker
            // 
            this.dataReservaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservaBindingSource, "DataReserva", true));
            this.dataReservaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataReservaDateTimePicker.Location = new System.Drawing.Point(408, 102);
            this.dataReservaDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataReservaDateTimePicker.Name = "dataReservaDateTimePicker";
            this.dataReservaDateTimePicker.Size = new System.Drawing.Size(90, 20);
            this.dataReservaDateTimePicker.TabIndex = 4;
            // 
            // prazoDateTimePicker
            // 
            this.prazoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservaBindingSource, "Prazo", true));
            this.prazoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.prazoDateTimePicker.Location = new System.Drawing.Point(511, 102);
            this.prazoDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prazoDateTimePicker.Name = "prazoDateTimePicker";
            this.prazoDateTimePicker.Size = new System.Drawing.Size(88, 20);
            this.prazoDateTimePicker.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 54);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cadastro de reserva";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusDaReservaTextBox
            // 
            this.statusDaReservaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "StatusDaReserva", true));
            this.statusDaReservaTextBox.Location = new System.Drawing.Point(25, 102);
            this.statusDaReservaTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statusDaReservaTextBox.Name = "statusDaReservaTextBox";
            this.statusDaReservaTextBox.Size = new System.Drawing.Size(380, 20);
            this.statusDaReservaTextBox.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(437, 317);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 19);
            this.button1.TabIndex = 15;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonSalvar_click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(516, 317);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 19);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Corretor.Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(25, 145);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(215, 20);
            this.nomeTextBox.TabIndex = 17;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Terreno.Endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(25, 203);
            this.enderecoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(215, 20);
            this.enderecoTextBox.TabIndex = 18;
            // 
            // matriculaTextBox
            // 
            this.matriculaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Terreno.Matricula", true));
            this.matriculaTextBox.Location = new System.Drawing.Point(246, 203);
            this.matriculaTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.matriculaTextBox.Name = "matriculaTextBox";
            this.matriculaTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.matriculaTextBox.Size = new System.Drawing.Size(76, 20);
            this.matriculaTextBox.TabIndex = 19;
            // 
            // nomeEmpreendimentoTextBox
            // 
            this.nomeEmpreendimentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Terreno.NomeEmpreendimento", true));
            this.nomeEmpreendimentoTextBox.Location = new System.Drawing.Point(325, 203);
            this.nomeEmpreendimentoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nomeEmpreendimentoTextBox.Name = "nomeEmpreendimentoTextBox";
            this.nomeEmpreendimentoTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nomeEmpreendimentoTextBox.Size = new System.Drawing.Size(186, 20);
            this.nomeEmpreendimentoTextBox.TabIndex = 20;
            // 
            // buttonBuscarCorretor
            // 
            this.buttonBuscarCorretor.Location = new System.Drawing.Point(243, 145);
            this.buttonBuscarCorretor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBuscarCorretor.Name = "buttonBuscarCorretor";
            this.buttonBuscarCorretor.Size = new System.Drawing.Size(21, 19);
            this.buttonBuscarCorretor.TabIndex = 21;
            this.buttonBuscarCorretor.Text = "...";
            this.buttonBuscarCorretor.UseVisualStyleBackColor = true;
            this.buttonBuscarCorretor.Click += new System.EventHandler(this.buttonBuscarCorretor_Click);
            // 
            // buttonBuscarTerreno
            // 
            this.buttonBuscarTerreno.Location = new System.Drawing.Point(514, 203);
            this.buttonBuscarTerreno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBuscarTerreno.Name = "buttonBuscarTerreno";
            this.buttonBuscarTerreno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonBuscarTerreno.Size = new System.Drawing.Size(21, 19);
            this.buttonBuscarTerreno.TabIndex = 21;
            this.buttonBuscarTerreno.Text = "...";
            this.buttonBuscarTerreno.UseVisualStyleBackColor = true;
            this.buttonBuscarTerreno.Click += new System.EventHandler(this.buttonBuscarTerreno_Click);
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataSource = typeof(Models.Reserva);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LocacaoLaboratorio.Properties.Resources.Foto_de_fundo_2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(609, 352);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // FormCadastroReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 352);
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
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCadastroReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastroReserva";
            this.Load += new System.EventHandler(this.FormCadastroReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox matriculaTextBox;
        private System.Windows.Forms.TextBox nomeEmpreendimentoTextBox;
        private System.Windows.Forms.Button buttonBuscarCorretor;
        private System.Windows.Forms.Button buttonBuscarTerreno;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}