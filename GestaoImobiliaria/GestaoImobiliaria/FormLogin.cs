﻿using BLL;
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
    public partial class FormLogin : Form
    {
        public bool Logou;

        public FormLogin()
        {
            InitializeComponent();
            Logou = false;
        }
        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            using (FormLogins frm = new FormLogins())
            {
                frm.ShowDialog();
            }
            try
            {
                new UsuarioBLL().Altenticar(textBoxUsuario.Text, textBoxSenha.Text);
                Logou = true;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void textBoxUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBoxSenha.Focus();
        }

        private void textBoxSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonEntrar_Click(null, null);
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
#if DEBUG
            textBoxUsuario.Text = "Administrador";
            textBoxSenha.Text = "123";
            this.Location = new Point(559, 417);
            //buttonEntrar_Click(null, null);
#endif
        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {

        }

        /*private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = this.Location.X.ToString() + "," + this.Location.Y.ToString() + "|" + this.Location.ToString();
        }*/
    }
}
