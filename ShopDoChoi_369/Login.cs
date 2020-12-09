using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopDoChoi_369
{
    public partial class frmLogin : Form
    {
        private static Form formThis;
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (DangNhap())
            {
                this.Hide();
                fTableManager f = new fTableManager();
                f.Show();
                if (formThis == null)
                    formThis = this;
            }
            else
            {
                MessageBox.Show("Lỗi đăng nhập");
            }
        }

        private void btbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        public static void ShowForm()
        {
            formThis.Show();
        }
        private bool DangNhap()
        {
            string TenDangNhap = txtUsername.Text;
            string MatKhau = txtPassword.Text;
            if (TenDangNhap != null && MatKhau != null)
            {
                using (var db = new DoChoiEntities())
                {
                    return db.DangNhaps.Where(x => x.TenDangNhap == TenDangNhap && x.MatKhau == MatKhau).Count() > 0;
                }
            }
            return false;
        }
    }
}
