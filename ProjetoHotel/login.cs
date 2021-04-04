using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoHotel
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point(this.Width / 2 - 221, this.Height / 2 - 251);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(27,49,161);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            
        }

        private void ptr_login_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            Usuario objusuario = new Usuario();

            objusuario.Nomeuser = txt_usuario.Text.Replace("'", "");
            objusuario.Senha = txt_senha.Text;

            if (objusuario.logar())
            {
                this.Hide();
                pg_1 form = new pg_1();
                form.ShowDialog();
                this.Close();
            }

            else
            {                
                MessageBox.Show("Usuário ou senha inválidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
