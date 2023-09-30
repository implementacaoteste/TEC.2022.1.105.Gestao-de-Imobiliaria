using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocacaoLaboratorio
{
    public partial class FormCadastroTerreno : Form
    {
        int id;
        public FormCadastroTerreno(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                terrenoBindingSource.EndEdit();
                Terreno terreno = (Terreno)terrenoBindingSource.Current;

                terreno.IdStatus_Terreno = 1;

                if (radioButtonVendido.Checked)
                    terreno.IdStatus_Terreno = 2;
                else if (radioButtonReservado.Checked)
                    terreno.IdStatus_Terreno = 3;

                if (id == 0)
                    new TerrenoBLL().inserir(terreno);
                else
                    new TerrenoBLL().Alterar(terreno);

                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormCadastroTerreno_Load(object sender, EventArgs e)
        {
            try
            {
                if (id == 0)
                {
                    terrenoBindingSource.AddNew();
                    metragemDireitaTextBox.Text =
                    metragemFrenteTextBox.Text =
                    metragemFundoTextBox.Text =
                    tamanhoTotalTerrenoTextBox.Text =
                    precoAVistaTextBox.Text =
                    precoParceladoTextBox.Text =
                    metragemEsquerdaTextBox.Text = "";
                    radioButtonDisponivel.Checked = true;
                }
                else
                {
                    terrenoBindingSource.DataSource = new TerrenoBLL().BuscarPorId(id);

                    radioButtonDisponivel.Checked = true;

                    if (((Terreno)terrenoBindingSource.Current).IdStatus_Terreno == 2)
                        radioButtonVendido.Checked = true;
                    else if (((Terreno)terrenoBindingSource.Current).IdStatus_Terreno == 3)
                        radioButtonReservado.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBuscarEmpreendimento_Click(object sender, EventArgs e)
        {
            using (FormConsultaEmpreendimentos frm = new FormConsultaEmpreendimentos())
            {
                frm.ShowDialog();
                ((Terreno)terrenoBindingSource.Current).Empreendimento = frm.Empreendimentos;
                nomeTextBox.DataBindings.Control.Text = ((Terreno)terrenoBindingSource.Current).Empreendimento.Nome;
            }
        }

        private void buttonBuscarEmpreendimento_Click_1(object sender, EventArgs e)
        {
            using (FormConsultaEmpreendimentos frm = new FormConsultaEmpreendimentos())
            {
                frm.ShowDialog();
                ((Terreno)terrenoBindingSource.Current).Empreendimento = frm.Empreendimentos;
                nomeTextBox.DataBindings.Control.Text = ((Terreno)terrenoBindingSource.Current).Empreendimento.Nome;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonDisponivel.BackColor =
                        radioButtonReservado.BackColor =
                        radioButtonVendido.BackColor = buttonSalvar.BackColor;

            if (radioButtonDisponivel.Checked)
                radioButtonDisponivel.BackColor = Color.Green;
            else if (radioButtonReservado.Checked)
                radioButtonReservado.BackColor = Color.Yellow;
            else if (radioButtonVendido.Checked)
                radioButtonVendido.BackColor = System.Drawing.ColorTranslator.FromHtml(Constantes.CorVendido);
        }
    }
}
