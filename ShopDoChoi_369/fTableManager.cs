using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopDoChoi_369
{
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
        }

        private void btnKinds_Click(object sender, EventArgs e)
        {
            Kinds form = new Kinds();
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.AutoScroll = true;
            panelCha.Controls.Clear();
            panelCha.Controls.Add(form);
            form.Show();
        }

        private void fTableManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLogin.ShowForm();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            Bill form = new Bill();
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.AutoScroll = true;
            panelCha.Controls.Clear();
            panelCha.Controls.Add(form);
            form.Show();
        }

        private void btnCustoms_Click(object sender, EventArgs e)
        {
            Customer form = new Customer();
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.AutoScroll = true;
            panelCha.Controls.Clear();
            panelCha.Controls.Add(form);
            form.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            Account form = new Account();
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.AutoScroll = true;
            panelCha.Controls.Clear();
            panelCha.Controls.Add(form);
            form.Show();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home form = new Home();
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.AutoScroll = true;
            panelCha.Controls.Clear();
            panelCha.Controls.Add(form);
            form.Show();
        }
    }
}
