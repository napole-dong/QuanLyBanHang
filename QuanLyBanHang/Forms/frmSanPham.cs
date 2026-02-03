using Microsoft.EntityFrameworkCore;
using QuanLyBanHang.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Forms
{
    public partial class frmSanPham : Form
    {
        private readonly QLBHDbContext context = new QLBHDbContext();
        private bool xuLyThem = false;
        private int id;
        private string imagesFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Images");
        private BindingSource bindingSource = new BindingSource();

        public frmSanPham()
        {
            InitializeComponent();
            Load += frmSanPham_Load;
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnLuu.Click += btnLuu_Click;
            btnXoa.Click += btnXoa_Click;
            btnHuyBo.Click += btnHuyBo_Click;
            btnThoat.Click += btnThoat_Click;
            btnDoiAnh.Click += btnDoiAnh_Click;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            cboLoaiSanPham.Enabled = giaTri;
            cboHangSanXuat.Enabled = giaTri;
            txtTenSanPham.Enabled = giaTri;
            txtMota.Enabled = giaTri;
            numSoLuong.Enabled = giaTri;
            numDonGia.Enabled = giaTri;
            picHinhAnh.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnDoiAnh.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LayLoaiSanPhamVaoComboBox();
            LayHangSanXuatVaoComboBox();

            dataGridView1.AutoGenerateColumns = false;

            ID.DataPropertyName = "ID";
            PhanLoai.DataPropertyName = "TenLoai";
            HangSanXuat.DataPropertyName = "TenHangSanXuat";
            TenSanPham.DataPropertyName = "TenSanPham";
            SoLuong.DataPropertyName = "SoLuong";
            DonGia.DataPropertyName = "DonGia";
            HinhAnh.DataPropertyName = "HinhAnh";

            List<DanhSachSanPham> sp = context.SanPham.Select(r => new DanhSachSanPham
            {
                ID = r.ID,
                LoaiSanPhamID = r.LoaiSanPhamID,
                TenLoai = r.LoaiSanPham.TenLoai,
                HangSanXuatID = r.HangSanXuatID,
                TenHangSanXuat = r.HangSanXuat.TenHangSanXuat,
                TenSanPham = r.TenSanPham,
                SoLuong = r.SoLuong,
                DonGia = r.DonGia,
                HinhAnh = r.HinhAnh,
                MoTa = r.MoTa
            }).ToList();

            bindingSource.DataSource = sp;

            cboLoaiSanPham.DataBindings.Clear();
            cboLoaiSanPham.DataBindings.Add("SelectedValue", bindingSource, "LoaiSanPhamID", false, DataSourceUpdateMode.Never);

            cboHangSanXuat.DataBindings.Clear();
            cboHangSanXuat.DataBindings.Add("SelectedValue", bindingSource, "HangSanXuatID", false, DataSourceUpdateMode.Never);

            txtTenSanPham.DataBindings.Clear();
            txtTenSanPham.DataBindings.Add("Text", bindingSource, "TenSanPham", false, DataSourceUpdateMode.Never);

            txtMota.DataBindings.Clear();
            txtMota.DataBindings.Add("Text", bindingSource, "MoTa", false, DataSourceUpdateMode.Never);

            numSoLuong.DataBindings.Clear();
            numSoLuong.DataBindings.Add("Value", bindingSource, "SoLuong", false, DataSourceUpdateMode.Never);

            numDonGia.DataBindings.Clear();
            numDonGia.DataBindings.Add("Value", bindingSource, "DonGia", false, DataSourceUpdateMode.Never);

            picHinhAnh.DataBindings.Clear();
            Binding hinhAnh = new Binding("ImageLocation", bindingSource, "HinhAnh");
            hinhAnh.Format += (s, e) =>
            {
                if (e.Value != null && !string.IsNullOrWhiteSpace(e.Value.ToString()))
                {
                    e.Value = Path.Combine(imagesFolder, e.Value.ToString());
                }
            };
            picHinhAnh.DataBindings.Add(hinhAnh);

            dataGridView1.DataSource = bindingSource;
        }

        public void LayLoaiSanPhamVaoComboBox()
        {
            cboLoaiSanPham.DataSource = context.LoaiSanPham.ToList();
            cboLoaiSanPham.ValueMember = "ID";
            cboLoaiSanPham.DisplayMember = "TenLoai";
        }

        public void LayHangSanXuatVaoComboBox()
        {
            cboHangSanXuat.DataSource = context.HangSanXuat.ToList();
            cboHangSanXuat.ValueMember = "ID";
            cboHangSanXuat.DisplayMember = "TenHangSanXuat";
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "HinhAnh")
            {
                if (e.Value != null && !string.IsNullOrWhiteSpace(e.Value.ToString()))
                {
                    string imagePath = Path.Combine(imagesFolder, e.Value.ToString());
                    if (File.Exists(imagePath))
                    {
                        Image image = Image.FromFile(imagePath);
                        image = new Bitmap(image, 24, 24);
                        e.Value = image;
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            cboLoaiSanPham.Text = "";
            cboHangSanXuat.Text = "";
            txtTenSanPham.Clear();
            txtMota.Clear();
            numSoLuong.Value = 0;
            numDonGia.Value = 0;
            picHinhAnh.Image = null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboLoaiSanPham.Text))
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(cboHangSanXuat.Text))
            {
                MessageBox.Show("Vui lòng chọn hãng sản xuất.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtTenSanPham.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numSoLuong.Value <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numDonGia.Value <= 0)
            {
                MessageBox.Show("Đơn giá sản phẩm phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (xuLyThem)
                {
                    SanPham sp = new SanPham();
                    sp.LoaiSanPhamID = Convert.ToInt32(cboLoaiSanPham.SelectedValue);
                    sp.HangSanXuatID = Convert.ToInt32(cboHangSanXuat.SelectedValue);
                    sp.TenSanPham = txtTenSanPham.Text.Trim();
                    sp.SoLuong = Convert.ToInt32(numSoLuong.Value);
                    sp.DonGia = Convert.ToInt32(numDonGia.Value);
                    sp.MoTa = string.IsNullOrWhiteSpace(txtMota.Text) ? null : txtMota.Text.Trim();
                    sp.HinhAnh = picHinhAnh.ImageLocation != null ? Path.GetFileName(picHinhAnh.ImageLocation) : null;

                    context.SanPham.Add(sp);
                    context.SaveChanges();
                }
                else
                {
                    SanPham sp = context.SanPham.Find(id);
                    if (sp != null)
                    {
                        sp.LoaiSanPhamID = Convert.ToInt32(cboLoaiSanPham.SelectedValue);
                        sp.HangSanXuatID = Convert.ToInt32(cboHangSanXuat.SelectedValue);
                        sp.TenSanPham = txtTenSanPham.Text.Trim();
                        sp.SoLuong = Convert.ToInt32(numSoLuong.Value);
                        sp.DonGia = Convert.ToInt32(numDonGia.Value);
                        sp.MoTa = string.IsNullOrWhiteSpace(txtMota.Text) ? null : txtMota.Text.Trim();
                        sp.HinhAnh = picHinhAnh.ImageLocation != null ? Path.GetFileName(picHinhAnh.ImageLocation) : null;

                        context.SanPham.Update(sp);
                        context.SaveChanges();
                    }
                }
                frmSanPham_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa sản phẩm " + txtTenSanPham.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
                SanPham sp = context.SanPham.Find(id);
                if (sp != null)
                {
                    context.SanPham.Remove(sp);
                }
                context.SaveChanges();

                frmSanPham_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmSanPham_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Cập nhật hình ảnh sản phẩm";
            openFileDialog.Filter = "Tập tin hình ảnh|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileName(openFileDialog.FileName);
                string fileSavePath = Path.Combine(imagesFolder, fileName);

                if (!Directory.Exists(imagesFolder))
                {
                    Directory.CreateDirectory(imagesFolder);
                }

                File.Copy(openFileDialog.FileName, fileSavePath, true);

                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
                SanPham sp = context.SanPham.Find(id);
                if (sp != null)
                {
                    sp.HinhAnh = fileName;
                    context.SanPham.Update(sp);
                    context.SaveChanges();
                    frmSanPham_Load(sender, e);
                }
            }
        }
    }
}
