namespace LocacaoLaboratorio
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
            System.Windows.Forms.Label redeAguaLabel;
            System.Windows.Forms.Label redeEnergiaLabel;
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
            enderecoLabel = new System.Windows.Forms.Label();
            matriculaLabel = new System.Windows.Forms.Label();
            metragemDireitaLabel = new System.Windows.Forms.Label();
            metragemEsquerdaLabel = new System.Windows.Forms.Label();
            metragemFrenteLabel = new System.Windows.Forms.Label();
            metragemFundoLabel = new System.Windows.Forms.Label();
            precoAVistaLabel = new System.Windows.Forms.Label();
            precoParceladoLabel = new System.Windows.Forms.Label();
            redeAguaLabel = new System.Windows.Forms.Label();
            redeEnergiaLabel = new System.Windows.Forms.Label();
            tamanhoTotalTerrenoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.terrenoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(90, 185);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(69, 16);
            enderecoLabel.TabIndex = 25;
            enderecoLabel.Text = "Endereco:";
            // 
            // matriculaLabel
            // 
            matriculaLabel.AutoSize = true;
            matriculaLabel.Location = new System.Drawing.Point(90, 229);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.Size = new System.Drawing.Size(64, 16);
            matriculaLabel.TabIndex = 28;
            matriculaLabel.Text = "Matricula:";
            // 
            // metragemDireitaLabel
            // 
            metragemDireitaLabel.AutoSize = true;
            metragemDireitaLabel.Location = new System.Drawing.Point(90, 143);
            metragemDireitaLabel.Name = "metragemDireitaLabel";
            metragemDireitaLabel.Size = new System.Drawing.Size(113, 16);
            metragemDireitaLabel.TabIndex = 29;
            metragemDireitaLabel.Text = "Metragem Direita:";
            // 
            // metragemEsquerdaLabel
            // 
            metragemEsquerdaLabel.AutoSize = true;
            metragemEsquerdaLabel.Location = new System.Drawing.Point(401, 101);
            metragemEsquerdaLabel.Name = "metragemEsquerdaLabel";
            metragemEsquerdaLabel.Size = new System.Drawing.Size(133, 16);
            metragemEsquerdaLabel.TabIndex = 30;
            metragemEsquerdaLabel.Text = "Metragem Esquerda:";
            // 
            // metragemFrenteLabel
            // 
            metragemFrenteLabel.AutoSize = true;
            metragemFrenteLabel.Location = new System.Drawing.Point(401, 143);
            metragemFrenteLabel.Name = "metragemFrenteLabel";
            metragemFrenteLabel.Size = new System.Drawing.Size(112, 16);
            metragemFrenteLabel.TabIndex = 31;
            metragemFrenteLabel.Text = "Metragem Frente:";
            // 
            // metragemFundoLabel
            // 
            metragemFundoLabel.AutoSize = true;
            metragemFundoLabel.Location = new System.Drawing.Point(401, 185);
            metragemFundoLabel.Name = "metragemFundoLabel";
            metragemFundoLabel.Size = new System.Drawing.Size(112, 16);
            metragemFundoLabel.TabIndex = 32;
            metragemFundoLabel.Text = "Metragem Fundo:";
            // 
            // precoAVistaLabel
            // 
            precoAVistaLabel.AutoSize = true;
            precoAVistaLabel.Location = new System.Drawing.Point(401, 271);
            precoAVistaLabel.Name = "precoAVistaLabel";
            precoAVistaLabel.Size = new System.Drawing.Size(88, 16);
            precoAVistaLabel.TabIndex = 33;
            precoAVistaLabel.Text = "Preco AVista:";
            // 
            // precoParceladoLabel
            // 
            precoParceladoLabel.AutoSize = true;
            precoParceladoLabel.Location = new System.Drawing.Point(401, 226);
            precoParceladoLabel.Name = "precoParceladoLabel";
            precoParceladoLabel.Size = new System.Drawing.Size(112, 16);
            precoParceladoLabel.TabIndex = 34;
            precoParceladoLabel.Text = "Preco Parcelado:";
            // 
            // redeAguaLabel
            // 
            redeAguaLabel.AutoSize = true;
            redeAguaLabel.Location = new System.Drawing.Point(781, 188);
            redeAguaLabel.Name = "redeAguaLabel";
            redeAguaLabel.Size = new System.Drawing.Size(79, 16);
            redeAguaLabel.TabIndex = 35;
            redeAguaLabel.Text = "Rede Agua:";
            // 
            // redeEnergiaLabel
            // 
            redeEnergiaLabel.AutoSize = true;
            redeEnergiaLabel.Location = new System.Drawing.Point(766, 146);
            redeEnergiaLabel.Name = "redeEnergiaLabel";
            redeEnergiaLabel.Size = new System.Drawing.Size(94, 16);
            redeEnergiaLabel.TabIndex = 36;
            redeEnergiaLabel.Text = "Rede Energia:";
            // 
            // tamanhoTotalTerrenoLabel
            // 
            tamanhoTotalTerrenoLabel.AutoSize = true;
            tamanhoTotalTerrenoLabel.Location = new System.Drawing.Point(695, 98);
            tamanhoTotalTerrenoLabel.Name = "tamanhoTotalTerrenoLabel";
            tamanhoTotalTerrenoLabel.Size = new System.Drawing.Size(153, 16);
            tamanhoTotalTerrenoLabel.TabIndex = 37;
            tamanhoTotalTerrenoLabel.Text = "Tamanho Total Terreno:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(90, 104);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(113, 16);
            nomeLabel.TabIndex = 40;
            nomeLabel.Text = "Empreendimento:";
            // 
            // confrontacoesLabel
            // 
            this.confrontacoesLabel.AutoSize = true;
            this.confrontacoesLabel.Location = new System.Drawing.Point(90, 271);
            this.confrontacoesLabel.Name = "confrontacoesLabel";
            this.confrontacoesLabel.Size = new System.Drawing.Size(59, 16);
            this.confrontacoesLabel.TabIndex = 38;
            this.confrontacoesLabel.Text = "Esquina:";
            // 
            // labelCadastoTerreno
            // 
            this.labelCadastoTerreno.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCadastoTerreno.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastoTerreno.Location = new System.Drawing.Point(0, 0);
            this.labelCadastoTerreno.Name = "labelCadastoTerreno";
            this.labelCadastoTerreno.Size = new System.Drawing.Size(1046, 71);
            this.labelCadastoTerreno.TabIndex = 11;
            this.labelCadastoTerreno.Text = "Cadastro de Terreno";
            this.labelCadastoTerreno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(757, 248);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 23;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Location = new System.Drawing.Point(838, 248);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 24;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "Endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(165, 182);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(158, 22);
            this.enderecoTextBox.TabIndex = 26;
            // 
            // terrenoBindingSource
            // 
            this.terrenoBindingSource.DataSource = typeof(Models.Terreno);
            // 
            // matriculaTextBox
            // 
            this.matriculaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "Matricula", true));
            this.matriculaTextBox.Location = new System.Drawing.Point(160, 226);
            this.matriculaTextBox.Name = "matriculaTextBox";
            this.matriculaTextBox.Size = new System.Drawing.Size(163, 22);
            this.matriculaTextBox.TabIndex = 29;
            // 
            // metragemDireitaTextBox
            // 
            this.metragemDireitaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "MetragemDireita", true));
            this.metragemDireitaTextBox.Location = new System.Drawing.Point(209, 140);
            this.metragemDireitaTextBox.Name = "metragemDireitaTextBox";
            this.metragemDireitaTextBox.Size = new System.Drawing.Size(114, 22);
            this.metragemDireitaTextBox.TabIndex = 30;
            // 
            // metragemEsquerdaTextBox
            // 
            this.metragemEsquerdaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "MetragemEsquerda", true));
            this.metragemEsquerdaTextBox.Location = new System.Drawing.Point(540, 98);
            this.metragemEsquerdaTextBox.Name = "metragemEsquerdaTextBox";
            this.metragemEsquerdaTextBox.Size = new System.Drawing.Size(100, 22);
            this.metragemEsquerdaTextBox.TabIndex = 31;
            // 
            // metragemFrenteTextBox
            // 
            this.metragemFrenteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "MetragemFrente", true));
            this.metragemFrenteTextBox.Location = new System.Drawing.Point(519, 140);
            this.metragemFrenteTextBox.Name = "metragemFrenteTextBox";
            this.metragemFrenteTextBox.Size = new System.Drawing.Size(121, 22);
            this.metragemFrenteTextBox.TabIndex = 32;
            // 
            // metragemFundoTextBox
            // 
            this.metragemFundoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "MetragemFundo", true));
            this.metragemFundoTextBox.Location = new System.Drawing.Point(519, 182);
            this.metragemFundoTextBox.Name = "metragemFundoTextBox";
            this.metragemFundoTextBox.Size = new System.Drawing.Size(121, 22);
            this.metragemFundoTextBox.TabIndex = 33;
            // 
            // precoAVistaTextBox
            // 
            this.precoAVistaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "PrecoAVista", true));
            this.precoAVistaTextBox.Location = new System.Drawing.Point(495, 268);
            this.precoAVistaTextBox.Name = "precoAVistaTextBox";
            this.precoAVistaTextBox.Size = new System.Drawing.Size(145, 22);
            this.precoAVistaTextBox.TabIndex = 34;
            // 
            // precoParceladoTextBox
            // 
            this.precoParceladoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "PrecoParcelado", true));
            this.precoParceladoTextBox.Location = new System.Drawing.Point(519, 223);
            this.precoParceladoTextBox.Name = "precoParceladoTextBox";
            this.precoParceladoTextBox.Size = new System.Drawing.Size(121, 22);
            this.precoParceladoTextBox.TabIndex = 35;
            // 
            // redeAguaCheckBox
            // 
            this.redeAguaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.terrenoBindingSource, "RedeAgua", true));
            this.redeAguaCheckBox.Location = new System.Drawing.Point(866, 183);
            this.redeAguaCheckBox.Name = "redeAguaCheckBox";
            this.redeAguaCheckBox.Size = new System.Drawing.Size(96, 24);
            this.redeAguaCheckBox.TabIndex = 36;
            this.redeAguaCheckBox.UseVisualStyleBackColor = true;
            // 
            // redeEnergiaCheckBox
            // 
            this.redeEnergiaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.terrenoBindingSource, "RedeEnergia", true));
            this.redeEnergiaCheckBox.Location = new System.Drawing.Point(866, 141);
            this.redeEnergiaCheckBox.Name = "redeEnergiaCheckBox";
            this.redeEnergiaCheckBox.Size = new System.Drawing.Size(20, 24);
            this.redeEnergiaCheckBox.TabIndex = 37;
            this.redeEnergiaCheckBox.UseVisualStyleBackColor = true;
            // 
            // tamanhoTotalTerrenoTextBox
            // 
            this.tamanhoTotalTerrenoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "TamanhoTotalTerreno", true));
            this.tamanhoTotalTerrenoTextBox.Location = new System.Drawing.Point(854, 95);
            this.tamanhoTotalTerrenoTextBox.Name = "tamanhoTotalTerrenoTextBox";
            this.tamanhoTotalTerrenoTextBox.Size = new System.Drawing.Size(100, 22);
            this.tamanhoTotalTerrenoTextBox.TabIndex = 38;
            // 
            // confrontacoesTextBox
            // 
            this.confrontacoesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "Esquina", true));
            this.confrontacoesTextBox.Location = new System.Drawing.Point(155, 268);
            this.confrontacoesTextBox.Name = "confrontacoesTextBox";
            this.confrontacoesTextBox.Size = new System.Drawing.Size(168, 22);
            this.confrontacoesTextBox.TabIndex = 39;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "Empreendimento.Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(209, 98);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 22);
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
            this.buttonBuscarEmpreendimento.Location = new System.Drawing.Point(315, 93);
            this.buttonBuscarEmpreendimento.Name = "buttonBuscarEmpreendimento";
            this.buttonBuscarEmpreendimento.Size = new System.Drawing.Size(36, 33);
            this.buttonBuscarEmpreendimento.TabIndex = 42;
            this.buttonBuscarEmpreendimento.UseVisualStyleBackColor = false;
            this.buttonBuscarEmpreendimento.Click += new System.EventHandler(this.buttonBuscarEmpreendimento_Click_1);
            // 
            // FormCadastroTerreno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 350);
            this.Controls.Add(this.buttonBuscarEmpreendimento);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.confrontacoesLabel);
            this.Controls.Add(this.confrontacoesTextBox);
            this.Controls.Add(tamanhoTotalTerrenoLabel);
            this.Controls.Add(this.tamanhoTotalTerrenoTextBox);
            this.Controls.Add(redeEnergiaLabel);
            this.Controls.Add(this.redeEnergiaCheckBox);
            this.Controls.Add(redeAguaLabel);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCadastroTerreno";
            this.Text = "Cadastro de Terreno";
            this.Load += new System.EventHandler(this.FormCadastroTerreno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.terrenoBindingSource)).EndInit();
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
    }
}