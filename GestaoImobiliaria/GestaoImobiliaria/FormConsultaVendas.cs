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
                new UsuarioBLL().ValidarPermissao(6);
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0: 
                        if (String.IsNullOrEmpty(textBoxBuscar.Text))
                            throw new Exception("Informe um Id para fazer a busca.") { Data = { { "Id", 1238 } } };

                        vendasBindingSource.DataSource = new VendasBLL().BuscarPorIdVendas(Convert.ToInt32(textBoxBuscar.Text));
                        break;
                    case 1:
                        vendasBindingSource.DataSource = new VendasBLL().BuscarPorNomeCliente(textBoxBuscar.Text);
                        break;
                    case 2:
                        vendasBindingSource.DataSource = new VendasBLL().BuscarPorNomeCorretor(textBoxBuscar.Text);
                        break;
                    case 3:
                        vendasBindingSource.DataSource = new VendasBLL().BuscarPorNomeEmpreendimento(textBoxBuscar.Text);
                        break;
                    case 4:
                        vendasBindingSource.DataSource = new VendasBLL().BuscarPorEnderecoTerreno(textBoxBuscar.Text);
                        break;
                    case 5:
                        vendasBindingSource.DataSource = new VendasBLL().BuscarTodos();
                        break;
                    default:
                        vendasBindingSource.DataSource = new VendasBLL().BuscarTodos();
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
                new UsuarioBLL().ValidarPermissao(20);
                if (vendasBindingSource.Count == 0)
                {
                    MessageBox.Show("Não existe Vendas para ser alterada.");
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
                new UsuarioBLL().ValidarPermissao(27);
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

        private void FormConsultaVendas_Load(object sender, EventArgs e)
        {
            comboBoxBuscarPor.SelectedIndex = 5;
            buttonBuscarVenda_Click(sender, e);
        }

        private void buttonInserirVenda_Click_1(object sender, EventArgs e)
        {
            try
            {
                new UsuarioBLL().ValidarPermissao(13);
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
    }
}
