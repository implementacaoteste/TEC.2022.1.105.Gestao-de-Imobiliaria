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
        public Terreno Terreno { get; set; }
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

                using (FormCadastroTerreno frm = new FormCadastroTerreno(id))
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
        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (terrenoBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído");
                    return;
                }
                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Terreno)terrenoBindingSource.Current).IdTerreno;
                new TerrenoBLL().Excluir(id);
                terrenoBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormConsultarTerreno_Load(object sender, EventArgs e)
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

        private void buttonReserva_Click(object sender, EventArgs e)
        {
            try
            {
                if (terrenoBindingSource.Count == 0)
                    throw new Exception("Não existe terreno para ser reservado.");

                using (FormCadastroReserva frm = new FormCadastroReserva((Terreno)terrenoBindingSource.Current))
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void terrenoDataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int idStatus_Terrenos = Convert.ToInt32(terrenoDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn14"].Value);

            switch (idStatus_Terrenos)
            {
                case 1:
                    terrenoDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
                    break;
                case 2:
                    //terrenoDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                    terrenoDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff8d72");
                    break;
                case 3:
                    terrenoDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                    break; 

                default:
                    break;
            }
        }

       
    }
}
