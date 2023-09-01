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
    public partial class FormConsultarCorretor : Form
    {
        public Corretor Corretor { get; set; }
        public FormConsultarCorretor()
        {
            InitializeComponent();
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        if (String.IsNullOrEmpty(textBoxBuscar.Text))
                            throw new Exception("Informe um Id para fazer a busca.") { Data = { { "Id", 31 } } };

                        corretorBindingSource.DataSource = new CorretorBLL().BuscarPorId(Convert.ToInt32(textBoxBuscar.Text));
                        break;
                    case 1:
                        corretorBindingSource.DataSource = new CorretorBLL().BuscarPorNome(textBoxBuscar.Text);
                        break;
                    case 2:
                        corretorBindingSource.DataSource = new CorretorBLL().BuscarPorCPF(textBoxBuscar.Text);
                        break;
                    case 3:
                        corretorBindingSource.DataSource = new CorretorBLL().BuscarTodos();
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
                if (corretorBindingSource.Count == 0)
                {
                    MessageBox.Show("Não existe corretor para ser alterado.");
                    return;
                }

                int id = ((Corretor)corretorBindingSource.Current).IdCorretor;

                using (FormCadastroCorretor frm = new FormCadastroCorretor(id))
                {
                    frm.ShowDialog();
                }
                buttonBuscar_Click(null, null);
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
                using (FormCadastroCorretor frm = new FormCadastroCorretor())
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
                if (corretorBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Corretor)corretorBindingSource.Current).IdCorretor;
                new CorretorBLL().Excluir(id);
                corretorBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (corretorBindingSource.Count > 0)
                {
                    this.Corretor = (Models.Corretor)corretorBindingSource.Current;
                    Close();
                    return;
                }
                throw new Exception("Não existe registro para ser selecionado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
