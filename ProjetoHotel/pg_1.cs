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
    public partial class pg_1 : Form
    {
        public pg_1()
        {

            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }



        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lbl_horas.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void lbl_horas_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void pg_1_Load(object sender, EventArgs e)
        {

        }

        private void tmr_data_Tick(object sender, EventArgs e)
        {
            this.lbl_data.Text = DateTime.Now.ToString("DATA: dd-MM-yyyy");
        }

        private void fecharSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void cadastrarHóspedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cadastroHospedes CadastroHospede = new frm_cadastroHospedes();
            CadastroHospede.StartPosition = FormStartPosition.CenterParent;
            CadastroHospede.MdiParent = this; // < - Adicione isto
            CadastroHospede.Show();
        }

        private void tsm_cadastro_fun_Click(object sender, EventArgs e)
        {
            Frm_cadastroFuncionarios CadastroFuncionarios = new Frm_cadastroFuncionarios();
            CadastroFuncionarios.StartPosition = FormStartPosition.CenterParent;
            CadastroFuncionarios.MdiParent = this; 
            CadastroFuncionarios.Show();
        }

        private void tsm_andares_Click(object sender, EventArgs e)
        {
            Frm_andares CadastroAndares = new Frm_andares();
            CadastroAndares.StartPosition = FormStartPosition.CenterParent;
            CadastroAndares.MdiParent = this;
            CadastroAndares.Show();
        }

    
        private void tiposDeQuartosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_tiposDeQuartos CadastroTiposDeQuartos = new Frm_tiposDeQuartos();
            CadastroTiposDeQuartos.StartPosition = FormStartPosition.CenterParent;
            CadastroTiposDeQuartos.MdiParent = this;
            CadastroTiposDeQuartos.Show();
        }

        private void tsm_quartos_Click(object sender, EventArgs e)
        {
            Frm_quartos CadastroQuartos = new Frm_quartos();
            CadastroQuartos.StartPosition = FormStartPosition.CenterParent;
            CadastroQuartos.MdiParent = this;
            CadastroQuartos.Show();
        }

        private void tsm_cargo_Click(object sender, EventArgs e)
        {
            Frm_cargo CadastroCargo = new Frm_cargo();
            CadastroCargo.StartPosition = FormStartPosition.CenterParent;
            CadastroCargo.MdiParent = this;
            CadastroCargo.Show();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_empresa CadastroEmpresa = new Frm_empresa();
            CadastroEmpresa.StartPosition = FormStartPosition.CenterParent;
            CadastroEmpresa.MdiParent = this;
            CadastroEmpresa.Show();
        }

        private void fornecedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_fornecedores CadastroFornecedores = new Frm_fornecedores();
            CadastroFornecedores.StartPosition = FormStartPosition.CenterParent;
            CadastroFornecedores.MdiParent = this;
            CadastroFornecedores.Show();
        }
    }
}
