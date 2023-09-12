namespace LocacaoLaboratorio
{
    partial class FormCadastroVendas
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
            System.Windows.Forms.Label iDCorretorLabel;
            System.Windows.Forms.Label iDTerrenoLabel;
            System.Windows.Forms.Label iDEmpreendimentoLabel;
            System.Windows.Forms.Label nomeLabel;
            this.labelCadastroVendas = new System.Windows.Forms.Label();
            this.buttonSalvarVenda = new System.Windows.Forms.Button();
            this.buttonCancelarCadVenda = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonBuscarCliente = new System.Windows.Forms.Button();
            this.vendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            iDCorretorLabel = new System.Windows.Forms.Label();
            iDTerrenoLabel = new System.Windows.Forms.Label();
            iDEmpreendimentoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDCorretorLabel
            // 
            iDCorretorLabel.AutoSize = true;
            iDCorretorLabel.Location = new System.Drawing.Point(11, 172);
            iDCorretorLabel.Name = "iDCorretorLabel";
            iDCorretorLabel.Size = new System.Drawing.Size(71, 16);
            iDCorretorLabel.TabIndex = 7;
            iDCorretorLabel.Text = "IDCorretor:";
            // 
            // iDTerrenoLabel
            // 
            iDTerrenoLabel.AutoSize = true;
            iDTerrenoLabel.Location = new System.Drawing.Point(352, 99);
            iDTerrenoLabel.Name = "iDTerrenoLabel";
            iDTerrenoLabel.Size = new System.Drawing.Size(71, 16);
            iDTerrenoLabel.TabIndex = 8;
            iDTerrenoLabel.Text = "IDTerreno:";
            // 
            // labelCadastroVendas
            // 
            this.labelCadastroVendas.AutoSize = true;
            this.labelCadastroVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastroVendas.Location = new System.Drawing.Point(80, 9);
            this.labelCadastroVendas.Name = "labelCadastroVendas";
            this.labelCadastroVendas.Size = new System.Drawing.Size(487, 46);
            this.labelCadastroVendas.TabIndex = 10;
            this.labelCadastroVendas.Text = "CADASTRO DE VENDAS";
            // 
            // buttonSalvarVenda
            // 
            this.buttonSalvarVenda.Location = new System.Drawing.Point(401, 293);
            this.buttonSalvarVenda.Name = "buttonSalvarVenda";
            this.buttonSalvarVenda.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvarVenda.TabIndex = 11;
            this.buttonSalvarVenda.Text = "Salvar";
            this.buttonSalvarVenda.UseVisualStyleBackColor = true;
            this.buttonSalvarVenda.Click += new System.EventHandler(this.buttonSalvarVenda_Click);
            // 
            // buttonCancelarCadVenda
            // 
            this.buttonCancelarCadVenda.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelarCadVenda.Location = new System.Drawing.Point(520, 293);
            this.buttonCancelarCadVenda.Name = "buttonCancelarCadVenda";
            this.buttonCancelarCadVenda.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelarCadVenda.TabIndex = 12;
            this.buttonCancelarCadVenda.Text = "Cancelar";
            this.buttonCancelarCadVenda.UseVisualStyleBackColor = true;
            // 
            // iDEmpreendimentoLabel
            // 
            iDEmpreendimentoLabel.AutoSize = true;
            iDEmpreendimentoLabel.Location = new System.Drawing.Point(297, 172);
            iDEmpreendimentoLabel.Name = "iDEmpreendimentoLabel";
            iDEmpreendimentoLabel.Size = new System.Drawing.Size(126, 16);
            iDEmpreendimentoLabel.TabIndex = 12;
            iDEmpreendimentoLabel.Text = "IDEmpreendimento:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "IDEmpreendimento", true));
            this.textBox1.Location = new System.Drawing.Point(88, 172);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 22);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "IDEmpreendimento", true));
            this.textBox2.Location = new System.Drawing.Point(429, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 22);
            this.textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "IDEmpreendimento", true));
            this.textBox3.Location = new System.Drawing.Point(429, 172);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(166, 22);
            this.textBox3.TabIndex = 16;
            // 
            // buttonBuscarCliente
            // 
            this.buttonBuscarCliente.Location = new System.Drawing.Point(255, 93);
            this.buttonBuscarCliente.Name = "buttonBuscarCliente";
            this.buttonBuscarCliente.Size = new System.Drawing.Size(29, 23);
            this.buttonBuscarCliente.TabIndex = 17;
            this.buttonBuscarCliente.Text = "...";
            this.buttonBuscarCliente.UseVisualStyleBackColor = true;
            this.buttonBuscarCliente.Click += new System.EventHandler(this.buttonBuscarCliente_Click);
            // 
            // vendasBindingSource
            // 
            this.vendasBindingSource.DataSource = typeof(Models.Vendas);
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(31, 96);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(51, 16);
            nomeLabel.TabIndex = 17;
            nomeLabel.Text = "Cliente:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "Cliente.Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(88, 93);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(161, 22);
            this.nomeTextBox.TabIndex = 18;
            // 
            // FormCadastroVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 346);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.buttonBuscarCliente);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(iDEmpreendimentoLabel);
            this.Controls.Add(this.buttonCancelarCadVenda);
            this.Controls.Add(this.buttonSalvarVenda);
            this.Controls.Add(this.labelCadastroVendas);
            this.Controls.Add(iDTerrenoLabel);
            this.Controls.Add(iDCorretorLabel);
            this.Name = "FormCadastroVendas";
            this.Text = "FormCadastroVendas";
            this.Load += new System.EventHandler(this.FormCadastroVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource vendasBindingSource;
        private System.Windows.Forms.Label labelCadastroVendas;
        private System.Windows.Forms.Button buttonSalvarVenda;
        private System.Windows.Forms.Button buttonCancelarCadVenda;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonBuscarCliente;
        private System.Windows.Forms.TextBox nomeTextBox;
    }
}