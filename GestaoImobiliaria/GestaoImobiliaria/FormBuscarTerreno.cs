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
    public partial class FormBuscarTerreno : Form
    {
        public Terreno Terreno { get; set; }
        public FormBuscarTerreno()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                new UsuarioBLL().ValidarPermissao(5);
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        if (String.IsNullOrEmpty(textBoxBuscar.Text))
                            throw new Exception("Informe um Id para fazer a Busca") { Data = { { "Id", 101 } } };
                        terrenoBindingSource.DataSource = new TerrenoBLL().BuscarPorId(Convert.ToInt32(textBoxBuscar.Text));
                        break;
                    case 1:
                        terrenoBindingSource.DataSource = new TerrenoBLL().BuscarPorMatricula(textBoxBuscar.Text);
                        break;
                    case 2:
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

        private void FormBuscarTerreno_Load(object sender, EventArgs e)
        {
            comboBoxBuscarPor.SelectedIndex = 2;
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (terrenoBindingSource.Count > 0)
                {
                    this.Terreno = (Models.Terreno)terrenoBindingSource.Current;
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
