using BLL;
using System;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Windows.Forms;


namespace LocacaoLaboratorio
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormBuscarUsuario frm = new FormBuscarUsuario())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                this.Visible = false;
                using (FormLogin frm = new FormLogin())
                {
                    frm.ShowDialog();
                    if (!frm.Logou)
                        Application.Exit();
                }

                this.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeslogar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new UsuarioBLL().Logout();
            using (FormLogin frm = new FormLogin())
            {
                frm.ShowDialog();
                if (!frm.Logou)
                    Application.Exit();
            }

            this.Visible = true;
        }


        private void gruposDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormBuscarGrupoUsuario frm = new FormBuscarGrupoUsuario())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormConsultaCliente frm = new FormConsultaCliente())
            {
                frm.ShowDialog();
            }
        }

        private void terrenosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormConsultarTerreno frm = new FormConsultarTerreno())
            {
                frm.ShowDialog();
            }
        }

        private void empreedimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormConsultaEmpreendimentos frm = new FormConsultaEmpreendimentos()) 
            {
                frm.ShowDialog();
            }
                   
        }
        private void corretoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormBuscarReserva frm = new FormBuscarReserva())
            {
                frm.ShowDialog();
            }
        }

        private void corretoresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            using (FormConsultarCorretor frm = new FormConsultarCorretor())
            {
                frm.ShowDialog();
            }
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormConsultaVendas frm = new FormConsultaVendas())
            {
                frm.ShowDialog();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       
        private void AbrirForm(object _form)
        {
            if (this.painelContenedor.Controls.Count > 0)
                this.painelContenedor.Controls.RemoveAt(0);
            Form fh = _form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.painelContenedor.Controls.Add(fh);
            this.painelContenedor.Tag = fh;
            fh.Show();

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirForm(new FormBuscarUsuario());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AbrirForm(new FormInicio());
        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            AbrirForm(new FormBuscarGrupoUsuario());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirForm(new FormConsultaCliente());
        }

        private void btnCorretores_Click(object sender, EventArgs e)
        {
            AbrirForm(new FormConsultarCorretor());
        }

        private void btnEmpreendimentos_Click(object sender, EventArgs e)
        {
            AbrirForm(new FormConsultaEmpreendimentos());
        }

        private void btnTerrenos_Click(object sender, EventArgs e)
        {
            AbrirForm(new FormConsultarTerreno());
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            AbrirForm(new FormBuscarReserva());
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            AbrirForm(new FormConsultaVendas());
        }
    }
}
