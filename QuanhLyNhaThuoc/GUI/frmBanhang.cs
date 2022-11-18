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
    public partial class frmBanhang : Form
    {
        public frmBanhang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemsanpham them = new frmThemsanpham();
            them.ShowDialog();
        }
    }
}
