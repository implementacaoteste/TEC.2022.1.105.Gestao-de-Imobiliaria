namespace LocacaoLaboratorio
{
    partial class FormCadastroEmpreendimento
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
            System.Windows.Forms.Label cNPJEmpresaResponsavelLabel;
            this.labelCadastroEmpreendimentos = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.empreendimentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cNPJEmpresaResponsavelTextBox = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            nomeLabel = new System.Windows.Forms.Label();
            cNPJEmpresaResponsavelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.empreendimentosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(34, 44);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(47, 16);
            nomeLabel.TabIndex = 2;
            nomeLabel.Text = "Nome:";
            // 
            // cNPJEmpresaResponsavelLabel
            // 
            cNPJEmpresaResponsavelLabel.AutoSize = true;
            cNPJEmpresaResponsavelLabel.Location = new System.Drawing.Point(34, 98);
            cNPJEmpresaResponsavelLabel.Name = "cNPJEmpresaResponsavelLabel";
            cNPJEmpresaResponsavelLabel.Size = new System.Drawing.Size(184, 16);
            cNPJEmpresaResponsavelLabel.TabIndex = 3;
            cNPJEmpresaResponsavelLabel.Text = "CNPJEmpresa Responsavel:";
            // 
            // labelCadastroEmpreendimentos
            // 
            this.labelCadastroEmpreendimentos.AutoSize = true;
            this.labelCadastroEmpreendimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastroEmpreendimentos.Location = new System.Drawing.Point(146, 9);
            this.labelCadastroEmpreendimentos.Name = "labelCadastroEmpreendimentos";
            this.labelCadastroEmpreendimentos.Size = new System.Drawing.Size(364, 25);
            this.labelCadastroEmpreendimentos.TabIndex = 0;
            this.labelCadastroEmpreendimentos.Text = "CADASTRO DE EMPREENDIMENTOS";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empreendimentosBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(37, 63);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(550, 22);
            this.nomeTextBox.TabIndex = 3;
            // 
            // empreendimentosBindingSource
            // 
            this.empreendimentosBindingSource.DataSource = typeof(Models.Empreendimentos);
            // 
            // cNPJEmpresaResponsavelTextBox
            // 
            this.cNPJEmpresaResponsavelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empreendimentosBindingSource, "CNPJEmpresaResponsavel", true));
            this.cNPJEmpresaResponsavelTextBox.Location = new System.Drawing.Point(36, 117);
            this.cNPJEmpresaResponsavelTextBox.Name = "cNPJEmpresaResponsavelTextBox";
            this.cNPJEmpresaResponsavelTextBox.Size = new System.Drawing.Size(550, 22);
            this.cNPJEmpresaResponsavelTextBox.TabIndex = 4;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(375, 250);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 9;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Location = new System.Drawing.Point(511, 250);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FormCadastroEmpreendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 307);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(cNPJEmpresaResponsavelLabel);
            this.Controls.Add(this.cNPJEmpresaResponsavelTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.labelCadastroEmpreendimentos);
            this.Name = "FormCadastroEmpreendimento";
            this.Text = "FormCadastroEmpreendimento";
            this.Load += new System.EventHandler(this.FormCadastroEmpreendimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empreendimentosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCadastroEmpreendimentos;
        private System.Windows.Forms.BindingSource empreendimentosBindingSource;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox cNPJEmpresaResponsavelTextBox;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}