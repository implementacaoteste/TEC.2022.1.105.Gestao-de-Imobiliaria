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
    public partial class FormCadastroReserva : Form
    {
        int id;
        public FormCadastroReserva(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }

        private void FormCadastroReserva_Load(object sender, EventArgs e)
        {
            try
            {
                if (id == 0)
                {
                    reservaBindingSource.AddNew();
                    prazoDateTimePicker.Value = DateTime.Now.AddDays(3);
                }
                else
                    reservaBindingSource.DataSource = new ReservaBLL().BuscarPorId(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonSalvar_click(object sender, EventArgs e)
        {
            try
            {
                Reserva reserva = (Reserva)reservaBindingSource.Current;

                reservaBindingSource.EndEdit();

                if (id == 0)
                    new ReservaBLL().Inserir( reserva);
                else
                    new ReservaBLL().Alterar(reserva);

                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonAdicionarTerreno_Click(object sender, EventArgs e)
        {
            try
            {
                //using (FormConsultaTerreno frm = new FormConsultaTerreno())
                //{
                //    frm.ShowDialog();

                //    if (frm.Id != 0)
                //    {
                //        int idterreno = ((Terreno)terrenoBindingSource.Current).Id;
                //        new TerrenoBLL().AdicionarTerreno(idterreno, frm.Id);
                //    }
                //}
                //ButtonBuscar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}        




