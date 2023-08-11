using BLL;
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
                            throw new Exception("Informe um Id para fazer a Busca") { Data = { { "Id", 101} } };

                        terrenoBindingSource.DataSource = new TerrenoBLL().BuscarPorId(Convert.ToInt32(textBoxBuscar.Text));
                        break;
                    case 1:
                        terrenoBindingSource.DataSource = new TerrenoBLL().BuscarPorMatricula(Convert.ToInt32(textBoxBuscar.Text));
                        break ;
                        case 2:
                        terrenoBindingSource.DataSource = new TerrenoBLL().BuscarTodos();
                    default:
                        break;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
