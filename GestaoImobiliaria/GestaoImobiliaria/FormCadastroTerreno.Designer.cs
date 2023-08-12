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
            System.Windows.Forms.Label matriculaLabel;
            System.Windows.Forms.Label metragemFrenteLabel;
            System.Windows.Forms.Label metragemFundoLabel;
            System.Windows.Forms.Label metragemLateraisLabel;
            System.Windows.Forms.Label precoAVistaLabel;
            System.Windows.Forms.Label precoParceladoLabel;
            System.Windows.Forms.Label redeAguaEnergiaLabel;
            System.Windows.Forms.Label tamanhoTotalLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label confrontacoesTerrenoLabel;
            this.labelCadastoTerreno = new System.Windows.Forms.Label();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.matriculaTextBox = new System.Windows.Forms.TextBox();
            this.metragemFrenteTextBox = new System.Windows.Forms.TextBox();
            this.metragemFundoTextBox = new System.Windows.Forms.TextBox();
            this.metragemLateraisTextBox = new System.Windows.Forms.TextBox();
            this.precoAVistaTextBox = new System.Windows.Forms.TextBox();
            this.precoParceladoTextBox = new System.Windows.Forms.TextBox();
            this.redeAguaEnergiaCheckBox = new System.Windows.Forms.CheckBox();
            this.tamanhoTotalTextBox = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.terrenoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.confrontacoesTerrenoTextBox = new System.Windows.Forms.TextBox();
            matriculaLabel = new System.Windows.Forms.Label();
            metragemFrenteLabel = new System.Windows.Forms.Label();
            metragemFundoLabel = new System.Windows.Forms.Label();
            metragemLateraisLabel = new System.Windows.Forms.Label();
            precoAVistaLabel = new System.Windows.Forms.Label();
            precoParceladoLabel = new System.Windows.Forms.Label();
            redeAguaEnergiaLabel = new System.Windows.Forms.Label();
            tamanhoTotalLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            confrontacoesTerrenoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.terrenoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // matriculaLabel
            // 
            matriculaLabel.AutoSize = true;
            matriculaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            matriculaLabel.Location = new System.Drawing.Point(66, 126);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.Size = new System.Drawing.Size(90, 24);
            matriculaLabel.TabIndex = 14;
            matriculaLabel.Text = "Matricula:";
            // 
            // metragemFrenteLabel
            // 
            metragemFrenteLabel.AutoSize = true;
            metragemFrenteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            metragemFrenteLabel.Location = new System.Drawing.Point(452, 163);
            metragemFrenteLabel.Name = "metragemFrenteLabel";
            metragemFrenteLabel.Size = new System.Drawing.Size(160, 24);
            metragemFrenteLabel.TabIndex = 15;
            metragemFrenteLabel.Text = "Metragem Frente:";
            // 
            // metragemFundoLabel
            // 
            metragemFundoLabel.AutoSize = true;
            metragemFundoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            metragemFundoLabel.Location = new System.Drawing.Point(451, 208);
            metragemFundoLabel.Name = "metragemFundoLabel";
            metragemFundoLabel.Size = new System.Drawing.Size(161, 24);
            metragemFundoLabel.TabIndex = 16;
            metragemFundoLabel.Text = "Metragem Fundo:";
            // 
            // metragemLateraisLabel
            // 
            metragemLateraisLabel.AutoSize = true;
            metragemLateraisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            metragemLateraisLabel.Location = new System.Drawing.Point(452, 124);
            metragemLateraisLabel.Name = "metragemLateraisLabel";
            metragemLateraisLabel.Size = new System.Drawing.Size(169, 24);
            metragemLateraisLabel.TabIndex = 17;
            metragemLateraisLabel.Text = "Metragem Laterais:";
            // 
            // precoAVistaLabel
            // 
            precoAVistaLabel.AutoSize = true;
            precoAVistaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precoAVistaLabel.Location = new System.Drawing.Point(66, 250);
            precoAVistaLabel.Name = "precoAVistaLabel";
            precoAVistaLabel.Size = new System.Drawing.Size(125, 24);
            precoAVistaLabel.TabIndex = 18;
            precoAVistaLabel.Text = "Preco a Vista:";
            // 
            // precoParceladoLabel
            // 
            precoParceladoLabel.AutoSize = true;
            precoParceladoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precoParceladoLabel.Location = new System.Drawing.Point(66, 294);
            precoParceladoLabel.Name = "precoParceladoLabel";
            precoParceladoLabel.Size = new System.Drawing.Size(155, 24);
            precoParceladoLabel.TabIndex = 19;
            precoParceladoLabel.Text = "Preco Parcelado:";
            // 
            // redeAguaEnergiaLabel
            // 
            redeAguaEnergiaLabel.AutoSize = true;
            redeAguaEnergiaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            redeAguaEnergiaLabel.Location = new System.Drawing.Point(451, 294);
            redeAguaEnergiaLabel.Name = "redeAguaEnergiaLabel";
            redeAguaEnergiaLabel.Size = new System.Drawing.Size(182, 24);
            redeAguaEnergiaLabel.TabIndex = 20;
            redeAguaEnergiaLabel.Text = "Rede Agua Energia:";
            // 
            // tamanhoTotalLabel
            // 
            tamanhoTotalLabel.AutoSize = true;
            tamanhoTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tamanhoTotalLabel.Location = new System.Drawing.Point(451, 250);
            tamanhoTotalLabel.Name = "tamanhoTotalLabel";
            tamanhoTotalLabel.Size = new System.Drawing.Size(142, 24);
            tamanhoTotalLabel.TabIndex = 21;
            tamanhoTotalLabel.Text = "Tamanho Total:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            enderecoLabel.Location = new System.Drawing.Point(66, 163);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(99, 24);
            enderecoLabel.TabIndex = 12;
            enderecoLabel.Text = "Endereco:";
            // 
            // labelCadastoTerreno
            // 
            this.labelCadastoTerreno.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCadastoTerreno.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastoTerreno.Location = new System.Drawing.Point(0, 0);
            this.labelCadastoTerreno.Name = "labelCadastoTerreno";
            this.labelCadastoTerreno.Size = new System.Drawing.Size(800, 71);
            this.labelCadastoTerreno.TabIndex = 11;
            this.labelCadastoTerreno.Text = "Cadastro de Terreno";
            this.labelCadastoTerreno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "Endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(171, 165);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(216, 22);
            this.enderecoTextBox.TabIndex = 13;
            // 
            // matriculaTextBox
            // 
            this.matriculaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "Matricula", true));
            this.matriculaTextBox.Location = new System.Drawing.Point(162, 126);
            this.matriculaTextBox.Name = "matriculaTextBox";
            this.matriculaTextBox.Size = new System.Drawing.Size(225, 22);
            this.matriculaTextBox.TabIndex = 15;
            // 
            // metragemFrenteTextBox
            // 
            this.metragemFrenteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "MetragemFrente", true));
            this.metragemFrenteTextBox.Location = new System.Drawing.Point(627, 165);
            this.metragemFrenteTextBox.Name = "metragemFrenteTextBox";
            this.metragemFrenteTextBox.Size = new System.Drawing.Size(100, 22);
            this.metragemFrenteTextBox.TabIndex = 16;
            // 
            // metragemFundoTextBox
            // 
            this.metragemFundoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "MetragemFundo", true));
            this.metragemFundoTextBox.Location = new System.Drawing.Point(618, 210);
            this.metragemFundoTextBox.Name = "metragemFundoTextBox";
            this.metragemFundoTextBox.Size = new System.Drawing.Size(109, 22);
            this.metragemFundoTextBox.TabIndex = 17;
            // 
            // metragemLateraisTextBox
            // 
            this.metragemLateraisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "MetragemLaterais", true));
            this.metragemLateraisTextBox.Location = new System.Drawing.Point(627, 128);
            this.metragemLateraisTextBox.Name = "metragemLateraisTextBox";
            this.metragemLateraisTextBox.Size = new System.Drawing.Size(100, 22);
            this.metragemLateraisTextBox.TabIndex = 18;
            // 
            // precoAVistaTextBox
            // 
            this.precoAVistaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "PrecoAVista", true));
            this.precoAVistaTextBox.Location = new System.Drawing.Point(197, 252);
            this.precoAVistaTextBox.Name = "precoAVistaTextBox";
            this.precoAVistaTextBox.Size = new System.Drawing.Size(190, 22);
            this.precoAVistaTextBox.TabIndex = 19;
            // 
            // precoParceladoTextBox
            // 
            this.precoParceladoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "PrecoParcelado", true));
            this.precoParceladoTextBox.Location = new System.Drawing.Point(228, 296);
            this.precoParceladoTextBox.Name = "precoParceladoTextBox";
            this.precoParceladoTextBox.Size = new System.Drawing.Size(159, 22);
            this.precoParceladoTextBox.TabIndex = 20;
            // 
            // redeAguaEnergiaCheckBox
            // 
            this.redeAguaEnergiaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.terrenoBindingSource, "RedeAguaEnergia", true));
            this.redeAguaEnergiaCheckBox.Location = new System.Drawing.Point(639, 296);
            this.redeAguaEnergiaCheckBox.Name = "redeAguaEnergiaCheckBox";
            this.redeAguaEnergiaCheckBox.Size = new System.Drawing.Size(18, 24);
            this.redeAguaEnergiaCheckBox.TabIndex = 21;
            this.redeAguaEnergiaCheckBox.UseVisualStyleBackColor = true;
            // 
            // tamanhoTotalTextBox
            // 
            this.tamanhoTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "TamanhoTotal", true));
            this.tamanhoTotalTextBox.Location = new System.Drawing.Point(600, 252);
            this.tamanhoTotalTextBox.Name = "tamanhoTotalTextBox";
            this.tamanhoTotalTextBox.Size = new System.Drawing.Size(127, 22);
            this.tamanhoTotalTextBox.TabIndex = 22;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(571, 384);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 23;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(652, 384);
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
            // confrontacoesTerrenoLabel
            // 
            confrontacoesTerrenoLabel.AutoSize = true;
            confrontacoesTerrenoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            confrontacoesTerrenoLabel.Location = new System.Drawing.Point(67, 210);
            confrontacoesTerrenoLabel.Name = "confrontacoesTerrenoLabel";
            confrontacoesTerrenoLabel.Size = new System.Drawing.Size(210, 24);
            confrontacoesTerrenoLabel.TabIndex = 24;
            confrontacoesTerrenoLabel.Text = "Confrontacoes Terreno:";
            // 
            // confrontacoesTerrenoTextBox
            // 
            this.confrontacoesTerrenoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terrenoBindingSource, "ConfrontacoesTerreno", true));
            this.confrontacoesTerrenoTextBox.Location = new System.Drawing.Point(287, 210);
            this.confrontacoesTerrenoTextBox.Name = "confrontacoesTerrenoTextBox";
            this.confrontacoesTerrenoTextBox.Size = new System.Drawing.Size(100, 22);
            this.confrontacoesTerrenoTextBox.TabIndex = 25;
            // 
            // FormCadastroTerreno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(confrontacoesTerrenoLabel);
            this.Controls.Add(this.confrontacoesTerrenoTextBox);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(tamanhoTotalLabel);
            this.Controls.Add(this.tamanhoTotalTextBox);
            this.Controls.Add(redeAguaEnergiaLabel);
            this.Controls.Add(this.redeAguaEnergiaCheckBox);
            this.Controls.Add(precoParceladoLabel);
            this.Controls.Add(this.precoParceladoTextBox);
            this.Controls.Add(precoAVistaLabel);
            this.Controls.Add(this.precoAVistaTextBox);
            this.Controls.Add(metragemLateraisLabel);
            this.Controls.Add(this.metragemLateraisTextBox);
            this.Controls.Add(metragemFundoLabel);
            this.Controls.Add(this.metragemFundoTextBox);
            this.Controls.Add(metragemFrenteLabel);
            this.Controls.Add(this.metragemFrenteTextBox);
            this.Controls.Add(matriculaLabel);
            this.Controls.Add(this.matriculaTextBox);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(this.labelCadastoTerreno);
            this.Name = "FormCadastroTerreno";
            this.Text = "Cadastro de Terreno";
            ((System.ComponentModel.ISupportInitialize)(this.terrenoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCadastoTerreno;
        private System.Windows.Forms.BindingSource terrenoBindingSource;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox matriculaTextBox;
        private System.Windows.Forms.TextBox metragemFrenteTextBox;
        private System.Windows.Forms.TextBox metragemFundoTextBox;
        private System.Windows.Forms.TextBox metragemLateraisTextBox;
        private System.Windows.Forms.TextBox precoAVistaTextBox;
        private System.Windows.Forms.TextBox precoParceladoTextBox;
        private System.Windows.Forms.CheckBox redeAguaEnergiaCheckBox;
        private System.Windows.Forms.TextBox tamanhoTotalTextBox;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox confrontacoesTerrenoTextBox;
    }
}