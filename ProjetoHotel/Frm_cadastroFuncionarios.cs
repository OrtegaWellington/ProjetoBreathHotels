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
    public partial class Frm_cadastroFuncionarios : Form
    {
        public Frm_cadastroFuncionarios()
        {
            InitializeComponent();

            cmb_cadastro_fun.Items.Clear();
            cmb_cadastro_fun.Items.Add("Recepcionista");
            cmb_cadastro_fun.Items.Add("Camareira");
            cmb_cadastro_fun.Items.Add("Gerente");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void cmb_cadastro_fun_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Frm_cadastroFuncionarios_Load(object sender, EventArgs e)
        {

        }

        private void lbl_senha_Click(object sender, EventArgs e)
        {

        }
    }
}
