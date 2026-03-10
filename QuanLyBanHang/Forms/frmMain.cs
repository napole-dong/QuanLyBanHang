using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using QuanLyBanHang.Data;
using BC = BCrypt.Net.BCrypt;

namespace QuanLyBanHang.Forms
{
    public partial class frmMain : Form
    {

        QLBHDbContext context = new QLBHDbContext(); // kết nối CSDL

        frmLoaiSanPham loaiSanPham = null;
        frmHangSanXuat hangSanXuat = null;
        frmSanPham sanPham = null;
        frmKhachHang khachHang = null;
        frmNhanVien nhanVien = null;
        frmHoaDon hoaDon = null;
        frmDangNhap dangNhap = null;

        string hoVaTenNhanVien = ""; // hiển thị trên StatusStrip
        public frmMain()
        {
            InitializeComponent();
        }

        public void QuyenNhanVien()
        {
            // Mờ đăng nhập
            mnuDangNhap.Enabled = false;

            // Mờ các chức năng không được phép
            mnuLoaiSanPham.Enabled = false;
            mnuHangSanXuat.Enabled = false;
            mnuSanPham.Enabled = false;
            mnuNhanVien.Enabled = false;

            // Sáng chức năng được phép
            mnuDangXuat.Enabled = true;
            mnuDoiMatKhau.Enabled = true;

            mnuKhachHang.Enabled = true;
            mnuHoaDon.Enabled = true;

            mnuThongKeSanPham.Enabled = true;
            mnuThongKeDoanhThu.Enabled = true;

            // Hiển thị trạng thái
            lblTrangThai.Text = "Nhân viên: " + hoVaTenNhanVien;
        }
        public void QuyenQuanLy()
        {
            // Mờ đăng nhập
            mnuDangNhap.Enabled = false;

            // Sáng các chức năng
            mnuDangXuat.Enabled = true;
            mnuDoiMatKhau.Enabled = true;

            mnuLoaiSanPham.Enabled = true;
            mnuHangSanXuat.Enabled = true;
            mnuSanPham.Enabled = true;
            mnuKhachHang.Enabled = true;
            mnuNhanVien.Enabled = true;
            mnuHoaDon.Enabled = true;

            mnuThongKeSanPham.Enabled = true;
            mnuThongKeDoanhThu.Enabled = true;

            // Hiển thị trạng thái
            lblTrangThai.Text = "Quản lý: " + hoVaTenNhanVien;
        }
        public void ChuaDangNhap()
        {
            // Sáng đăng nhập
            mnuDangNhap.Enabled = true;

            // Mờ tất cả
            mnuDangXuat.Enabled = false;
            mnuDoiMatKhau.Enabled = false;

            mnuLoaiSanPham.Enabled = false;
            mnuHangSanXuat.Enabled = false;
            mnuSanPham.Enabled = false;
            mnuKhachHang.Enabled = false;
            mnuNhanVien.Enabled = false;
            mnuHoaDon.Enabled = false;

            mnuThongKeSanPham.Enabled = false;
            mnuThongKeDoanhThu.Enabled = false;

            // Hiển thị trạng thái
            lblTrangThai.Text = "Chưa đăng nhập.";
        }

        private void DangNhap()
        {
        LamLai:

            if (dangNhap == null || dangNhap.IsDisposed)
                dangNhap = new frmDangNhap();

            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                string tenDangNhap = dangNhap.txtTendangnhap.Text;
                string matKhau = dangNhap.txtMatkhau.Text;

                if (tenDangNhap.Trim() == "")
                {
                    MessageBox.Show("Tên đăng nhập không được bỏ trống!",
                                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtTendangnhap.Focus();
                    goto LamLai;
                }
                else if (matKhau.Trim() == "")
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống!",
                                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtMatkhau.Focus();
                    goto LamLai;
                }
                else
                {
                    var nhanVien = context.NhanVien
                                          .Where(r => r.TenDangNhap == tenDangNhap)
                                          .SingleOrDefault();

                    if (nhanVien == null)
                    {
                        MessageBox.Show("Tên đăng nhập không chính xác!",
                                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dangNhap.txtTendangnhap.Focus();
                        goto LamLai;
                    }
                    else
                    {
                        if (BC.Verify(matKhau, nhanVien.MatKhau))
                        {
                            hoVaTenNhanVien = nhanVien.HoVaTen;

                            if (nhanVien.QuyenHan == true)
                                QuyenQuanLy();
                            else if (nhanVien.QuyenHan == false)
                                QuyenNhanVien();
                            else
                                ChuaDangNhap();
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không chính xác!",
                                            "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dangNhap.txtMatkhau.Focus();
                            goto LamLai;
                        }
                    }
                }
            }
        }

        private void mnuLoaiSanPham_Click(object sender, EventArgs e)
        {
            if (loaiSanPham == null || loaiSanPham.IsDisposed)
            {
                loaiSanPham = new frmLoaiSanPham();
                loaiSanPham.MdiParent = this;
                loaiSanPham.Show();
            }
            else
                loaiSanPham.Activate();
        }

        private void mnuHangSanXuat_Click(object sender, EventArgs e)
        {
            if (hangSanXuat == null || hangSanXuat.IsDisposed)
            {
                hangSanXuat = new frmHangSanXuat();
                hangSanXuat.MdiParent = this;
                hangSanXuat.Show();
            }
            else
                hangSanXuat.Activate();
        }

        private void mnuSanPham_Click(object sender, EventArgs e)
        {
            if (sanPham == null || sanPham.IsDisposed)
            {
                sanPham = new frmSanPham();
                sanPham.MdiParent = this;
                sanPham.Show();
            }
            else
                sanPham.Activate();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            if (khachHang == null || khachHang.IsDisposed)
            {
                khachHang = new frmKhachHang();
                khachHang.MdiParent = this;
                khachHang.Show();
            }
            else
                khachHang.Activate();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            if (nhanVien == null || nhanVien.IsDisposed)
            {
                nhanVien = new frmNhanVien();
                nhanVien.MdiParent = this;
                nhanVien.Show();
            }
            else
                nhanVien.Activate();
        }

        private void mnuHoaDon_Click(object sender, EventArgs e)
        {
            if (hoaDon == null || hoaDon.IsDisposed)
            {
                hoaDon = new frmHoaDon();
                hoaDon.MdiParent = this;
                hoaDon.Show();
            }
            else
                hoaDon.Activate();
        }

        private void lblLienket_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "explorer.exe";
            info.Arguments = "https://fit.agu.edu.vn";
            Process.Start(info);
        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {

            foreach (Form child in MdiChildren)
            {
                child.Close();
            }
            ChuaDangNhap();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ChuaDangNhap();
            DangNhap();
        }
    }
}