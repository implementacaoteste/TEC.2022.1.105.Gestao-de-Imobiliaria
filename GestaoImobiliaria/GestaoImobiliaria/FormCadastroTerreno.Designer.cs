﻿namespace LocacaoLaboratorio
{
    partial class FormCadastroTerreno
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
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label matriculaLabel;
            System.Windows.Forms.Label metragemDireitaLabel;
            System.Windows.Forms.Label metragemEsquerdaLabel;
            System.Windows.Forms.Label metragemFrenteLabel;
            System.Windows.Forms.Label metragemFundoLabel;
            System.Windows.Forms.Label precoAVistaLabel;
            System.Windows.Forms.Label precoParceladoLabel;
            System.Windows.Forms.Label tamanhoTotalTerrenoLabel;
            System.Windows.Forms.Label nomeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroTerreno));
            this.confrontacoesLabel = new System.Windows.Forms.Label();
            this.labelCadastoTerreno = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.terrenoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matriculaTextBox = new System.Windows.Forms.TextBox();
            this.metragemDireitaTextBox = new System.Windows.Forms.TextBox();
            this.metragemEsquerdaTextBox = new System.Windows.Forms.TextBox();
            this.metragemFrenteTextBox = new System.Windows.Forms.TextBox();
            this.metragemFundoTextBox = new System.Windows.Forms.TextBox();
            this.precoAVistaTextBox = new System.Windows.Forms.TextBox();
            this.precoParceladoTextBox = new System.Windows.Forms.TextBox();
            this.redeAguaCheckBox = new System.Windows.Forms.CheckBox();
            this.redeEnergiaCheckBox = new System.Windows.Forms.CheckBox();
            this.tamanhoTotalTerrenoTextBox = new System.Windows.Forms.TextBox();
            this.confrontacoesTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonBuscarEmpreendimento = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButtonDisponivel = new System.Windows.Forms.RadioButton();
            this.radioButtonReservado = new System.Windows.Forms.RadioButton();
            this.radioButtonVendido = new System.Windows.Forms.RadioButton();
            enderecoLabel = new System.Windows.Forms.Label();
            matriculaLabel = new System.Windows.Forms.Label();
            metragemDireitaLabel = new System.Windows.Forms.Label();
            metragemEsquerdaLabel = new System.Windows.Forms.Label();
            metragemFrenteLabel = new System.Windows.Forms.Label();
            metragemFundoLabel = new System.Windows.Forms.Label();
            precoAVistaLabel = new System.Windows.Forms.Label();
            precoParceladoLabel = new System.Windows.Forms.Label();
            tamanhoTotalTerrenoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.terrenoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.BackColor = System.Drawing.Color.Gold;
            enderecoLabel.Location = new System.Drawing.Point(68, 150);
            enderecoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(56, 13);
            enderecoLabel.TabIndex = 25;
            enderecoLabel.Text = "Endereco:";
            // 
            // matriculaLabel
            // 
            matriculaLabel.AutoSize = true;
            matriculaLabel.BackColor = System.Drawing.Color.Gold;
            matriculaLabel.Location = new System.Drawing.Point(68, 186);
            matriculaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.Size = new System.Drawing.Size(53, 13);
            matriculaLabel.TabIndex = 28;
            matriculaLabel.Text = "Matricula:";
            // 
            // metragemDireitaLabel
            // 
            metragemDireitaLabel.AutoSize = true;
            metragemDireitaLabel.BackColor = System.Drawing.Color.Gold;
            metragemDireitaLabel.Location = new System.Drawing.Point(68, 116);
            metragemDireitaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            metragemDireitaLabel.Name = "metragemDireitaLabel";
            metragemDireitaLabel.Size = new System.Drawing.Size(90, 13);
            metragemDireitaLabel.TabIndex = 29;
            metragemDireitaLabel.Text = "Metragem Direita:";
            // 
            // metragemEsquerdaLabel
            // 
            metragemEsquerdaLabel.AutoSize = true;
            metragemEsquerdaLabel.BackColor = System.Drawing.Color.Gold;
            metragemEsquerdaLabel.Location = new System.Drawing.Point(301, 82);
            metragemEsquerdaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            metragemEsquerdaLabel.Name = "metragemEsquerdaLabel";
            metragemEsquerdaLabel.Size = new System.Drawing.Size(105, 13);
            metragemEsquerdaLabel.TabIndex = 30;
            metragemEsquerdaLabel.Text = "Metragem Esquerda:";
            // 
            // metragemFrenteLabel
            // 
            metragemFrenteLabel.AutoSize = true;
            metragemFrenteLabel.BackColor = System.Drawing.Color.Gold;
            metragemFrenteLabel.Location = new System.Drawing.Point(301, 116);
            metragemFrenteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            metragemFrenteLabel.Name = "metragemFrenteLabel";
            metragemFrenteLabel.Size = new System.Drawing.Size(90, 13);
            metragemFrenteLabel.TabIndex = 31;
            metragemFrenteLabel.Text = "Metragem Frente:";
            // 
            // metragemFundoLabel
            // 
            metragemFundoLabel.AutoSize = true;
            metragemFundoLabel.BackColor = System.Drawing.Color.Gold;
            metragemFundoLabel.Location = new System.Drawing.Point(301, 150);
            metragemFundoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            metragemFundoLabel.Name = "metragemFundoLabel";
            metragemFundoLabel.Size = new System.Drawing.Size(90, 13);
            metragemFundoLabel.TabIndex = 32;
            metragemFundoLabel.Text = "Metragem Fundo:";
            // 
            // precoAVistaLabel
            // 
            precoAVistaLabel.AutoSize = true;
            precoAVistaLabel.BackColor = System.Drawing.Color.Gold;
            precoAVistaLabel.Location = new System.Drawing.Point(301, 220);
            precoAVistaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            precoAVistaLabel.Name = "precoAVistaLabel";
            precoAVistaLabel.Size = new System.Drawing.Size(71, 13);
            precoAVistaLabel.TabIndex = 33;
            precoAVistaLabel.Text = "Preco AVista:";
            // 
            // precoParceladoLabel
            // 
            precoParceladoLabel.AutoSize = true;
            precoParceladoLabel.BackColor = System.Drawing.Color.Gold;
            precoParceladoLabel.Location = new System.Drawing.Point(301, 184);
            precoParceladoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            precoParceladoLabel.Name = "precoParceladoLabel";
            precoParceladoLabel.Size = new System.Drawing.Size(89, 13);
            precoParceladoLabel.TabIndex = 34;
            precoParceladoLabel.Text = "Preco Parcelado:";
            // 
            // tamanhoTotalTerrenoLabel
            // 
            tamanhoTotalTerrenoLabel.AutoSize = true;
            tamanhoTotalTerrenoLabel.BackColor = System.Drawing.Color.Gold;
            tamanhoTotalTerrenoLabel.Location = new System.Drawing.Point(521, 80);
            tamanhoTotalTerrenoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tamanhoTotalTerrenoLabel.Name = "tamanhoTotalTerrenoLabel";
            tamanhoTotalTerrenoLabel.Size = new System.Drawing.Size(122, 13);
            tamanhoTotalTerrenoLabel.TabIndex = 37;
            tamanhoTotalTerrenoLabel.Text = "Tamanho Total Terreno:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.BackColor = System.Drawing.Color.Gold;
            nomeLabel.Location = new System.Drawing.Point(68, 84);
            nomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(89, 13);
            nomeLabel.TabIndex = 40;
            nomeLabel.Text = "Empreendimento:";
            // 
            // confrontacoesLabel
            // 
            this.confrontacoesLabel.AutoSize = true;
            this.confrontacoesLabel.BackColor = System.Drawing.Color.Gold;
            this.confrontacoesLabel.Location = new System.Drawing.Point(68, 220);
            this.confrontacoesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.confrontacoesLabel.Name = "confrontacoesLabel";
            this.confrontacoesLabel.Size = new System.Drawing.Size(48, 13);
            this.confrontacoesLabel.TabIndex = 38;
            this.confrontacoesLabel.Text = "Esquina:";
            // 
            // labelCadastoTerreno
            // 
            this.labelCadastoTerreno.BackColor = System.Drawing.Color.Gold;
            this.labelCadastoTerreno.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastoTerreno.Location = new System.Drawing.Point(214, 7);
            this.labelCadastoTerreno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCadastoTerreno.Name = "labelCadastoTerreno";
            this.labelCadastoTerreno.Size = new System.Drawing.Size(339, 58);
            this.labelCadastoTerreno.TabIndex = 11;
            this.labelCadastoTerreno.Text = "Cadastro de Terreno";
            this.labelCadastoTerreno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(562, 218);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(56, 19);
            this.buttonSalvar.TabIndex = 23;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Location = new System.Drawing.Point(623, 218);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(61, 19);
            this.buttonCancelar.TabIndex = 24;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "Endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(124, 148);
            this.enderecoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(120, 20);
            this.enderecoTextBox.TabIndex = 26;
            // 
            // terrenoBindingSource
            // 
            this.terrenoBindingSource.DataSource = typeof(Models.Terreno);
            // 
            // matriculaTextBox
            // 
            this.matriculaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "Matricula", true));
            this.matriculaTextBox.Location = new System.Drawing.Point(120, 184);
            this.matriculaTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.matriculaTextBox.Name = "matriculaTextBox";
            this.matriculaTextBox.Size = new System.Drawing.Size(123, 20);
            this.matriculaTextBox.TabIndex = 29;
            // 
            // metragemDireitaTextBox
            // 
            this.metragemDireitaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "MetragemDireita", true));
            this.metragemDireitaTextBox.Location = new System.Drawing.Point(157, 114);
            this.metragemDireitaTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metragemDireitaTextBox.Name = "metragemDireitaTextBox";
            this.metragemDireitaTextBox.Size = new System.Drawing.Size(86, 20);
            this.metragemDireitaTextBox.TabIndex = 30;
            // 
            // metragemEsquerdaTextBox
            // 
            this.metragemEsquerdaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "MetragemEsquerda", true));
            this.metragemEsquerdaTextBox.Location = new System.Drawing.Point(405, 80);
            this.metragemEsquerdaTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metragemEsquerdaTextBox.Name = "metragemEsquerdaTextBox";
            this.metragemEsquerdaTextBox.Size = new System.Drawing.Size(76, 20);
            this.metragemEsquerdaTextBox.TabIndex = 31;
            // 
            // metragemFrenteTextBox
            // 
            this.metragemFrenteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "MetragemFrente", true));
            this.metragemFrenteTextBox.Location = new System.Drawing.Point(389, 114);
            this.metragemFrenteTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metragemFrenteTextBox.Name = "metragemFrenteTextBox";
            this.metragemFrenteTextBox.Size = new System.Drawing.Size(92, 20);
            this.metragemFrenteTextBox.TabIndex = 32;
            // 
            // metragemFundoTextBox
            // 
            this.metragemFundoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "MetragemFundo", true));
            this.metragemFundoTextBox.Location = new System.Drawing.Point(389, 148);
            this.metragemFundoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metragemFundoTextBox.Name = "metragemFundoTextBox";
            this.metragemFundoTextBox.Size = new System.Drawing.Size(92, 20);
            this.metragemFundoTextBox.TabIndex = 33;
            // 
            // precoAVistaTextBox
            // 
            this.precoAVistaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "PrecoAVista", true));
            this.precoAVistaTextBox.Location = new System.Drawing.Point(371, 218);
            this.precoAVistaTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.precoAVistaTextBox.Name = "precoAVistaTextBox";
            this.precoAVistaTextBox.Size = new System.Drawing.Size(110, 20);
            this.precoAVistaTextBox.TabIndex = 34;
            // 
            // precoParceladoTextBox
            // 
            this.precoParceladoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "PrecoParcelado", true));
            this.precoParceladoTextBox.Location = new System.Drawing.Point(389, 181);
            this.precoParceladoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.precoParceladoTextBox.Name = "precoParceladoTextBox";
            this.precoParceladoTextBox.Size = new System.Drawing.Size(92, 20);
            this.precoParceladoTextBox.TabIndex = 35;
            // 
            // redeAguaCheckBox
            // 
            this.redeAguaCheckBox.AutoSize = true;
            this.redeAguaCheckBox.BackColor = System.Drawing.Color.Gold;
            this.redeAguaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.terrenoBindingSource, "RedeAgua", true));
            this.redeAguaCheckBox.Location = new System.Drawing.Point(524, 134);
            this.redeAguaCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.redeAguaCheckBox.Name = "redeAguaCheckBox";
            this.redeAguaCheckBox.Size = new System.Drawing.Size(94, 17);
            this.redeAguaCheckBox.TabIndex = 36;
            this.redeAguaCheckBox.Text = "Rede de água";
            this.redeAguaCheckBox.UseVisualStyleBackColor = false;
            // 
            // redeEnergiaCheckBox
            // 
            this.redeEnergiaCheckBox.AutoSize = true;
            this.redeEnergiaCheckBox.BackColor = System.Drawing.Color.Gold;
            this.redeEnergiaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.terrenoBindingSource, "RedeEnergia", true));
            this.redeEnergiaCheckBox.Location = new System.Drawing.Point(524, 113);
            this.redeEnergiaCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.redeEnergiaCheckBox.Name = "redeEnergiaCheckBox";
            this.redeEnergiaCheckBox.Size = new System.Drawing.Size(105, 17);
            this.redeEnergiaCheckBox.TabIndex = 37;
            this.redeEnergiaCheckBox.Text = "Rede de energia";
            this.redeEnergiaCheckBox.UseVisualStyleBackColor = false;
            // 
            // tamanhoTotalTerrenoTextBox
            // 
            this.tamanhoTotalTerrenoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "TamanhoTotalTerreno", true));
            this.tamanhoTotalTerrenoTextBox.Location = new System.Drawing.Point(640, 77);
            this.tamanhoTotalTerrenoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tamanhoTotalTerrenoTextBox.Name = "tamanhoTotalTerrenoTextBox";
            this.tamanhoTotalTerrenoTextBox.Size = new System.Drawing.Size(76, 20);
            this.tamanhoTotalTerrenoTextBox.TabIndex = 38;
            // 
            // confrontacoesTextBox
            // 
            this.confrontacoesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "Esquina", true));
            this.confrontacoesTextBox.Location = new System.Drawing.Point(116, 218);
            this.confrontacoesTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confrontacoesTextBox.Name = "confrontacoesTextBox";
            this.confrontacoesTextBox.Size = new System.Drawing.Size(127, 20);
            this.confrontacoesTextBox.TabIndex = 39;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "Empreendimento.Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(157, 80);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(76, 20);
            this.nomeTextBox.TabIndex = 41;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "pesquisa-de-lupa.png");
            // 
            // buttonBuscarEmpreendimento
            // 
            this.buttonBuscarEmpreendimento.BackColor = System.Drawing.Color.Transparent;
            this.buttonBuscarEmpreendimento.FlatAppearance.BorderSize = 0;
            this.buttonBuscarEmpreendimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarEmpreendimento.ImageKey = "pesquisa-de-lupa.png";
            this.buttonBuscarEmpreendimento.ImageList = this.imageList1;
            this.buttonBuscarEmpreendimento.Location = new System.Drawing.Point(236, 76);
            this.buttonBuscarEmpreendimento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBuscarEmpreendimento.Name = "buttonBuscarEmpreendimento";
            this.buttonBuscarEmpreendimento.Size = new System.Drawing.Size(27, 27);
            this.buttonBuscarEmpreendimento.TabIndex = 42;
            this.buttonBuscarEmpreendimento.UseVisualStyleBackColor = false;
            this.buttonBuscarEmpreendimento.Click += new System.EventHandler(this.buttonBuscarEmpreendimento_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gold;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LocacaoLaboratorio.Properties.Resources.Foto_de_fundo_2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(784, 370);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // radioButtonDisponivel
            // 
            this.radioButtonDisponivel.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonDisponivel.AutoSize = true;
            this.radioButtonDisponivel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.radioButtonDisponivel.Location = new System.Drawing.Point(524, 171);
            this.radioButtonDisponivel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonDisponivel.Name = "radioButtonDisponivel";
            this.radioButtonDisponivel.Size = new System.Drawing.Size(68, 23);
            this.radioButtonDisponivel.TabIndex = 47;
            this.radioButtonDisponivel.Text = "&Disponível";
            this.radioButtonDisponivel.UseVisualStyleBackColor = true;
            this.radioButtonDisponivel.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonReservado
            // 
            this.radioButtonReservado.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonReservado.AutoSize = true;
            this.radioButtonReservado.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.radioButtonReservado.Location = new System.Drawing.Point(597, 171);
            this.radioButtonReservado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonReservado.Name = "radioButtonReservado";
            this.radioButtonReservado.Size = new System.Drawing.Size(69, 23);
            this.radioButtonReservado.TabIndex = 47;
            this.radioButtonReservado.TabStop = true;
            this.radioButtonReservado.Text = "&Reservado";
            this.radioButtonReservado.UseVisualStyleBackColor = true;
            this.radioButtonReservado.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonVendido
            // 
            this.radioButtonVendido.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonVendido.AutoSize = true;
            this.radioButtonVendido.Location = new System.Drawing.Point(674, 171);
            this.radioButtonVendido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonVendido.Name = "radioButtonVendido";
            this.radioButtonVendido.Size = new System.Drawing.Size(56, 23);
            this.radioButtonVendido.TabIndex = 47;
            this.radioButtonVendido.Text = "&Vendido";
            this.radioButtonVendido.UseVisualStyleBackColor = true;
            this.radioButtonVendido.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // FormCadastroTerreno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 370);
            this.Controls.Add(this.radioButtonVendido);
            this.Controls.Add(this.radioButtonReservado);
            this.Controls.Add(this.radioButtonDisponivel);
            this.Controls.Add(this.buttonBuscarEmpreendimento);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.confrontacoesLabel);
            this.Controls.Add(this.confrontacoesTextBox);
            this.Controls.Add(tamanhoTotalTerrenoLabel);
            this.Controls.Add(this.tamanhoTotalTerrenoTextBox);
            this.Controls.Add(this.redeEnergiaCheckBox);
            this.Controls.Add(this.redeAguaCheckBox);
            this.Controls.Add(precoParceladoLabel);
            this.Controls.Add(this.precoParceladoTextBox);
            this.Controls.Add(precoAVistaLabel);
            this.Controls.Add(this.precoAVistaTextBox);
            this.Controls.Add(metragemFundoLabel);
            this.Controls.Add(this.metragemFundoTextBox);
            this.Controls.Add(metragemFrenteLabel);
            this.Controls.Add(this.metragemFrenteTextBox);
            this.Controls.Add(metragemEsquerdaLabel);
            this.Controls.Add(this.metragemEsquerdaTextBox);
            this.Controls.Add(metragemDireitaLabel);
            this.Controls.Add(this.metragemDireitaTextBox);
            this.Controls.Add(matriculaLabel);
            this.Controls.Add(this.matriculaTextBox);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.labelCadastoTerreno);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroTerreno";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Terreno";
            this.Load += new System.EventHandler(this.FormCadastroTerreno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.terrenoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCadastoTerreno;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.BindingSource terrenoBindingSource;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox matriculaTextBox;
        private System.Windows.Forms.TextBox metragemDireitaTextBox;
        private System.Windows.Forms.TextBox metragemEsquerdaTextBox;
        private System.Windows.Forms.TextBox metragemFrenteTextBox;
        private System.Windows.Forms.TextBox metragemFundoTextBox;
        private System.Windows.Forms.TextBox precoAVistaTextBox;
        private System.Windows.Forms.TextBox precoParceladoTextBox;
        private System.Windows.Forms.CheckBox redeAguaCheckBox;
        private System.Windows.Forms.CheckBox redeEnergiaCheckBox;
        private System.Windows.Forms.TextBox tamanhoTotalTerrenoTextBox;
        private System.Windows.Forms.TextBox confrontacoesTextBox;
        private System.Windows.Forms.Label confrontacoesLabel;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonBuscarEmpreendimento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButtonDisponivel;
        private System.Windows.Forms.RadioButton radioButtonReservado;
        private System.Windows.Forms.RadioButton radioButtonVendido;
    }
}