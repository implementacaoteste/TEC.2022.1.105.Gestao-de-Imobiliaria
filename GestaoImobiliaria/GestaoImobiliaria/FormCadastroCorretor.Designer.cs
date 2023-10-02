namespace LocacaoLaboratorio
{
    partial class FormCadastroCorretor
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label cRECILabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label foneLabel;
            System.Windows.Forms.Label rGLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroCorretor));
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.corretorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cPFTextBox = new System.Windows.Forms.TextBox();
            this.cRECITextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.foneTextBox = new System.Windows.Forms.TextBox();
            this.rGTextBox = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            nomeLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            cRECILabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            foneLabel = new System.Windows.Forms.Label();
            rGLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.corretorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.BackColor = System.Drawing.Color.Gold;
            nomeLabel.Location = new System.Drawing.Point(26, 60);
            nomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(35, 13);
            nomeLabel.TabIndex = 1;
            nomeLabel.Text = "Nome";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.BackColor = System.Drawing.Color.Gold;
            cPFLabel.Location = new System.Drawing.Point(228, 60);
            cPFLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(27, 13);
            cPFLabel.TabIndex = 3;
            cPFLabel.Text = "CPF";
            // 
            // cRECILabel
            // 
            cRECILabel.AutoSize = true;
            cRECILabel.BackColor = System.Drawing.Color.Gold;
            cRECILabel.Location = new System.Drawing.Point(338, 102);
            cRECILabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cRECILabel.Name = "cRECILabel";
            cRECILabel.Size = new System.Drawing.Size(39, 13);
            cRECILabel.TabIndex = 5;
            cRECILabel.Text = "CRECI";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.Color.Gold;
            emailLabel.Location = new System.Drawing.Point(104, 102);
            emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "E-mail";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.BackColor = System.Drawing.Color.Gold;
            enderecoLabel.Location = new System.Drawing.Point(26, 142);
            enderecoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(53, 13);
            enderecoLabel.TabIndex = 9;
            enderecoLabel.Text = "Endereço";
            // 
            // foneLabel
            // 
            foneLabel.AutoSize = true;
            foneLabel.BackColor = System.Drawing.Color.Gold;
            foneLabel.Location = new System.Drawing.Point(26, 102);
            foneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            foneLabel.Name = "foneLabel";
            foneLabel.Size = new System.Drawing.Size(31, 13);
            foneLabel.TabIndex = 11;
            foneLabel.Text = "Fone";
            foneLabel.Click += new System.EventHandler(this.foneLabel_Click);
            // 
            // rGLabel
            // 
            rGLabel.AutoSize = true;
            rGLabel.BackColor = System.Drawing.Color.Gold;
            rGLabel.Location = new System.Drawing.Point(338, 60);
            rGLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            rGLabel.Name = "rGLabel";
            rGLabel.Size = new System.Drawing.Size(23, 13);
            rGLabel.TabIndex = 15;
            rGLabel.Text = "RG";
            rGLabel.Click += new System.EventHandler(this.rGLabel_Click);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corretorBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(26, 76);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomeTextBox.TabIndex = 2;
            // 
            // corretorBindingSource
            // 
            this.corretorBindingSource.DataSource = typeof(Models.Corretor);
            // 
            // cPFTextBox
            // 
            this.cPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corretorBindingSource, "CPF", true));
            this.cPFTextBox.Location = new System.Drawing.Point(230, 76);
            this.cPFTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cPFTextBox.Name = "cPFTextBox";
            this.cPFTextBox.Size = new System.Drawing.Size(106, 20);
            this.cPFTextBox.TabIndex = 4;
            // 
            // cRECITextBox
            // 
            this.cRECITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corretorBindingSource, "CRECI", true));
            this.cRECITextBox.Location = new System.Drawing.Point(340, 117);
            this.cRECITextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cRECITextBox.Name = "cRECITextBox";
            this.cRECITextBox.Size = new System.Drawing.Size(104, 20);
            this.cRECITextBox.TabIndex = 6;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corretorBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(106, 117);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(230, 20);
            this.emailTextBox.TabIndex = 8;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corretorBindingSource, "Endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(26, 158);
            this.enderecoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(418, 20);
            this.enderecoTextBox.TabIndex = 10;
            // 
            // foneTextBox
            // 
            this.foneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corretorBindingSource, "Fone", true));
            this.foneTextBox.Location = new System.Drawing.Point(26, 117);
            this.foneTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.foneTextBox.Name = "foneTextBox";
            this.foneTextBox.Size = new System.Drawing.Size(76, 20);
            this.foneTextBox.TabIndex = 12;
            // 
            // rGTextBox
            // 
            this.rGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corretorBindingSource, "RG", true));
            this.rGTextBox.Location = new System.Drawing.Point(340, 76);
            this.rGTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rGTextBox.Name = "rGTextBox";
            this.rGTextBox.Size = new System.Drawing.Size(104, 20);
            this.rGTextBox.TabIndex = 16;
            this.rGTextBox.TextChanged += new System.EventHandler(this.rGTextBox_TextChanged);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(304, 188);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(69, 21);
            this.buttonSalvar.TabIndex = 17;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Location = new System.Drawing.Point(377, 188);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(66, 21);
            this.buttonCancelar.TabIndex = 18;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cadastro de corretor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LocacaoLaboratorio.Properties.Resources.Foto_de_fundo_2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // FormCadastroCorretor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 240);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(rGLabel);
            this.Controls.Add(this.rGTextBox);
            this.Controls.Add(foneLabel);
            this.Controls.Add(this.foneTextBox);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(cRECILabel);
            this.Controls.Add(this.cRECITextBox);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(this.cPFTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCadastroCorretor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de corretor";
            this.Load += new System.EventHandler(this.FormCadastroCorretor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.corretorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource corretorBindingSource;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox cPFTextBox;
        private System.Windows.Forms.TextBox cRECITextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox foneTextBox;
        private System.Windows.Forms.TextBox rGTextBox;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}