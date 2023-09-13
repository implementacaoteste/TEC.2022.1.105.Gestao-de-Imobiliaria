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
    public partial class FormConsultaVendas : Form
    {
        public Vendas vendas { get; set; }
        public FormConsultaVendas()
        {
            InitializeComponent();
        }

        private void buttonBuscarVenda_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        if (String.IsNullOrEmpty(textBoxBuscar.Text))
                            throw new Exception("Informe um Id para fazer a busca.") { Data = { { "Id", 2438 } } };

                        vendasBindingSource.DataSource = new VendasBLL().BuscarPorId(Convert.ToInt32(textBoxBuscar.Text));
                        break;
                    case 1:
                        vendasBindingSource.DataSource = new VendasBLL().BuscarPorCorretor(Convert.ToInt32(textBoxBuscar.Text));
                        break;
                    case 2:
                        vendasBindingSource.DataSource = new VendasBLL().BuscarPorCliente(Convert.ToInt32(textBoxBuscar.Text));
                        break;
                    case 3:
                        vendasBindingSource.DataSource = new VendasBLL().BuscarTodos();
                        break;
                    case 4:
                        vendasBindingSource.DataSource = new VendasBLL().BuscarPorData();
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






        private void buttonAlterarVenda_Click(object sender, EventArgs e)
        {
            try
            {
                if (vendasBindingSource.Count == 0)
                {
                    MessageBox.Show("Não existe empreendimento para ser alterado.");
                    return;
                }

                int id = ((Vendas)vendasBindingSource.Current).IDVenda;

                using (FormCadastroVendas frm = new FormCadastroVendas(id))
                {
                    frm.ShowDialog();
                }
                buttonBuscarVenda_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        private void buttonInserirVenda_Click(object sender, EventArgs e)
        {
             try
            {
                using (FormCadastroVendas frm = new FormCadastroVendas())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        private void buttonExcluirVenda_Click(object sender, EventArgs e)
        {
            try
            {
                if (vendasBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Vendas)vendasBindingSource.Current).IDVenda;
                new VendasBLL().Excluir(id);
                vendasBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        private void buttonSelecionarVenda_Click(object sender, EventArgs e)
        {
            try
            {
                if (vendasBindingSource.Count > 0)
                {
                    this.vendas = (Vendas)vendasBindingSource.Current;
                    Close();
                    return;
                }

                throw new Exception("Não existe registro para ser retornado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
