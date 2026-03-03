using System.Windows.Forms;

namespace QuanLyBanHang.Forms
{
    partial class frmHoaDon
    {
        private System.ComponentModel.IContainer components = null;
        private GroupBox gbDanhSachHoaDon;
        private DataGridView dgvHoaDon;
        private Button btnLapHoaDon;
        private Button btnInHoaDon;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnTimKiem;
        private Button btnXuat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            gbDanhSachHoaDon = new GroupBox();
            dgvHoaDon = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoVaTenNhanVien = new DataGridViewTextBoxColumn();
            HoVaTenKhachHang = new DataGridViewTextBoxColumn();
            NgayLap = new DataGridViewTextBoxColumn();
            TongTienHoaDon = new DataGridViewTextBoxColumn();
            XemChiTiet = new DataGridViewLinkColumn();
            btnLapHoaDon = new Button();
            btnInHoaDon = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            btnTimKiem = new Button();
            btnXuat = new Button();
            btnNhap = new Button();
            gbDanhSachHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            SuspendLayout();
            // 
            // gbDanhSachHoaDon
            // 
            gbDanhSachHoaDon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbDanhSachHoaDon.Controls.Add(dgvHoaDon);
            gbDanhSachHoaDon.Location = new Point(12, 12);
            gbDanhSachHoaDon.Name = "gbDanhSachHoaDon";
            gbDanhSachHoaDon.Size = new Size(960, 320);
            gbDanhSachHoaDon.TabIndex = 0;
            gbDanhSachHoaDon.TabStop = false;
            gbDanhSachHoaDon.Text = "Danh sách hóa đơn";
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.AllowUserToDeleteRows = false;
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Columns.AddRange(new DataGridViewColumn[] { ID, HoVaTenNhanVien, HoVaTenKhachHang, NgayLap, TongTienHoaDon, XemChiTiet });
            dgvHoaDon.Dock = DockStyle.Fill;
            dgvHoaDon.Location = new Point(3, 19);
            dgvHoaDon.MultiSelect = false;
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.ReadOnly = true;
            dgvHoaDon.RowHeadersWidth = 51;
            dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoaDon.Size = new Size(954, 298);
            dgvHoaDon.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // HoVaTenNhanVien
            // 
            HoVaTenNhanVien.DataPropertyName = "HoVaTenNhanVien";
            HoVaTenNhanVien.HeaderText = "Nhân viên";
            HoVaTenNhanVien.MinimumWidth = 6;
            HoVaTenNhanVien.Name = "HoVaTenNhanVien";
            HoVaTenNhanVien.ReadOnly = true;
            // 
            // HoVaTenKhachHang
            // 
            HoVaTenKhachHang.DataPropertyName = "HoVaTenKhachHang";
            HoVaTenKhachHang.HeaderText = "Khách hàng";
            HoVaTenKhachHang.MinimumWidth = 6;
            HoVaTenKhachHang.Name = "HoVaTenKhachHang";
            HoVaTenKhachHang.ReadOnly = true;
            // 
            // NgayLap
            // 
            NgayLap.DataPropertyName = "NgayLap";
            NgayLap.HeaderText = "Ngày lập";
            NgayLap.MinimumWidth = 6;
            NgayLap.Name = "NgayLap";
            NgayLap.ReadOnly = true;
            // 
            // TongTienHoaDon
            // 
            TongTienHoaDon.DataPropertyName = "TongTienHoaDon";
            TongTienHoaDon.HeaderText = "Tổng tiền";
            TongTienHoaDon.MinimumWidth = 6;
            TongTienHoaDon.Name = "TongTienHoaDon";
            TongTienHoaDon.ReadOnly = true;
            // 
            // XemChiTiet
            // 
            XemChiTiet.DataPropertyName = "XemChiTiet";
            XemChiTiet.HeaderText = "Chi tiết";
            XemChiTiet.MinimumWidth = 6;
            XemChiTiet.Name = "XemChiTiet";
            XemChiTiet.ReadOnly = true;
            // 
            // btnLapHoaDon
            // 
            btnLapHoaDon.Location = new Point(12, 338);
            btnLapHoaDon.Name = "btnLapHoaDon";
            btnLapHoaDon.Size = new Size(135, 30);
            btnLapHoaDon.TabIndex = 1;
            btnLapHoaDon.Text = "Lập hóa đơn mới...";
            btnLapHoaDon.Click += btnLapHoaDon_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Location = new Point(152, 338);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(110, 30);
            btnInHoaDon.TabIndex = 2;
            btnInHoaDon.Text = "In hóa đơn...";
            // 
            // btnSua
            // 
            btnSua.Location = new Point(268, 338);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(90, 30);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa...";
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(363, 338);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(90, 30);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(458, 338);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(90, 30);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(650, 338);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(110, 30);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "Tìm kiếm...";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(766, 338);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(110, 30);
            btnXuat.TabIndex = 7;
            btnXuat.Text = "Xuất Excel...";
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(554, 335);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(90, 30);
            btnNhap.TabIndex = 8;
            btnNhap.Text = "Nhap";
            btnNhap.Click += btnNhap_Click;
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 381);
            Controls.Add(btnNhap);
            Controls.Add(gbDanhSachHoaDon);
            Controls.Add(btnLapHoaDon);
            Controls.Add(btnInHoaDon);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThoat);
            Controls.Add(btnTimKiem);
            Controls.Add(btnXuat);
            Name = "frmHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa đơn";
            Load += frmHoaDon_Load;
            gbDanhSachHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ResumeLayout(false);
        }

        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoVaTenNhanVien;
        private DataGridViewTextBoxColumn HoVaTenKhachHang;
        private DataGridViewTextBoxColumn NgayLap;
        private DataGridViewTextBoxColumn TongTienHoaDon;
        private DataGridViewLinkColumn XemChiTiet;
        private Button btnNhap;
    }
}
