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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            frmTrangchu trangchu = new frmTrangchu();
            trangchu.TopLevel = false;
            panel2.Controls.Add(trangchu);
            //baocao.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            trangchu.Dock = DockStyle.Fill;
            trangchu.Show();
        }

        private void btnNhapkho_Click(object sender, EventArgs e)
        {
            frmNhapkho nhapkho = new frmNhapkho();
            nhapkho.TopLevel = false;
            panel2.Controls.Add(nhapkho);
            //nhapkho.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            nhapkho.Dock = DockStyle.Fill;
            nhapkho.Show();
        }

        private void btnBanhang_Click(object sender, EventArgs e)
        {
            frmBanhang banhang = new frmBanhang();
            banhang.TopLevel = false;
            panel2.Controls.Add(banhang);
            //banhang.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            banhang.Dock = DockStyle.Fill;
            banhang.Show();
        }

        private void btnThuoc_Click(object sender, EventArgs e)
        {
            frmThuoc thuoc = new frmThuoc();
            thuoc.TopLevel = false;
            panel2.Controls.Add(thuoc);
            //thuoc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            thuoc.Dock = DockStyle.Fill;
            thuoc.Show();
        }

        private void btnCuahang_Click(object sender, EventArgs e)
        {
            frmCuahang cuahang = new frmCuahang();
            cuahang.TopLevel = false;
            panel2.Controls.Add(cuahang);
            //cuahang.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            cuahang.Dock = DockStyle.Fill;
            cuahang.Show();
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            frmBaocao baocao = new frmBaocao();
            baocao.TopLevel = false;
            panel2.Controls.Add(baocao);
            //baocao.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            baocao.Dock = DockStyle.Fill;
            baocao.Show();
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Visible = false;
            login.ShowDialog();
        }
    }
}
