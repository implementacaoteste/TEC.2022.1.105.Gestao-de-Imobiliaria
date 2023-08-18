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
    public partial class FormConsultaEmpreendimentos : Form
    {
        public FormConsultaEmpreendimentos()
        {
            InitializeComponent();
        }

        private void empreendimentosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        if (String.IsNullOrEmpty(textBoxBuscar.Text))
                            throw new Exception("Informe um Id para fazer a busca.") { Data = { { "Id", 6930 } } };

                        empreendimentosBindingSource.DataSource = new EmpreendimentoBLL().BuscarPorId(Convert.ToInt32(textBoxBuscar.Text));
                        break;
                    case 1:
                        empreendimentosBindingSource.DataSource = new EmpreendimentoBLL().BuscarPorNome(textBoxBuscar.Text);
                        break;
                    case 2:
                        empreendimentosBindingSource.DataSource = new EmpreendimentoBLL().BuscaPorCNPJ(textBoxBuscar.Text);
                        break;
                    case 3:
                        empreendimentosBindingSource.DataSource = new EmpreendimentoBLL().BuscarTodos();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }







        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (empreendimentosBindingSource.Count == 0)
                {
                    MessageBox.Show("Não existe empreendimento para ser alterado.");
                    return;
                }

                int id = ((Empreendimentos)empreendimentosBindingSource.Current).IDEmpreendimento;

                using (FormCadastroEmpreendimento frm = new FormCadastroEmpreendimento(id))
                {
                    frm.ShowDialog();
                }
                button1_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }







        private void buttonInserir_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormCadastroEmpreendimento frm = new FormCadastroEmpreendimento())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }







        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (empreendimentosBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Empreendimentos)empreendimentosBindingSource.Current).IDEmpreendimento;
                new EmpreendimentoBLL().Excluir(id);
                empreendimentosBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }







        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
