using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ClosedXML.Excel;
using QuanLyBanHang.Data;

namespace QuanLyBanHang.Forms
{
    public partial class frmHoaDon : Form
    {
        QLBHDbContext context = new QLBHDbContext();
        int id;

        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dgvHoaDon.AutoGenerateColumns = false;

            List<DanhSachHoaDon> hd = context.HoaDon.Select(r => new DanhSachHoaDon
            {
                ID = r.ID,
                NhanVienID = r.NhanVienID,
                HoVaTenNhanVien = r.NhanVien.HoVaTen,
                KhachHangID = r.KhachHangID,
                HoVaTenKhachHang = r.KhachHang.HoVaTen,
                NgayLap = r.NgayLap,
                GhiChuHoaDon = r.GhiChuHoaDon,
                TongTienHoaDon = r.HoaDon_ChiTiet.Sum(ct => ct.SoLuongBan * ct.DonGiaBan),
                XemChiTiet = "Xem chi tiết"
            }).ToList();

            dgvHoaDon.DataSource = hd;
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet())
            {
                chiTiet.ShowDialog();
            }

            frmHoaDon_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow == null) return;

            id = Convert.ToInt32(dgvHoaDon.CurrentRow.Cells["ID"].Value?.ToString());
            using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet(id))
            {
                chiTiet.ShowDialog();
            }

            frmHoaDon_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow == null) return;

            id = Convert.ToInt32(dgvHoaDon.CurrentRow.Cells["ID"].Value?.ToString());
            if (MessageBox.Show("Xác nhận xóa hóa đơn này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                HoaDon? hoaDon = context.HoaDon.Find(id);
                if (hoaDon != null)
                {
                    List<HoaDon_ChiTiet> chiTietHoaDon = context.HoaDon_ChiTiet.Where(r => r.HoaDonID == id).ToList();
                    context.HoaDon_ChiTiet.RemoveRange(chiTietHoaDon);
                    context.HoaDon.Remove(hoaDon);
                    context.SaveChanges();
                    frmHoaDon_Load(sender, e);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu Hóa đơn";
            openFileDialog.Filter = "Excel Files|*.xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        // ===== KIỂM TRA SHEET =====
                        if (!workbook.Worksheets.Contains("HoaDon") ||
                            !workbook.Worksheets.Contains("HoaDon_ChiTiet"))
                        {
                            MessageBox.Show("File không đúng định dạng (thiếu sheet).");
                            return;
                        }

                        // ===== ĐỌC SHEET HOADON =====
                        var sheetHoaDon = workbook.Worksheet("HoaDon");

                        foreach (IXLRow row in sheetHoaDon.RowsUsed().Skip(1))
                        {
                            HoaDon hd = new HoaDon();

                            hd.NhanVienID = int.Parse(row.Cell(2).Value.ToString());
                            hd.KhachHangID = int.Parse(row.Cell(3).Value.ToString());
                            hd.NgayLap = DateTime.Parse(row.Cell(4).Value.ToString());
                            hd.GhiChuHoaDon = row.Cell(5).Value.ToString();

                            context.HoaDon.Add(hd);
                        }

                        context.SaveChanges();


                        // ===== ĐỌC SHEET HOADON_CHITIET =====
                        var sheetChiTiet = workbook.Worksheet("HoaDon_ChiTiet");

                        foreach (IXLRow row in sheetChiTiet.RowsUsed().Skip(1))
                        {
                            HoaDon_ChiTiet ct = new HoaDon_ChiTiet();

                            ct.HoaDonID = int.Parse(row.Cell(2).Value.ToString());
                            ct.SanPhamID = int.Parse(row.Cell(3).Value.ToString());
                            ct.SoLuongBan = short.Parse(row.Cell(4).Value.ToString());
                            ct.DonGiaBan = int.Parse(row.Cell(5).Value.ToString());

                            context.HoaDon_ChiTiet.Add(ct);
                        }

                        context.SaveChanges();

                        MessageBox.Show("Nhập dữ liệu thành công!",
                            "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        frmHoaDon_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Nhập dữ liệu Hóa đơn";
                openFileDialog.Filter = "Excel Files|*.xlsx";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                        {
                            // ===== KIỂM TRA SHEET =====
                            if (!workbook.Worksheets.Contains("HoaDon") ||
                                !workbook.Worksheets.Contains("HoaDon_ChiTiet"))
                            {
                                MessageBox.Show("File không đúng định dạng (thiếu sheet).");
                                return;
                            }

                            // ===== ĐỌC SHEET HOADON =====
                            var sheetHoaDon = workbook.Worksheet("HoaDon");

                            foreach (IXLRow row in sheetHoaDon.RowsUsed().Skip(1))
                            {
                                HoaDon hd = new HoaDon();

                                hd.NhanVienID = int.Parse(row.Cell(2).Value.ToString());
                                hd.KhachHangID = int.Parse(row.Cell(3).Value.ToString());
                                hd.NgayLap = DateTime.Parse(row.Cell(4).Value.ToString());
                                hd.GhiChuHoaDon = row.Cell(5).Value.ToString();

                                context.HoaDon.Add(hd);
                            }

                            context.SaveChanges();


                            // ===== ĐỌC SHEET HOADON_CHITIET =====
                            var sheetChiTiet = workbook.Worksheet("HoaDon_ChiTiet");

                            foreach (IXLRow row in sheetChiTiet.RowsUsed().Skip(1))
                            {
                                HoaDon_ChiTiet ct = new HoaDon_ChiTiet();

                                ct.HoaDonID = int.Parse(row.Cell(2).Value.ToString());
                                ct.SanPhamID = int.Parse(row.Cell(3).Value.ToString());
                                ct.SoLuongBan = short.Parse(row.Cell(4).Value.ToString());
                                ct.DonGiaBan = int.Parse(row.Cell(5).Value.ToString());

                                context.HoaDon_ChiTiet.Add(ct);
                            }

                            context.SaveChanges();

                            MessageBox.Show("Nhập dữ liệu thành công!",
                                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            frmHoaDon_Load(sender, e);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
        }
    }
}
