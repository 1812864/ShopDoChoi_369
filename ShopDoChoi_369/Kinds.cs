using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopDoChoi_369
{
    public partial class Kinds : Form
    {
        public Kinds()
        {
            InitializeComponent();
        }

        private void Kinds_Load(object sender, EventArgs e)
        {
            LayDsLoaiDoChoi();
            ThemDataBinding();
        }

        private void LayDsLoaiDoChoi()
        {
            DoChoiEntities db = new DoChoiEntities();
            var query = from l in db.LoaiDoChois
                        select l;
            var ds = query.ToList();
            dgvKind.DataSource = ds;
        }

        private void ThemDataBinding()
        {
            txtKindID.DataBindings.Clear();
            txtTenLoaiDC.DataBindings.Clear();
            txtKindID.DataBindings.Add(new Binding("Text", dgvKind.DataSource, "MaLoai", false, DataSourceUpdateMode.OnPropertyChanged));
            txtTenLoaiDC.DataBindings.Add(new Binding("Text", dgvKind.DataSource, "TenLoai", false, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void btnThemkind_Click(object sender, EventArgs e)
        {
            var maloai = txtKindID.Text;
            var tenloai = txtTenLoaiDC.Text;
            DoChoiEntities db = new DoChoiEntities();
            db.LoaiDoChois.Add(new LoaiDoChoi() { MaLoai = maloai, TenLoai = tenloai });
            db.SaveChanges();
            LayDsLoaiDoChoi();
            ThemDataBinding();
        }

        private void btnUpdatek_Click(object sender, EventArgs e)
        {
            var maloai = txtKindID.Text;
            var tenloai = txtTenLoaiDC.Text;
            DoChoiEntities db = new DoChoiEntities();
            var ketqua = db.LoaiDoChois.SingleOrDefault(l => l.MaLoai == maloai);
            if (ketqua != null)
            {
                ketqua.TenLoai = tenloai;
                db.SaveChanges();
                LayDsLoaiDoChoi();
                ThemDataBinding();
            }
        }

        private void btnXoakind_Click(object sender, EventArgs e)
        {
            var maloai = txtKindID.Text;
            DoChoiEntities db = new DoChoiEntities();
            var ketqua = db.LoaiDoChois.SingleOrDefault(l => l.MaLoai == maloai);
            if (ketqua != null)
            {
                db.LoaiDoChois.Remove(ketqua);
                db.SaveChanges();
            }
            LayDsLoaiDoChoi();
            ThemDataBinding();
        }
    }
}
