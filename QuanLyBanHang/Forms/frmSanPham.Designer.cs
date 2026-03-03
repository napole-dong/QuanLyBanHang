namespace QuanLyBanHang.Forms
{
    partial class frmSanPham
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
            btnXuat = new Button();
            btnNhap = new Button();
            btnTimKiem = new Button();
            btnLuu = new Button();
            btnThoat = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            gbDanhSachSX = new GroupBox();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            PhanLoai = new DataGridViewTextBoxColumn();
            HangSanXuat = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            numDonGia = new NumericUpDown();
            numSoLuong = new NumericUpDown();
            btnHuyBo = new Button();
            lbDonGia = new Label();
            label2 = new Label();
            btnDoiAnh = new Button();
            picHinhAnh = new PictureBox();
            txtMota = new TextBox();
            txtTenSanPham = new TextBox();
            lbTenSanPham = new Label();
            lbPhanLoai = new Label();
            cboHangSanXuat = new ComboBox();
            cboLoaiSanPham = new ComboBox();
            lbMoTaSanPham = new Label();
            label1 = new Label();
            gbDanhSachSX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            SuspendLayout();
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(783, 150);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(75, 23);
            btnXuat.TabIndex = 13;
            btnXuat.Text = "Xuat";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(703, 151);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(75, 23);
            btnNhap.TabIndex = 12;
            btnNhap.Text = "Nhap";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(622, 151);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 23);
            btnTimKiem.TabIndex = 11;
            btnTimKiem.Text = "Tim Kiem";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(381, 151);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Luu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(542, 150);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 24);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(220, 151);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(300, 151);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(139, 151);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 1;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // gbDanhSachSX
            // 
            gbDanhSachSX.Controls.Add(dataGridView1);
            gbDanhSachSX.Location = new Point(-1, 190);
            gbDanhSachSX.Name = "gbDanhSachSX";
            gbDanhSachSX.Size = new Size(984, 346);
            gbDanhSachSX.TabIndex = 5;
            gbDanhSachSX.TabStop = false;
            gbDanhSachSX.Text = "Danh Sach Khach Hang ";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, PhanLoai, HangSanXuat, TenSanPham, SoLuong, DonGia, HinhAnh });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 19);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(978, 324);
            dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // PhanLoai
            // 
            PhanLoai.HeaderText = "Phan Loai";
            PhanLoai.MinimumWidth = 6;
            PhanLoai.Name = "PhanLoai";
            // 
            // HangSanXuat
            // 
            HangSanXuat.HeaderText = "Hang San Xuat";
            HangSanXuat.MinimumWidth = 6;
            HangSanXuat.Name = "HangSanXuat";
            // 
            // TenSanPham
            // 
            TenSanPham.HeaderText = "Ten San Pham";
            TenSanPham.MinimumWidth = 6;
            TenSanPham.Name = "TenSanPham";
            // 
            // SoLuong
            // 
            SoLuong.HeaderText = "So Luong";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            DonGia.HeaderText = "DonGia";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            // 
            // HinhAnh
            // 
            HinhAnh.HeaderText = "Hinh Anh";
            HinhAnh.MinimumWidth = 6;
            HinhAnh.Name = "HinhAnh";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numDonGia);
            groupBox1.Controls.Add(numSoLuong);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(lbDonGia);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnDoiAnh);
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Controls.Add(txtMota);
            groupBox1.Controls.Add(txtTenSanPham);
            groupBox1.Controls.Add(lbTenSanPham);
            groupBox1.Controls.Add(lbPhanLoai);
            groupBox1.Controls.Add(cboHangSanXuat);
            groupBox1.Controls.Add(cboLoaiSanPham);
            groupBox1.Controls.Add(lbMoTaSanPham);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Location = new Point(-1, -1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(984, 191);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thong Tin San Pham";
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(458, 47);
            numDonGia.Margin = new Padding(3, 2, 3, 2);
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(131, 23);
            numDonGia.TabIndex = 29;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(458, 20);
            numSoLuong.Margin = new Padding(3, 2, 3, 2);
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(131, 23);
            numSoLuong.TabIndex = 28;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(461, 150);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(75, 23);
            btnHuyBo.TabIndex = 27;
            btnHuyBo.Text = "Huy Bo";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // lbDonGia
            // 
            lbDonGia.AutoSize = true;
            lbDonGia.Location = new Point(381, 53);
            lbDonGia.Name = "lbDonGia";
            lbDonGia.Size = new Size(49, 15);
            lbDonGia.TabIndex = 26;
            lbDonGia.Text = "Don Gia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(381, 25);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 25;
            label2.Text = "So Luong";
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Location = new Point(792, 18);
            btnDoiAnh.Margin = new Padding(3, 2, 3, 2);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(82, 22);
            btnDoiAnh.TabIndex = 24;
            btnDoiAnh.Text = "Doi Anh";
            btnDoiAnh.UseVisualStyleBackColor = true;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Location = new Point(645, 20);
            picHinhAnh.Margin = new Padding(3, 2, 3, 2);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(133, 112);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 23;
            picHinhAnh.TabStop = false;
            // 
            // txtMota
            // 
            txtMota.Location = new Point(139, 112);
            txtMota.Margin = new Padding(3, 2, 3, 2);
            txtMota.Name = "txtMota";
            txtMota.Size = new Size(475, 23);
            txtMota.TabIndex = 22;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(139, 80);
            txtTenSanPham.Margin = new Padding(3, 2, 3, 2);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(475, 23);
            txtTenSanPham.TabIndex = 21;
            // 
            // lbTenSanPham
            // 
            lbTenSanPham.AutoSize = true;
            lbTenSanPham.Location = new Point(23, 86);
            lbTenSanPham.Name = "lbTenSanPham";
            lbTenSanPham.Size = new Size(81, 15);
            lbTenSanPham.TabIndex = 20;
            lbTenSanPham.Text = "Ten San Pham";
            // 
            // lbPhanLoai
            // 
            lbPhanLoai.AutoSize = true;
            lbPhanLoai.Location = new Point(23, 25);
            lbPhanLoai.Name = "lbPhanLoai";
            lbPhanLoai.Size = new Size(59, 15);
            lbPhanLoai.TabIndex = 19;
            lbPhanLoai.Text = "Phan Loai";
            // 
            // cboHangSanXuat
            // 
            cboHangSanXuat.FormattingEnabled = true;
            cboHangSanXuat.Location = new Point(139, 47);
            cboHangSanXuat.Margin = new Padding(3, 2, 3, 2);
            cboHangSanXuat.Name = "cboHangSanXuat";
            cboHangSanXuat.Size = new Size(226, 23);
            cboHangSanXuat.TabIndex = 18;
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Location = new Point(139, 19);
            cboLoaiSanPham.Margin = new Padding(3, 2, 3, 2);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(226, 23);
            cboLoaiSanPham.TabIndex = 17;
            // 
            // lbMoTaSanPham
            // 
            lbMoTaSanPham.AutoSize = true;
            lbMoTaSanPham.Location = new Point(23, 118);
            lbMoTaSanPham.Name = "lbMoTaSanPham";
            lbMoTaSanPham.Size = new Size(95, 15);
            lbMoTaSanPham.TabIndex = 15;
            lbMoTaSanPham.Text = "Mo Ta San Pham";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 53);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 14;
            label1.Text = "Hang San Xuat";
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 536);
            Controls.Add(gbDanhSachSX);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSanPham";
            gbDanhSachSX.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
        private TextBox txtDienThoai;
        private Label lbDienThoai;
        private TextBox txtDiaChi;
        private Label lbDiaChi;
        private TextBox txtHoVaTen;
        private Button btnLuu;
        private Button btnThoat;
        private Button btnHuy;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Label lbHoVaTen;
        private GroupBox gbDanhSachSX;
        private GroupBox groupBox1;
        private Label label1;
        private Label lbMoTaSanPham;
        private ComboBox cboHangSanXuat;
        private ComboBox cboLoaiSanPham;
        private Label lbPhanLoai;
        private TextBox txtMota;
        private TextBox txtTenSanPham;
        private Label lbTenSanPham;
        private Label label2;
        private Button btnDoiAnh;
        private PictureBox picHinhAnh;
        private DataGridView dataGridView1;
        private NumericUpDown numDonGia;
        private NumericUpDown numSoLuong;
        private Button btnHuyBo;
        private Label lbDonGia;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn PhanLoai;
        private DataGridViewTextBoxColumn HangSanXuat;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn HinhAnh;
    }
}