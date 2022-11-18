using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanhLyNhaThuoc
{
    public partial class frmBaocao : Form
    {
        public frmBaocao()
        {
            InitializeComponent();
        }

        private void btnLocmua_Click(object sender, EventArgs e)
        {
            frmBaocaonhap nhap = new frmBaocaonhap();
            nhap.TopLevel = false;
            panel2.Controls.Add(nhap);
            //baocao.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            nhap.Dock = DockStyle.Fill;
            nhap.Show();
        }

        private void btnLocban_Click(object sender, EventArgs e)
        {
            frmBaocaoban ban = new frmBaocaoban();
            ban.TopLevel = false;
            panel2.Controls.Add(ban);
            //ban.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ban.Dock = DockStyle.Fill;
            ban.Show();
        }
    }
}
