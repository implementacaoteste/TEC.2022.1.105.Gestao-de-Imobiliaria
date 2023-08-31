﻿using BLL;
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
                    new ReservaBLL().Inserir(reserva);
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

        private void buttonBuscarCorretor_Click(object sender, EventArgs e)
        {
            using (FormConsultarCorretor frm = new FormConsultarCorretor())
            {
                frm.ShowDialog();
                if (frm.Corretor != null)
                {
                    ((Reserva)reservaBindingSource.Current).Corretor = frm.Corretor;
                    nomeTextBox.DataBindings.Control.Text = ((Reserva)reservaBindingSource.Current).Corretor.Nome;
                }    
            }
        }

        private void buttonBuscarTerreno_Click(object sender, EventArgs e)
        {
            using (FormConsultarTerreno frm = new FormConsultarTerreno())
            {
                frm.ShowDialog();
                if (frm.Terreno != null)
                {
                    ((Reserva)reservaBindingSource.Current).Terreno = frm.Terreno;
                    enderecoTextBox.DataBindings.Control.Text = ((Reserva)reservaBindingSource.Current).Terreno.Endereco;
                    matriculaTextBox.DataBindings.Control.Text = ((Reserva)reservaBindingSource.Current).Terreno.Matricula;
                    nomeEmpreendimentoTextBox.DataBindings.Control.Text = ((Reserva)reservaBindingSource.Current).Terreno.NomeEmpreendimento;

                }
            }
        }
    }
}




