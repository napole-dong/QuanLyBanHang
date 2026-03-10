namespace QuanLyBanHang.Forms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            mnuHethong = new ToolStripMenuItem();
            mnuDangNhap = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            mnuDoiMatKhau = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            mnuQuanly = new ToolStripMenuItem();
            mnuLoaiSanPham = new ToolStripMenuItem();
            mnuHangSanXuat = new ToolStripMenuItem();
            mnuSanPham = new ToolStripMenuItem();
            mnuKhachHang = new ToolStripMenuItem();
            mnuNhanVien = new ToolStripMenuItem();
            mnuHoaDon = new ToolStripMenuItem();
            mnuBaocaothongke = new ToolStripMenuItem();
            mnuThongKeSanPham = new ToolStripMenuItem();
            mnuThongKeDoanhThu = new ToolStripMenuItem();
            mnTrogiup = new ToolStripMenuItem();
            mnHuongdansudung = new ToolStripMenuItem();
            mnThongtinphanmem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblTrangThai = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblLienket = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuHethong, mnuQuanly, mnuBaocaothongke, mnTrogiup });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuHethong
            // 
            mnuHethong.DropDownItems.AddRange(new ToolStripItem[] { mnuDangNhap, mnuDangXuat, mnuDoiMatKhau, mnuThoat });
            mnuHethong.Name = "mnuHethong";
            mnuHethong.Size = new Size(69, 20);
            mnuHethong.Text = "He thong";
            // 
            // mnuDangNhap
            // 
            mnuDangNhap.Name = "mnuDangNhap";
            mnuDangNhap.Size = new Size(146, 22);
            mnuDangNhap.Text = "Dang nhap";
            mnuDangNhap.Click += mnuDangNhap_Click;
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(146, 22);
            mnuDangXuat.Text = "Dang xuat";
            mnuDangXuat.Click += mnuDangXuat_Click;
            // 
            // mnuDoiMatKhau
            // 
            mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            mnuDoiMatKhau.Size = new Size(146, 22);
            mnuDoiMatKhau.Text = "Doi mat khau";
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuThoat.Size = new Size(146, 22);
            mnuThoat.Text = "Thoat";
            // 
            // mnuQuanly
            // 
            mnuQuanly.DropDownItems.AddRange(new ToolStripItem[] { mnuLoaiSanPham, mnuHangSanXuat, mnuSanPham, mnuKhachHang, mnuNhanVien, mnuHoaDon });
            mnuQuanly.Name = "mnuQuanly";
            mnuQuanly.Size = new Size(60, 20);
            mnuQuanly.Text = "Quan ly";
            // 
            // mnuLoaiSanPham
            // 
            mnuLoaiSanPham.Name = "mnuLoaiSanPham";
            mnuLoaiSanPham.Size = new Size(173, 22);
            mnuLoaiSanPham.Text = "Loai san pham";
            mnuLoaiSanPham.Click += mnuLoaiSanPham_Click;
            // 
            // mnuHangSanXuat
            // 
            mnuHangSanXuat.Name = "mnuHangSanXuat";
            mnuHangSanXuat.Size = new Size(173, 22);
            mnuHangSanXuat.Text = "Hang san xuat";
            mnuHangSanXuat.Click += mnuHangSanXuat_Click;
            // 
            // mnuSanPham
            // 
            mnuSanPham.Name = "mnuSanPham";
            mnuSanPham.Size = new Size(173, 22);
            mnuSanPham.Text = "San pham";
            mnuSanPham.Click += mnuSanPham_Click;
            // 
            // mnuKhachHang
            // 
            mnuKhachHang.Name = "mnuKhachHang";
            mnuKhachHang.Size = new Size(173, 22);
            mnuKhachHang.Text = "Khach hang";
            mnuKhachHang.Click += mnuKhachHang_Click;
            // 
            // mnuNhanVien
            // 
            mnuNhanVien.Name = "mnuNhanVien";
            mnuNhanVien.Size = new Size(173, 22);
            mnuNhanVien.Text = "Nhan vien";
            mnuNhanVien.Click += mnuNhanVien_Click;
            // 
            // mnuHoaDon
            // 
            mnuHoaDon.Name = "mnuHoaDon";
            mnuHoaDon.Size = new Size(173, 22);
            mnuHoaDon.Text = "Hoa don ban hang";
            mnuHoaDon.Click += mnuHoaDon_Click;
            // 
            // mnuBaocaothongke
            // 
            mnuBaocaothongke.DropDownItems.AddRange(new ToolStripItem[] { mnuThongKeSanPham, mnuThongKeDoanhThu });
            mnuBaocaothongke.Name = "mnuBaocaothongke";
            mnuBaocaothongke.Size = new Size(121, 20);
            mnuBaocaothongke.Text = "Bao cao - Thong ke";
            // 
            // mnuThongKeSanPham
            // 
            mnuThongKeSanPham.Name = "mnuThongKeSanPham";
            mnuThongKeSanPham.Size = new Size(181, 22);
            mnuThongKeSanPham.Text = "Thong ke san pham";
            // 
            // mnuThongKeDoanhThu
            // 
            mnuThongKeDoanhThu.Name = "mnuThongKeDoanhThu";
            mnuThongKeDoanhThu.Size = new Size(181, 22);
            mnuThongKeDoanhThu.Text = "Thong ke doanh thu";
            // 
            // mnTrogiup
            // 
            mnTrogiup.DropDownItems.AddRange(new ToolStripItem[] { mnHuongdansudung, mnThongtinphanmem });
            mnTrogiup.Name = "mnTrogiup";
            mnTrogiup.Size = new Size(62, 20);
            mnTrogiup.Text = "Tro giup";
            // 
            // mnHuongdansudung
            // 
            mnHuongdansudung.Name = "mnHuongdansudung";
            mnHuongdansudung.Size = new Size(186, 22);
            mnHuongdansudung.Text = "Huong dan su dung";
            // 
            // mnThongtinphanmem
            // 
            mnThongtinphanmem.Name = "mnThongtinphanmem";
            mnThongtinphanmem.Size = new Size(186, 22);
            mnThongtinphanmem.Text = "Thong tin phan mem";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTrangThai, toolStripStatusLabel1, lblLienket });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblTrangThai
            // 
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(95, 17);
            lblTrangThai.Text = "Chua dang nhap";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(595, 17);
            toolStripStatusLabel1.Spring = true;
            // 
            // lblLienket
            // 
            lblLienket.IsLink = true;
            lblLienket.Name = "lblLienket";
            lblLienket.Size = new Size(95, 17);
            lblLienket.Text = "Copyright@2026";
            lblLienket.Click += lblLienket_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMain";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuHethong;
        private ToolStripMenuItem mnuDangNhap;
        private ToolStripMenuItem mnuDangXuat;
        private ToolStripMenuItem mnuDoiMatKhau;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuQuanly;
        private ToolStripMenuItem mnuLoaiSanPham;
        private ToolStripMenuItem mnuHangSanXuat;
        private ToolStripMenuItem mnuSanPham;
        private ToolStripMenuItem mnuBaocaothongke;
        private ToolStripMenuItem mnTrogiup;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblTrangThai;
        private ToolStripMenuItem mnuKhachHang;
        private ToolStripMenuItem mnuNhanVien;
        private ToolStripMenuItem mnuHoaDon;
        private ToolStripMenuItem mnuThongKeSanPham;
        private ToolStripMenuItem mnuThongKeDoanhThu;
        private ToolStripMenuItem mnHuongdansudung;
        private ToolStripMenuItem mnThongtinphanmem;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblLienket;
    }
}