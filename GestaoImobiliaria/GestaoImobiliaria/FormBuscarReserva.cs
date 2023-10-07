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
    public partial class FormBuscarReserva : Form
    {
        public FormBuscarReserva()
        {
            InitializeComponent();
        }



        private void buttonInserir_Click(object sender, EventArgs e)
        {
            try
            {
                new UsuarioBLL().ValidarPermissao(14);
                using (FormCadastroReserva frm = new FormCadastroReserva())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonBuscar_click(object sender, EventArgs e)
        {
            try
            {
                 new UsuarioBLL().ValidarPermissao(7);
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        if (String.IsNullOrEmpty(textBoxBuscar.Text))
                            throw new Exception("Informe um Id para fazer a busca.") { Data = { { "Id", 31 } } };

                        reservaBindingSource.DataSource = new ReservaBLL().BuscarPorId(Convert.ToInt32(textBoxBuscar.Text));
                        break;
                    case 1:
                        reservaBindingSource.DataSource = new ReservaBLL().BuscarTodos();
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

        private void ButtonAlterar_click(object sender, EventArgs e)
        {
            try
            {
                new UsuarioBLL().ValidarPermissao(21);
                if (reservaBindingSource.Count == 0)
                {
                    MessageBox.Show("Não existe cliente para ser alterado.");
                    return;
                }

                int id = ((Reserva)reservaBindingSource.Current).IdReserva;

                using (FormCadastroReserva frm = new FormCadastroReserva(id))
                {
                    frm.ShowDialog();
                }
                ButtonBuscar_click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcluir_click(object sender, EventArgs e)
        {
            try
            {
                new UsuarioBLL().ValidarPermissao(28);
                if (reservaBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Reserva)reservaBindingSource.Current).IdReserva;
                new ReservaBLL().Excluir(id);
                reservaBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormBuscarReserva_Load(object sender, EventArgs e)
        {
            comboBoxBuscarPor.SelectedIndex = 1;
        }
    }
}
