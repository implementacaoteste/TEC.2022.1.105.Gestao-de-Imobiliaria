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
            System.Windows.Forms.Label idEmpreendimentoLabel;
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
            System.Windows.Forms.Label esquinaLabel;
            this.labelCadastoTerreno = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.terrenoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.idEmpreendimentoTextBox = new System.Windows.Forms.TextBox();
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
            this.esquinaTextBox = new System.Windows.Forms.TextBox();
            enderecoLabel = new System.Windows.Forms.Label();
            idEmpreendimentoLabel = new System.Windows.Forms.Label();
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
            esquinaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.terrenoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(30, 109);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(69, 16);
            enderecoLabel.TabIndex = 25;
            enderecoLabel.Text = "Endereco:";
            // 
            // idEmpreendimentoLabel
            // 
            idEmpreendimentoLabel.AutoSize = true;
            idEmpreendimentoLabel.Location = new System.Drawing.Point(33, 146);
            idEmpreendimentoLabel.Name = "idEmpreendimentoLabel";
            idEmpreendimentoLabel.Size = new System.Drawing.Size(127, 16);
            idEmpreendimentoLabel.TabIndex = 26;
            idEmpreendimentoLabel.Text = "Id Empreendimento:";
            // 
            // matriculaLabel
            // 
            matriculaLabel.AutoSize = true;
            matriculaLabel.Location = new System.Drawing.Point(37, 230);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.Size = new System.Drawing.Size(64, 16);
            matriculaLabel.TabIndex = 28;
            matriculaLabel.Text = "Matricula:";
            // 
            // metragemDireitaLabel
            // 
            metragemDireitaLabel.AutoSize = true;
            metragemDireitaLabel.Location = new System.Drawing.Point(32, 278);
            metragemDireitaLabel.Name = "metragemDireitaLabel";
            metragemDireitaLabel.Size = new System.Drawing.Size(113, 16);
            metragemDireitaLabel.TabIndex = 29;
            metragemDireitaLabel.Text = "Metragem Direita:";
            // 
            // metragemEsquerdaLabel
            // 
            metragemEsquerdaLabel.AutoSize = true;
            metragemEsquerdaLabel.Location = new System.Drawing.Point(343, 84);
            metragemEsquerdaLabel.Name = "metragemEsquerdaLabel";
            metragemEsquerdaLabel.Size = new System.Drawing.Size(133, 16);
            metragemEsquerdaLabel.TabIndex = 30;
            metragemEsquerdaLabel.Text = "Metragem Esquerda:";
            // 
            // metragemFrenteLabel
            // 
            metragemFrenteLabel.AutoSize = true;
            metragemFrenteLabel.Location = new System.Drawing.Point(342, 129);
            metragemFrenteLabel.Name = "metragemFrenteLabel";
            metragemFrenteLabel.Size = new System.Drawing.Size(112, 16);
            metragemFrenteLabel.TabIndex = 31;
            metragemFrenteLabel.Text = "Metragem Frente:";
            // 
            // metragemFundoLabel
            // 
            metragemFundoLabel.AutoSize = true;
            metragemFundoLabel.Location = new System.Drawing.Point(339, 175);
            metragemFundoLabel.Name = "metragemFundoLabel";
            metragemFundoLabel.Size = new System.Drawing.Size(112, 16);
            metragemFundoLabel.TabIndex = 32;
            metragemFundoLabel.Text = "Metragem Fundo:";
            // 
            // precoAVistaLabel
            // 
            precoAVistaLabel.AutoSize = true;
            precoAVistaLabel.Location = new System.Drawing.Point(335, 227);
            precoAVistaLabel.Name = "precoAVistaLabel";
            precoAVistaLabel.Size = new System.Drawing.Size(88, 16);
            precoAVistaLabel.TabIndex = 33;
            precoAVistaLabel.Text = "Preco AVista:";
            // 
            // precoParceladoLabel
            // 
            precoParceladoLabel.AutoSize = true;
            precoParceladoLabel.Location = new System.Drawing.Point(342, 272);
            precoParceladoLabel.Name = "precoParceladoLabel";
            precoParceladoLabel.Size = new System.Drawing.Size(112, 16);
            precoParceladoLabel.TabIndex = 34;
            precoParceladoLabel.Text = "Preco Parcelado:";
            // 
            // redeAguaLabel
            // 
            redeAguaLabel.AutoSize = true;
            redeAguaLabel.Location = new System.Drawing.Point(631, 89);
            redeAguaLabel.Name = "redeAguaLabel";
            redeAguaLabel.Size = new System.Drawing.Size(79, 16);
            redeAguaLabel.TabIndex = 35;
            redeAguaLabel.Text = "Rede Agua:";
            // 
            // redeEnergiaLabel
            // 
            redeEnergiaLabel.AutoSize = true;
            redeEnergiaLabel.Location = new System.Drawing.Point(637, 135);
            redeEnergiaLabel.Name = "redeEnergiaLabel";
            redeEnergiaLabel.Size = new System.Drawing.Size(94, 16);
            redeEnergiaLabel.TabIndex = 36;
            redeEnergiaLabel.Text = "Rede Energia:";
            // 
            // tamanhoTotalTerrenoLabel
            // 
            tamanhoTotalTerrenoLabel.AutoSize = true;
            tamanhoTotalTerrenoLabel.Location = new System.Drawing.Point(646, 174);
            tamanhoTotalTerrenoLabel.Name = "tamanhoTotalTerrenoLabel";
            tamanhoTotalTerrenoLabel.Size = new System.Drawing.Size(153, 16);
            tamanhoTotalTerrenoLabel.TabIndex = 37;
            tamanhoTotalTerrenoLabel.Text = "Tamanho Total Terreno:";
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
            this.buttonSalvar.Location = new System.Drawing.Point(813, 295);
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
            this.buttonCancelar.Location = new System.Drawing.Point(894, 295);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 24;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // terrenoBindingSource
            // 
            this.terrenoBindingSource.DataSource = typeof(Models.Terreno);
            // 
            // confrontacoesTerrenoTextBox
            // 
            this.confrontacoesTerrenoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "Esquina", true));
            this.confrontacoesTerrenoTextBox.Location = new System.Drawing.Point(182, 72);
            this.confrontacoesTerrenoTextBox.Name = "confrontacoesTerrenoTextBox";
            this.confrontacoesTerrenoTextBox.Size = new System.Drawing.Size(100, 22);
            this.confrontacoesTerrenoTextBox.TabIndex = 25;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "Endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(105, 106);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(100, 22);
            this.enderecoTextBox.TabIndex = 26;
            // 
            // idEmpreendimentoTextBox
            // 
            this.idEmpreendimentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "IdEmpreendimento", true));
            this.idEmpreendimentoTextBox.Location = new System.Drawing.Point(166, 143);
            this.idEmpreendimentoTextBox.Name = "idEmpreendimentoTextBox";
            this.idEmpreendimentoTextBox.Size = new System.Drawing.Size(100, 22);
            this.idEmpreendimentoTextBox.TabIndex = 27;
            // 
            // matriculaTextBox
            // 
            this.matriculaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "Matricula", true));
            this.matriculaTextBox.Location = new System.Drawing.Point(107, 227);
            this.matriculaTextBox.Name = "matriculaTextBox";
            this.matriculaTextBox.Size = new System.Drawing.Size(100, 22);
            this.matriculaTextBox.TabIndex = 29;
            // 
            // metragemDireitaTextBox
            // 
            this.metragemDireitaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "MetragemDireita", true));
            this.metragemDireitaTextBox.Location = new System.Drawing.Point(151, 275);
            this.metragemDireitaTextBox.Name = "metragemDireitaTextBox";
            this.metragemDireitaTextBox.Size = new System.Drawing.Size(100, 22);
            this.metragemDireitaTextBox.TabIndex = 30;
            // 
            // metragemEsquerdaTextBox
            // 
            this.metragemEsquerdaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "MetragemEsquerda", true));
            this.metragemEsquerdaTextBox.Location = new System.Drawing.Point(482, 81);
            this.metragemEsquerdaTextBox.Name = "metragemEsquerdaTextBox";
            this.metragemEsquerdaTextBox.Size = new System.Drawing.Size(100, 22);
            this.metragemEsquerdaTextBox.TabIndex = 31;
            // 
            // metragemFrenteTextBox
            // 
            this.metragemFrenteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "MetragemFrente", true));
            this.metragemFrenteTextBox.Location = new System.Drawing.Point(460, 126);
            this.metragemFrenteTextBox.Name = "metragemFrenteTextBox";
            this.metragemFrenteTextBox.Size = new System.Drawing.Size(100, 22);
            this.metragemFrenteTextBox.TabIndex = 32;
            // 
            // metragemFundoTextBox
            // 
            this.metragemFundoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "MetragemFundo", true));
            this.metragemFundoTextBox.Location = new System.Drawing.Point(457, 172);
            this.metragemFundoTextBox.Name = "metragemFundoTextBox";
            this.metragemFundoTextBox.Size = new System.Drawing.Size(100, 22);
            this.metragemFundoTextBox.TabIndex = 33;
            // 
            // precoAVistaTextBox
            // 
            this.precoAVistaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "PrecoAVista", true));
            this.precoAVistaTextBox.Location = new System.Drawing.Point(429, 224);
            this.precoAVistaTextBox.Name = "precoAVistaTextBox";
            this.precoAVistaTextBox.Size = new System.Drawing.Size(100, 22);
            this.precoAVistaTextBox.TabIndex = 34;
            // 
            // precoParceladoTextBox
            // 
            this.precoParceladoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "PrecoParcelado", true));
            this.precoParceladoTextBox.Location = new System.Drawing.Point(460, 269);
            this.precoParceladoTextBox.Name = "precoParceladoTextBox";
            this.precoParceladoTextBox.Size = new System.Drawing.Size(100, 22);
            this.precoParceladoTextBox.TabIndex = 35;
            // 
            // redeAguaCheckBox
            // 
            this.redeAguaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.terrenoBindingSource, "RedeAgua", true));
            this.redeAguaCheckBox.Location = new System.Drawing.Point(716, 84);
            this.redeAguaCheckBox.Name = "redeAguaCheckBox";
            this.redeAguaCheckBox.Size = new System.Drawing.Size(104, 24);
            this.redeAguaCheckBox.TabIndex = 36;
            this.redeAguaCheckBox.Text = "checkBox1";
            this.redeAguaCheckBox.UseVisualStyleBackColor = true;
            // 
            // redeEnergiaCheckBox
            // 
            this.redeEnergiaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.terrenoBindingSource, "RedeEnergia", true));
            this.redeEnergiaCheckBox.Location = new System.Drawing.Point(737, 130);
            this.redeEnergiaCheckBox.Name = "redeEnergiaCheckBox";
            this.redeEnergiaCheckBox.Size = new System.Drawing.Size(104, 24);
            this.redeEnergiaCheckBox.TabIndex = 37;
            this.redeEnergiaCheckBox.Text = "checkBox1";
            this.redeEnergiaCheckBox.UseVisualStyleBackColor = true;
            // 
            // tamanhoTotalTerrenoTextBox
            // 
            this.tamanhoTotalTerrenoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "TamanhoTotalTerreno", true));
            this.tamanhoTotalTerrenoTextBox.Location = new System.Drawing.Point(805, 171);
            this.tamanhoTotalTerrenoTextBox.Name = "tamanhoTotalTerrenoTextBox";
            this.tamanhoTotalTerrenoTextBox.Size = new System.Drawing.Size(100, 22);
            this.tamanhoTotalTerrenoTextBox.TabIndex = 38;
            // 
            // esquinaLabel
            // 
            esquinaLabel.AutoSize = true;
            esquinaLabel.Location = new System.Drawing.Point(66, 188);
            esquinaLabel.Name = "esquinaLabel";
            esquinaLabel.Size = new System.Drawing.Size(59, 16);
            esquinaLabel.TabIndex = 38;
            esquinaLabel.Text = "Esquina:";
            // 
            // esquinaTextBox
            // 
            this.esquinaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "Esquina", true));
            this.esquinaTextBox.Location = new System.Drawing.Point(131, 185);
            this.esquinaTextBox.Name = "esquinaTextBox";
            this.esquinaTextBox.Size = new System.Drawing.Size(100, 22);
            this.esquinaTextBox.TabIndex = 39;
            // 
            // FormCadastroTerreno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 345);
            this.Controls.Add(esquinaLabel);
            this.Controls.Add(this.esquinaTextBox);
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
            this.Controls.Add(idEmpreendimentoLabel);
            this.Controls.Add(this.idEmpreendimentoTextBox);
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
        private System.Windows.Forms.TextBox idEmpreendimentoTextBox;
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
        private System.Windows.Forms.TextBox esquinaTextBox;
    }
}