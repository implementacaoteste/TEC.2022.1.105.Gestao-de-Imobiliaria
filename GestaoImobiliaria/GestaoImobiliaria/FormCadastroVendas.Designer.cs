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
            System.Windows.Forms.Label iDClienteLabel;
            System.Windows.Forms.Label iDCorretorLabel;
            System.Windows.Forms.Label iDTerrenoLabel;
            this.vendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDClienteComboBox = new System.Windows.Forms.ComboBox();
            this.iDCorretorComboBox = new System.Windows.Forms.ComboBox();
            this.iDTerrenoComboBox = new System.Windows.Forms.ComboBox();
            this.labelCadastroVendas = new System.Windows.Forms.Label();
            this.buttonSalvarVenda = new System.Windows.Forms.Button();
            this.buttonCancelarCadVenda = new System.Windows.Forms.Button();
            iDClienteLabel = new System.Windows.Forms.Label();
            iDCorretorLabel = new System.Windows.Forms.Label();
            iDTerrenoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDClienteLabel
            // 
            iDClienteLabel.AutoSize = true;
            iDClienteLabel.Location = new System.Drawing.Point(18, 96);
            iDClienteLabel.Name = "iDClienteLabel";
            iDClienteLabel.Size = new System.Drawing.Size(64, 16);
            iDClienteLabel.TabIndex = 6;
            iDClienteLabel.Text = "IDCliente:";
            // 
            // iDCorretorLabel
            // 
            iDCorretorLabel.AutoSize = true;
            iDCorretorLabel.Location = new System.Drawing.Point(565, 96);
            iDCorretorLabel.Name = "iDCorretorLabel";
            iDCorretorLabel.Size = new System.Drawing.Size(71, 16);
            iDCorretorLabel.TabIndex = 7;
            iDCorretorLabel.Text = "IDCorretor:";
            // 
            // iDTerrenoLabel
            // 
            iDTerrenoLabel.AutoSize = true;
            iDTerrenoLabel.Location = new System.Drawing.Point(277, 96);
            iDTerrenoLabel.Name = "iDTerrenoLabel";
            iDTerrenoLabel.Size = new System.Drawing.Size(71, 16);
            iDTerrenoLabel.TabIndex = 8;
            iDTerrenoLabel.Text = "IDTerreno:";
            // 
            // vendasBindingSource
            // 
            this.vendasBindingSource.DataSource = typeof(Models.Vendas);
            // 
            // iDClienteComboBox
            // 
            this.iDClienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "IDCliente", true));
            this.iDClienteComboBox.FormattingEnabled = true;
            this.iDClienteComboBox.Location = new System.Drawing.Point(88, 93);
            this.iDClienteComboBox.Name = "iDClienteComboBox";
            this.iDClienteComboBox.Size = new System.Drawing.Size(121, 24);
            this.iDClienteComboBox.TabIndex = 7;
            // 
            // iDCorretorComboBox
            // 
            this.iDCorretorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "IDCorretor", true));
            this.iDCorretorComboBox.FormattingEnabled = true;
            this.iDCorretorComboBox.Location = new System.Drawing.Point(642, 93);
            this.iDCorretorComboBox.Name = "iDCorretorComboBox";
            this.iDCorretorComboBox.Size = new System.Drawing.Size(121, 24);
            this.iDCorretorComboBox.TabIndex = 8;
            // 
            // iDTerrenoComboBox
            // 
            this.iDTerrenoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "IDTerreno", true));
            this.iDTerrenoComboBox.FormattingEnabled = true;
            this.iDTerrenoComboBox.Location = new System.Drawing.Point(354, 93);
            this.iDTerrenoComboBox.Name = "iDTerrenoComboBox";
            this.iDTerrenoComboBox.Size = new System.Drawing.Size(121, 24);
            this.iDTerrenoComboBox.TabIndex = 9;
            // 
            // labelCadastroVendas
            // 
            this.labelCadastroVendas.AutoSize = true;
            this.labelCadastroVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastroVendas.Location = new System.Drawing.Point(173, 9);
            this.labelCadastroVendas.Name = "labelCadastroVendas";
            this.labelCadastroVendas.Size = new System.Drawing.Size(487, 46);
            this.labelCadastroVendas.TabIndex = 10;
            this.labelCadastroVendas.Text = "CADASTRO DE VENDAS";
            // 
            // buttonSalvarVenda
            // 
            this.buttonSalvarVenda.Location = new System.Drawing.Point(585, 165);
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
            this.buttonCancelarCadVenda.Location = new System.Drawing.Point(688, 165);
            this.buttonCancelarCadVenda.Name = "buttonCancelarCadVenda";
            this.buttonCancelarCadVenda.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelarCadVenda.TabIndex = 12;
            this.buttonCancelarCadVenda.Text = "Cancelar";
            this.buttonCancelarCadVenda.UseVisualStyleBackColor = true;
            // 
            // FormCadastroVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 200);
            this.Controls.Add(this.buttonCancelarCadVenda);
            this.Controls.Add(this.buttonSalvarVenda);
            this.Controls.Add(this.labelCadastroVendas);
            this.Controls.Add(iDTerrenoLabel);
            this.Controls.Add(this.iDTerrenoComboBox);
            this.Controls.Add(iDCorretorLabel);
            this.Controls.Add(this.iDCorretorComboBox);
            this.Controls.Add(iDClienteLabel);
            this.Controls.Add(this.iDClienteComboBox);
            this.Name = "FormCadastroVendas";
            this.Text = "FormCadastroVendas";
            this.Load += new System.EventHandler(this.FormCadastroVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource vendasBindingSource;
        private System.Windows.Forms.ComboBox iDClienteComboBox;
        private System.Windows.Forms.ComboBox iDCorretorComboBox;
        private System.Windows.Forms.ComboBox iDTerrenoComboBox;
        private System.Windows.Forms.Label labelCadastroVendas;
        private System.Windows.Forms.Button buttonSalvarVenda;
        private System.Windows.Forms.Button buttonCancelarCadVenda;
    }
}