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
    public partial class FormCadastroCorretor : Form
    {
        int id;
        public FormCadastroCorretor(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }

        private void rGTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rGLabel_Click(object sender, EventArgs e)
        {

        }

        private void foneLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                corretorBindingSource.EndEdit();
                Corretor corretor = (Corretor)corretorBindingSource.Current;


                if (id == 0)
                    new CorretorBLL().Inserir(corretor);
                else
                    new CorretorBLL().Alterar(corretor);

                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormCadastroCorretor_Load(object sender, EventArgs e)
        {
            try
            {
                if (id == 0)
                    corretorBindingSource.AddNew();
                else
                    corretorBindingSource.DataSource = new CorretorBLL().BuscarPorId(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
