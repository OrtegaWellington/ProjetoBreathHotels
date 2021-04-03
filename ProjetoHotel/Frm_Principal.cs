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
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            panel_Dashboard.Height = Btn_1.Height;
            panel_Dashboard.Top = Btn_1.Top;
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            panel_Dashboard.Height = Btn_2.Height;
            panel_Dashboard.Top = Btn_2.Top;
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            panel_Dashboard.Height = Btn_3.Height;
            panel_Dashboard.Top = Btn_3.Top;
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            panel_Dashboard.Height = Btn_4.Height;
            panel_Dashboard.Top = Btn_4.Top;
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
