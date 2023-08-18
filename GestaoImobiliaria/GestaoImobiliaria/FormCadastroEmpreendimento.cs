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
    public partial class FormCadastroEmpreendimento : Form
    {
        int id;
        public FormCadastroEmpreendimento(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                empreendimentosBindingSource.EndEdit();
                Empreendimentos empreendimentos = (Empreendimentos)empreendimentosBindingSource.Current;

                if (id == 0)
                    new EmpreendimentoBLL().Inserir(empreendimentos);
                else
                    new EmpreendimentoBLL().Alterar(empreendimentos);

                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormCadastroEmpreendimento_Load(object sender, EventArgs e)
        {
            try
            {
                if (id == 0)
                    empreendimentosBindingSource.AddNew();
                else
                    empreendimentosBindingSource.DataSource = new EmpreendimentoBLL().BuscarPorId(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
