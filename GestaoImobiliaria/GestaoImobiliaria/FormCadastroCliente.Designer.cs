﻿namespace LocacaoLaboratorio
{
    partial class FormCadastroCliente
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
            System.Windows.Forms.Label rGLabel;
            System.Windows.Forms.Label foneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label rendaLabel;
            System.Windows.Forms.Label estadoCivilLabel;
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cPFTextBox = new System.Windows.Forms.TextBox();
            this.rGTextBox = new System.Windows.Forms.TextBox();
            this.foneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.rendaTextBox = new System.Windows.Forms.TextBox();
            this.cPFConjugeTextBox = new System.Windows.Forms.TextBox();
            this.rGConjugeTextBox = new System.Windows.Forms.TextBox();
            this.estadoCivilComboBox = new System.Windows.Forms.ComboBox();
            this.cPFConjugeLabel = new System.Windows.Forms.Label();
            this.rGConjugeLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            rGLabel = new System.Windows.Forms.Label();
            foneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            rendaLabel = new System.Windows.Forms.Label();
            estadoCivilLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(12, 49);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(44, 16);
            nomeLabel.TabIndex = 1;
            nomeLabel.Text = "Nome";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new System.Drawing.Point(425, 49);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(33, 16);
            cPFLabel.TabIndex = 3;
            cPFLabel.Text = "CPF";
            // 
            // rGLabel
            // 
            rGLabel.AutoSize = true;
            rGLabel.Location = new System.Drawing.Point(547, 49);
            rGLabel.Name = "rGLabel";
            rGLabel.Size = new System.Drawing.Size(27, 16);
            rGLabel.TabIndex = 5;
            rGLabel.Text = "RG";
            // 
            // foneLabel
            // 
            foneLabel.AutoSize = true;
            foneLabel.Location = new System.Drawing.Point(12, 93);
            foneLabel.Name = "foneLabel";
            foneLabel.Size = new System.Drawing.Size(38, 16);
            foneLabel.TabIndex = 7;
            foneLabel.Text = "Fone";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(117, 93);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(45, 16);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "E-mail";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(17, 140);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(66, 16);
            enderecoLabel.TabIndex = 13;
            enderecoLabel.Text = "Endereço";
            // 
            // rendaLabel
            // 
            rendaLabel.AutoSize = true;
            rendaLabel.Location = new System.Drawing.Point(429, 94);
            rendaLabel.Name = "rendaLabel";
            rendaLabel.Size = new System.Drawing.Size(51, 16);
            rendaLabel.TabIndex = 15;
            rendaLabel.Text = "Renda:";
            // 
            // estadoCivilLabel
            // 
            estadoCivilLabel.AutoSize = true;
            estadoCivilLabel.Location = new System.Drawing.Point(550, 94);
            estadoCivilLabel.Name = "estadoCivilLabel";
            estadoCivilLabel.Size = new System.Drawing.Size(81, 16);
            estadoCivilLabel.TabIndex = 17;
            estadoCivilLabel.Text = "Estado Civil:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(10, 68);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(412, 22);
            this.nomeTextBox.TabIndex = 2;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Models.Cliente);
            // 
            // cPFTextBox
            // 
            this.cPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "CPF", true));
            this.cPFTextBox.Location = new System.Drawing.Point(428, 68);
            this.cPFTextBox.Name = "cPFTextBox";
            this.cPFTextBox.Size = new System.Drawing.Size(116, 22);
            this.cPFTextBox.TabIndex = 4;
            // 
            // rGTextBox
            // 
            this.rGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "RG", true));
            this.rGTextBox.Location = new System.Drawing.Point(550, 68);
            this.rGTextBox.Name = "rGTextBox";
            this.rGTextBox.Size = new System.Drawing.Size(100, 22);
            this.rGTextBox.TabIndex = 6;
            // 
            // foneTextBox
            // 
            this.foneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Fone", true));
            this.foneTextBox.Location = new System.Drawing.Point(14, 112);
            this.foneTextBox.Name = "foneTextBox";
            this.foneTextBox.Size = new System.Drawing.Size(100, 22);
            this.foneTextBox.TabIndex = 8;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(120, 112);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(302, 22);
            this.emailTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(671, 49);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cadastro de cliente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(467, 236);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(87, 29);
            this.buttonSalvar.TabIndex = 12;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Location = new System.Drawing.Point(560, 236);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(82, 29);
            this.buttonCancelar.TabIndex = 12;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(16, 159);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(406, 22);
            this.enderecoTextBox.TabIndex = 14;
            // 
            // rendaTextBox
            // 
            this.rendaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Renda", true));
            this.rendaTextBox.Location = new System.Drawing.Point(432, 113);
            this.rendaTextBox.Name = "rendaTextBox";
            this.rendaTextBox.Size = new System.Drawing.Size(112, 22);
            this.rendaTextBox.TabIndex = 16;
            // 
            // cPFConjugeTextBox
            // 
            this.cPFConjugeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "CPFConjuge", true));
            this.cPFConjugeTextBox.Location = new System.Drawing.Point(430, 159);
            this.cPFConjugeTextBox.Name = "cPFConjugeTextBox";
            this.cPFConjugeTextBox.Size = new System.Drawing.Size(100, 22);
            this.cPFConjugeTextBox.TabIndex = 20;
            this.cPFConjugeTextBox.Visible = false;
            // 
            // rGConjugeTextBox
            // 
            this.rGConjugeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "RGConjuge", true));
            this.rGConjugeTextBox.Location = new System.Drawing.Point(551, 157);
            this.rGConjugeTextBox.Name = "rGConjugeTextBox";
            this.rGConjugeTextBox.Size = new System.Drawing.Size(100, 22);
            this.rGConjugeTextBox.TabIndex = 22;
            this.rGConjugeTextBox.Visible = false;
            // 
            // estadoCivilComboBox
            // 
            this.estadoCivilComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "EstadoCivil", true));
            this.estadoCivilComboBox.FormattingEnabled = true;
            this.estadoCivilComboBox.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Casado(a)",
            "Separado(a)",
            "Divorciado(a)",
            "Viúvo(a)"});
            this.estadoCivilComboBox.Location = new System.Drawing.Point(550, 110);
            this.estadoCivilComboBox.Name = "estadoCivilComboBox";
            this.estadoCivilComboBox.Size = new System.Drawing.Size(100, 24);
            this.estadoCivilComboBox.TabIndex = 24;
            this.estadoCivilComboBox.SelectedIndexChanged += new System.EventHandler(this.estadoCivilComboBox_SelectedIndexChanged);
            // 
            // cPFConjugeLabel
            // 
            this.cPFConjugeLabel.AutoSize = true;
            this.cPFConjugeLabel.Location = new System.Drawing.Point(429, 138);
            this.cPFConjugeLabel.Name = "cPFConjugeLabel";
            this.cPFConjugeLabel.Size = new System.Drawing.Size(86, 16);
            this.cPFConjugeLabel.TabIndex = 25;
            this.cPFConjugeLabel.Text = "CPF Conjuge";
            this.cPFConjugeLabel.Visible = false;
            // 
            // rGConjugeLabel
            // 
            this.rGConjugeLabel.AutoSize = true;
            this.rGConjugeLabel.Location = new System.Drawing.Point(550, 138);
            this.rGConjugeLabel.Name = "rGConjugeLabel";
            this.rGConjugeLabel.Size = new System.Drawing.Size(80, 16);
            this.rGConjugeLabel.TabIndex = 25;
            this.rGConjugeLabel.Text = "RG Conjuge";
            this.rGConjugeLabel.Visible = false;
            // 
            // FormCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 285);
            this.Controls.Add(this.rGConjugeLabel);
            this.Controls.Add(this.cPFConjugeLabel);
            this.Controls.Add(this.estadoCivilComboBox);
            this.Controls.Add(this.rGConjugeTextBox);
            this.Controls.Add(this.cPFConjugeTextBox);
            this.Controls.Add(estadoCivilLabel);
            this.Controls.Add(rendaLabel);
            this.Controls.Add(this.rendaTextBox);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(foneLabel);
            this.Controls.Add(this.foneTextBox);
            this.Controls.Add(rGLabel);
            this.Controls.Add(this.rGTextBox);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(this.cPFTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Name = "FormCadastroCliente";
            this.Text = "FormCadastroCliente";
            this.Load += new System.EventHandler(this.FormCadastroCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox cPFTextBox;
        private System.Windows.Forms.TextBox rGTextBox;
        private System.Windows.Forms.TextBox foneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox rendaTextBox;
        private System.Windows.Forms.TextBox cPFConjugeTextBox;
        private System.Windows.Forms.TextBox rGConjugeTextBox;
        private System.Windows.Forms.ComboBox estadoCivilComboBox;
        private System.Windows.Forms.Label cPFConjugeLabel;
        private System.Windows.Forms.Label rGConjugeLabel;
    }
}