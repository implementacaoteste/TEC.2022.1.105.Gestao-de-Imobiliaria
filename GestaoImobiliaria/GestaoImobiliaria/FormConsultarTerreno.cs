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
    public partial class FormConsultarTerreno : Form
    {
        public FormConsultarTerreno()
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
                        if (String.IsNullOrEmpty(comboBoxBuscarPor.Text))
                            throw new Exception("Informe um Id para fazer a Busca") { Data = { { "Id", 101 } } };

                        terrenoBindingSource.DataSource = new TerrenoBLL().BuscarPorId(Convert.ToInt32(textBoxBuscar.Text));
                        break;
                    case 1:
                        //esperando implementacao do metodo BuscarPorMatricula
                        terrenoBindingSource.DataSource = new TerrenoBLL().BuscarPorMatricula(textBoxBuscar.Text);
                        //terrenoBindingSource.DataSource = new TerrenoBLL().BuscarPorMatricula(Convert.ToInt32(textBoxBuscar.Text));
                        break;
                    case 2:
                        //erro
                        terrenoBindingSource.DataSource = new TerrenoBLL().BuscarTodos();
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
                if (terrenoBindingSource.Count == 0)
                {
                    MessageBox.Show("Não existe terreno para ser alterado!");
                    return;
                }

                int id = ((Terreno)terrenoBindingSource.Current).IdTerreno;

                using (FormCadastroTerreno frm = new FormCadastroTerreno())
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
                using (FormCadastroTerreno frm = new FormCadastroTerreno())
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
