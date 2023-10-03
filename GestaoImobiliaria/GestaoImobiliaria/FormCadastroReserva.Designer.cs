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
            dataReservaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataReservaLabel.Location = new System.Drawing.Point(676, 132);
            dataReservaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataReservaLabel.Name = "dataReservaLabel";
            dataReservaLabel.Size = new System.Drawing.Size(117, 20);
            dataReservaLabel.TabIndex = 3;
            dataReservaLabel.Text = "Data Reserva:";
            // 
            // prazoLabel
            // 
            prazoLabel.AutoSize = true;
            prazoLabel.BackColor = System.Drawing.Color.Gold;
            prazoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prazoLabel.Location = new System.Drawing.Point(849, 132);
            prazoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            prazoLabel.Name = "prazoLabel";
            prazoLabel.Size = new System.Drawing.Size(58, 20);
            prazoLabel.TabIndex = 4;
            prazoLabel.Text = "Prazo:";
            // 
            // statusDaReservaLabel
            // 
            statusDaReservaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            statusDaReservaLabel.AutoSize = true;
            statusDaReservaLabel.BackColor = System.Drawing.Color.Gold;
            statusDaReservaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            statusDaReservaLabel.Location = new System.Drawing.Point(39, 132);
            statusDaReservaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            statusDaReservaLabel.Name = "statusDaReservaLabel";
            statusDaReservaLabel.Size = new System.Drawing.Size(57, 20);
            statusDaReservaLabel.TabIndex = 13;
            statusDaReservaLabel.Text = "Status";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.BackColor = System.Drawing.Color.Gold;
            nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(39, 199);
            nomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(71, 20);
            nomeLabel.TabIndex = 16;
            nomeLabel.Text = "Corretor";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.BackColor = System.Drawing.Color.Gold;
            enderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            enderecoLabel.Location = new System.Drawing.Point(39, 289);
            enderecoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(80, 20);
            enderecoLabel.TabIndex = 17;
            enderecoLabel.Text = "Endereço";
            // 
            // matriculaLabel
            // 
            matriculaLabel.AutoSize = true;
            matriculaLabel.BackColor = System.Drawing.Color.Gold;
            matriculaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            matriculaLabel.Location = new System.Drawing.Point(405, 289);
            matriculaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            matriculaLabel.Size = new System.Drawing.Size(78, 20);
            matriculaLabel.TabIndex = 18;
            matriculaLabel.Text = "Matrícula";
            // 
            // nomeEmpreendimentoLabel
            // 
            nomeEmpreendimentoLabel.AutoSize = true;
            nomeEmpreendimentoLabel.BackColor = System.Drawing.Color.Gold;
            nomeEmpreendimentoLabel.Location = new System.Drawing.Point(539, 289);
            nomeEmpreendimentoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeEmpreendimentoLabel.Name = "nomeEmpreendimentoLabel";
            nomeEmpreendimentoLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            nomeEmpreendimentoLabel.Size = new System.Drawing.Size(135, 20);
            nomeEmpreendimentoLabel.TabIndex = 19;
            nomeEmpreendimentoLabel.Text = "Empreendimento";
            // 
            // dataReservaDateTimePicker
            // 
            this.dataReservaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservaBindingSource, "DataReserva", true));
            this.dataReservaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataReservaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataReservaDateTimePicker.Location = new System.Drawing.Point(680, 158);
            this.dataReservaDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dataReservaDateTimePicker.Name = "dataReservaDateTimePicker";
            this.dataReservaDateTimePicker.Size = new System.Drawing.Size(148, 30);
            this.dataReservaDateTimePicker.TabIndex = 4;
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataSource = typeof(Models.Reserva);
            // 
            // prazoDateTimePicker
            // 
            this.prazoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservaBindingSource, "Prazo", true));
            this.prazoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prazoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.prazoDateTimePicker.Location = new System.Drawing.Point(851, 158);
            this.prazoDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.prazoDateTimePicker.Name = "prazoDateTimePicker";
            this.prazoDateTimePicker.Size = new System.Drawing.Size(144, 30);
            this.prazoDateTimePicker.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 82);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cadastro de reserva";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusDaReservaTextBox
            // 
            this.statusDaReservaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "StatusDaReserva", true));
            this.statusDaReservaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusDaReservaTextBox.Location = new System.Drawing.Point(41, 158);
            this.statusDaReservaTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.statusDaReservaTextBox.Name = "statusDaReservaTextBox";
            this.statusDaReservaTextBox.Size = new System.Drawing.Size(630, 30);
            this.statusDaReservaTextBox.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(694, 488);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonSalvar_click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(860, 488);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 29);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Corretor.Nome", true));
            this.nomeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTextBox.Location = new System.Drawing.Point(41, 222);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(355, 30);
            this.nomeTextBox.TabIndex = 17;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Terreno.Endereco", true));
            this.enderecoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enderecoTextBox.Location = new System.Drawing.Point(41, 312);
            this.enderecoTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(355, 30);
            this.enderecoTextBox.TabIndex = 18;
            // 
            // matriculaTextBox
            // 
            this.matriculaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Terreno.Matricula", true));
            this.matriculaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matriculaTextBox.Location = new System.Drawing.Point(410, 312);
            this.matriculaTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.matriculaTextBox.Name = "matriculaTextBox";
            this.matriculaTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.matriculaTextBox.Size = new System.Drawing.Size(124, 30);
            this.matriculaTextBox.TabIndex = 19;
            // 
            // nomeEmpreendimentoTextBox
            // 
            this.nomeEmpreendimentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Terreno.NomeEmpreendimento", true));
            this.nomeEmpreendimentoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeEmpreendimentoTextBox.Location = new System.Drawing.Point(541, 312);
            this.nomeEmpreendimentoTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.nomeEmpreendimentoTextBox.Name = "nomeEmpreendimentoTextBox";
            this.nomeEmpreendimentoTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nomeEmpreendimentoTextBox.Size = new System.Drawing.Size(308, 30);
            this.nomeEmpreendimentoTextBox.TabIndex = 20;
            // 
            // buttonBuscarCorretor
            // 
            this.buttonBuscarCorretor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarCorretor.Location = new System.Drawing.Point(405, 222);
            this.buttonBuscarCorretor.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonBuscarCorretor.Name = "buttonBuscarCorretor";
            this.buttonBuscarCorretor.Size = new System.Drawing.Size(35, 29);
            this.buttonBuscarCorretor.TabIndex = 21;
            this.buttonBuscarCorretor.Text = "...";
            this.buttonBuscarCorretor.UseVisualStyleBackColor = true;
            this.buttonBuscarCorretor.Click += new System.EventHandler(this.buttonBuscarCorretor_Click);
            // 
            // buttonBuscarTerreno
            // 
            this.buttonBuscarTerreno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarTerreno.Location = new System.Drawing.Point(856, 312);
            this.buttonBuscarTerreno.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonBuscarTerreno.Name = "buttonBuscarTerreno";
            this.buttonBuscarTerreno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonBuscarTerreno.Size = new System.Drawing.Size(35, 29);
            this.buttonBuscarTerreno.TabIndex = 21;
            this.buttonBuscarTerreno.Text = "...";
            this.buttonBuscarTerreno.UseVisualStyleBackColor = true;
            this.buttonBuscarTerreno.Click += new System.EventHandler(this.buttonBuscarTerreno_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LocacaoLaboratorio.Properties.Resources.Foto_de_fundo_2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1015, 541);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // FormCadastroReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 541);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
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