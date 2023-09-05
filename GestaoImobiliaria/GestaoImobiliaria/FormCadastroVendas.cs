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
                vendasBindingSource.DataSource = new VendasBLL().BuscarPorId(id);
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




    }
}
