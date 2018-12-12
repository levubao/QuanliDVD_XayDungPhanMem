using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiDia
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnThueDia_Click(object sender, EventArgs e)
        {
            frmThueDia frm = new QuanLiDia.frmThueDia();         
            if (frm.ShowDialog() == DialogResult.OK)
                frm.Show();
        }

        private void btnTraDia_Click(object sender, EventArgs e)
        {
            frmTraDia frm = new QuanLiDia.frmTraDia();
            if (frm.ShowDialog() == DialogResult.OK)
                frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
