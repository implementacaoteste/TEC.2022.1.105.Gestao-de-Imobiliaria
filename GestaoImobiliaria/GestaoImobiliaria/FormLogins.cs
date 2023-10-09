using BLL;
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
    public partial class FormLogins : Form
    {
        public bool Logou;
        public FormLogins()
        {
            InitializeComponent();
            Logou = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
               
                textBox1.ForeColor = Color.Black;
                panel7.Visible = false;
            }
            catch { }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox2.ForeColor = Color.Black;
                panel9.Visible = false;
            }
            catch { }
        }

        private void FormLogins_Load(object sender, EventArgs e)
        {
            /*textBox1.Text = "Administrador";
            textBox2.Text = "123";
            */
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black; 
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private void FormLogins_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox1.Focus();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(null, null);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Digite o nome de usuário")
            {
                panel7.Visible = true;
                textBox1.Focus();
                return;
            }

            if (textBox2.Text == " ")
            {
                panel9.Visible = true;
                textBox2.Focus();
                return;
            }
            try
            {
                new UsuarioBLL().Altenticar(textBox1.Text, textBox2.Text);
                Logou = true;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
