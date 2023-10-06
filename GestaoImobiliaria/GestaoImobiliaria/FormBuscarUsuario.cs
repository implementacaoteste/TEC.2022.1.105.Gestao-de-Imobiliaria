using BLL;
using Models;
using System;
using System.Windows.Forms;

namespace LocacaoLaboratorio
{
    public partial class FormBuscarUsuario : Form
    {
        public FormBuscarUsuario()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxUsuario.SelectedIndex)
                {
                    case 0:
                        if (String.IsNullOrEmpty(textBoxBuscarUsuario.Text))
                            throw new Exception("Informe um Id para fazer a busca.") { Data = { { "Id", 31 } } };

                        usuarioBindingSource.DataSource = new UsuarioBLL().BuscarPorId(Convert.ToInt32(textBoxBuscarUsuario.Text));
                        break;
                    case 1:
                        usuarioBindingSource.DataSource = new UsuarioBLL().BuscarPorNome(textBoxBuscarUsuario.Text);
                        break;
                    case 2:
                        usuarioBindingSource.DataSource = new UsuarioBLL().BuscarPorCPF(textBoxBuscarUsuario.Text);
                        break;
                    case 3:
                        usuarioBindingSource.DataSource = new UsuarioBLL().BuscarTodos();
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

        private void buttonExcluirUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                new UsuarioBLL().ValidarPermissao(4);
                if (usuarioBindingSource.Count == 0)
                    throw new Exception("Não existe usuário listado para ser excluído.");

                if (usuarioBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído.");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?",
                    "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Usuario)usuarioBindingSource.Current).Id;
                new UsuarioBLL().Excluir(id);
                usuarioBindingSource.RemoveCurrent();

                MessageBox.Show("Registro excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdicionarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
            new UsuarioBLL().ValidarPermissao(2);
            using (FormCadastroUsuario frm = new FormCadastroUsuario())
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

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (usuarioBindingSource.Count == 0)
                    throw new Exception("Não existe usuário listado para ser alterado.");
                new UsuarioBLL().ValidarPermissao(3);
                int id = ((Usuario)usuarioBindingSource.Current).Id;

                using (FormCadastroUsuario frm = new FormCadastroUsuario(id))
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



        private void buttonAdicionarGrupoUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                new UsuarioBLL().ValidarPermissao(6);
                using (FormConsultaGrupoUsuario frm = new FormConsultaGrupoUsuario())
                {
                    frm.ShowDialog();

                    if (frm.Id != 0)
                    {
                        int idUsuario = ((Usuario)usuarioBindingSource.Current).Id;
                        new UsuarioBLL().AdicionarGrupoUsuario(idUsuario, frm.Id);
                    }
                }
                buttonBuscar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcluirGrupoUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                new UsuarioBLL().ValidarPermissao(8);
                if (grupoUsuariosBindingSource.Count == 0)
                    throw new Exception("Não existe grupo listado para ser excluído.");

                int idGrupoUsuario = ((GrupoUsuario)grupoUsuariosBindingSource.Current).Id;
                int idUsuario = ((Usuario)usuarioBindingSource.Current).Id;
                new UsuarioBLL().RemoverGrupoUsuario(idUsuario, idGrupoUsuario);
                grupoUsuariosBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormBuscarUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void FormBuscarUsuario_Load(object sender, EventArgs e)
        {
            comboBoxUsuario.SelectedIndex = 3;
        }
    }
}
