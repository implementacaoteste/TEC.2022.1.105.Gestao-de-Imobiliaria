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
    public partial class FormCadastroVendas : Form
    {
        int id;
        public FormCadastroVendas(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }





        private void FormCadastroVendas_Load(object sender, EventArgs e)
        {
            if (id == 0)
                vendasBindingSource.AddNew();
            else
                vendasBindingSource.DataSource = new VendasBLL().BuscarPorIdVendas(id);
        }





        private void buttonSalvarVenda_Click(object sender, EventArgs e)
        {
            
                try
                {
                    Vendas vendas = (Vendas)vendasBindingSource.Current;

                    vendasBindingSource.EndEdit();

                    if (id == 0)
                        new VendasBLL().Inserir(vendas);
                    else
                        new VendasBLL().Alterar(vendas);

                    MessageBox.Show("Registro salvo com sucesso!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            
            
        }

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormBuscarCliente frm = new FormBuscarCliente())
                {
                    frm.ShowDialog();

                    if (frm.Cliente != null)
                    {
                        ((Vendas)vendasBindingSource.Current).Cliente = frm.Cliente;
                        nomeTextBox.Text = frm.Cliente.Nome;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBuscarCorretor_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormBuscarCorretor frm = new FormBuscarCorretor())
                {
                    frm.ShowDialog();

                    if (frm.Corretor != null)
                    {
                        ((Vendas)vendasBindingSource.Current).Corretor = frm.Corretor;
                        textBox1.Text = frm.Corretor.Nome;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void buttonBuscarTerreno_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormBuscarTerreno frm = new FormBuscarTerreno())
                {
                    frm.ShowDialog();

                    if(frm.Terreno != null)
                    {
                        ((Vendas)vendasBindingSource.Current).Terreno = frm.Terreno;
                        textBox2.Text = frm.Terreno.Endereco;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

