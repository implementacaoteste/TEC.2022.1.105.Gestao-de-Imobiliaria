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
 
    public partial class FormBuscarEmpreendimento : Form
    {
        public Empreendimentos Empreendimentos { get; set; }
        public FormBuscarEmpreendimento()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                new UsuarioBLL().ValidarPermissao(4);
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        if (String.IsNullOrEmpty(textBoxBuscar.Text))
                            throw new Exception("Informe um Id para fazer a busca.") { Data = { { "Id", 6930 } } };

                        empreendimentosBindingSource.DataSource = new EmpreendimentoBLL().BuscarPorId(Convert.ToInt32(textBoxBuscar.Text));
                        break;
                    case 1:
                        empreendimentosBindingSource.DataSource = new EmpreendimentoBLL().BuscarPorNome(textBoxBuscar.Text);
                        break;
                    case 2:
                        empreendimentosBindingSource.DataSource = new EmpreendimentoBLL().BuscaPorCNPJ(textBoxBuscar.Text);
                        break;
                    case 3:
                        empreendimentosBindingSource.DataSource = new EmpreendimentoBLL().BuscarTodos();
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
                if (empreendimentosBindingSource.Count > 0)
                {
                    this.Empreendimentos = (Empreendimentos)empreendimentosBindingSource.Current;
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

        private void FormBuscarEmpreendimento_Load(object sender, EventArgs e)
        {
         
            comboBoxBuscarPor.SelectedIndex = 3;
        }
    }
}
