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
    public partial class FormBuscarCorretor : Form
    {
        public Corretor Corretor { get; set; }
        public FormBuscarCorretor()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                new UsuarioBLL().ValidarPermissao(3);
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

        private void FormBuscarCorretor_Load(object sender, EventArgs e)
        {
            comboBoxBuscarPor.SelectedIndex = 3;
        }
    }
}
