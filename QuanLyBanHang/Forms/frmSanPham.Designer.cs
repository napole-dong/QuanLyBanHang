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
            groupBox1 = new GroupBox();
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
            lbDonGia = new Label();
            btnHuyBo = new Button();
            numSoLuong = new NumericUpDown();
            numDonGia = new NumericUpDown();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            PhanLoai = new DataGridViewTextBoxColumn();
            HangSanXuat = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewTextBoxColumn();
            gbDanhSachSX.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(895, 200);
            btnXuat.Margin = new Padding(3, 4, 3, 4);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(86, 31);
            btnXuat.TabIndex = 13;
            btnXuat.Text = "Xuat";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(803, 201);
            btnNhap.Margin = new Padding(3, 4, 3, 4);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(86, 31);
            btnNhap.TabIndex = 12;
            btnNhap.Text = "Nhap";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(711, 201);
            btnTimKiem.Margin = new Padding(3, 4, 3, 4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(86, 31);
            btnTimKiem.TabIndex = 11;
            btnTimKiem.Text = "Tim Kiem";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(435, 201);
            btnLuu.Margin = new Padding(3, 4, 3, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(86, 31);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Luu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(619, 200);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(86, 32);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(251, 201);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(86, 31);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(343, 201);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(86, 31);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(159, 201);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(86, 31);
            btnThem.TabIndex = 1;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // gbDanhSachSX
            // 
            gbDanhSachSX.Controls.Add(dataGridView1);
            gbDanhSachSX.Location = new Point(-1, 254);
            gbDanhSachSX.Margin = new Padding(3, 4, 3, 4);
            gbDanhSachSX.Name = "gbDanhSachSX";
            gbDanhSachSX.Padding = new Padding(3, 4, 3, 4);
            gbDanhSachSX.Size = new Size(1125, 462);
            gbDanhSachSX.TabIndex = 5;
            gbDanhSachSX.TabStop = false;
            gbDanhSachSX.Text = "Danh Sach Khach Hang ";
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
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1125, 255);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thong Tin San Pham";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(435, 33);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 25;
            label2.Text = "So Luong";
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Location = new Point(905, 24);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(94, 29);
            btnDoiAnh.TabIndex = 24;
            btnDoiAnh.Text = "Doi Anh";
            btnDoiAnh.UseVisualStyleBackColor = true;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Location = new Point(737, 27);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(152, 150);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 23;
            picHinhAnh.TabStop = false;
            // 
            // txtMota
            // 
            txtMota.Location = new Point(159, 150);
            txtMota.Name = "txtMota";
            txtMota.Size = new Size(542, 27);
            txtMota.TabIndex = 22;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(159, 107);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(542, 27);
            txtTenSanPham.TabIndex = 21;
            // 
            // lbTenSanPham
            // 
            lbTenSanPham.AutoSize = true;
            lbTenSanPham.Location = new Point(26, 114);
            lbTenSanPham.Name = "lbTenSanPham";
            lbTenSanPham.Size = new Size(101, 20);
            lbTenSanPham.TabIndex = 20;
            lbTenSanPham.Text = "Ten San Pham";
            // 
            // lbPhanLoai
            // 
            lbPhanLoai.AutoSize = true;
            lbPhanLoai.Location = new Point(26, 33);
            lbPhanLoai.Name = "lbPhanLoai";
            lbPhanLoai.Size = new Size(73, 20);
            lbPhanLoai.TabIndex = 19;
            lbPhanLoai.Text = "Phan Loai";
            // 
            // cboHangSanXuat
            // 
            cboHangSanXuat.FormattingEnabled = true;
            cboHangSanXuat.Location = new Point(159, 63);
            cboHangSanXuat.Name = "cboHangSanXuat";
            cboHangSanXuat.Size = new Size(258, 28);
            cboHangSanXuat.TabIndex = 18;
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Location = new Point(159, 25);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(258, 28);
            cboLoaiSanPham.TabIndex = 17;
            // 
            // lbMoTaSanPham
            // 
            lbMoTaSanPham.AutoSize = true;
            lbMoTaSanPham.Location = new Point(26, 157);
            lbMoTaSanPham.Name = "lbMoTaSanPham";
            lbMoTaSanPham.Size = new Size(118, 20);
            lbMoTaSanPham.TabIndex = 15;
            lbMoTaSanPham.Text = "Mo Ta San Pham";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 71);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 14;
            label1.Text = "Hang San Xuat";
            // 
            // lbDonGia
            // 
            lbDonGia.AutoSize = true;
            lbDonGia.Location = new Point(435, 71);
            lbDonGia.Name = "lbDonGia";
            lbDonGia.Size = new Size(63, 20);
            lbDonGia.TabIndex = 26;
            lbDonGia.Text = "Don Gia";
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(527, 200);
            btnHuyBo.Margin = new Padding(3, 4, 3, 4);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(86, 31);
            btnHuyBo.TabIndex = 27;
            btnHuyBo.Text = "Huy Bo";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(524, 26);
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(150, 27);
            numSoLuong.TabIndex = 28;
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(524, 63);
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(150, 27);
            numDonGia.TabIndex = 29;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, PhanLoai, HangSanXuat, TenSanPham, SoLuong, DonGia, HinhAnh });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 24);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1119, 434);
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
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 715);
            Controls.Add(gbDanhSachSX);
            Controls.Add(groupBox1);
            Name = "frmSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSanPham";
            gbDanhSachSX.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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