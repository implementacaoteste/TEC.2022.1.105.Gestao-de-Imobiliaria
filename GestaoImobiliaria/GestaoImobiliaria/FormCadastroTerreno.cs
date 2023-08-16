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
    public partial class FormCadastroTerreno : Form
    {
        int id;
        public FormCadastroTerreno(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Terreno terreno = (Terreno)terrenoBindingSource.Current;

                terrenoBindingSource.EndEdit();

                if (id == 0)
                    new TerrenoBLL().inserir(terreno);
                else
                    new TerrenoBLL().Alterar(terreno);

                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormCadastroTerreno_Load(object sender, EventArgs e)
        {
            try
            {
                if (id == 0)
                    terrenoBindingSource.AddNew();
                else
                    terrenoBindingSource.DataSource = new TerrenoBLL().BuscarPorId(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
