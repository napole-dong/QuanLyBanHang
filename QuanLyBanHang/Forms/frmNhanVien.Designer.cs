namespace QuanLyBanHang.Forms
{
    partial class frmNhanVien
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
            txtDienThoai = new TextBox();
            lbDienThoai = new Label();
            txtDiaChi = new TextBox();
            lbDiaChi = new Label();
            txtHoVaTen = new TextBox();
            btnLuu = new Button();
            btnThoat = new Button();
            btnHuy = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            lbHoVaTen = new Label();
            groupBox1 = new GroupBox();
            cboQuyenHan = new ComboBox();
            lbQuyen = new Label();
            txtMatKhau = new TextBox();
            lbMatKhau = new Label();
            txtTenDangNhap = new TextBox();
            lbTenDangNhap = new Label();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            QuyenHan = new DataGridViewTextBoxColumn();
            gbDanhSachSX = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            gbDanhSachSX.SuspendLayout();
            SuspendLayout();
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(852, 95);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(75, 23);
            btnXuat.TabIndex = 13;
            btnXuat.Text = "Xuat";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(852, 66);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(75, 23);
            btnNhap.TabIndex = 12;
            btnNhap.Text = "Nhap";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(852, 39);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 23);
            btnTimKiem.TabIndex = 11;
            btnTimKiem.Text = "Tim Kiem";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(475, 39);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(186, 23);
            txtDienThoai.TabIndex = 10;
            // 
            // lbDienThoai
            // 
            lbDienThoai.AutoSize = true;
            lbDienThoai.Location = new Point(406, 43);
            lbDienThoai.Name = "lbDienThoai";
            lbDienThoai.Size = new Size(63, 15);
            lbDienThoai.TabIndex = 9;
            lbDienThoai.Text = "Dien Thoai";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(148, 98);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(252, 23);
            txtDiaChi.TabIndex = 8;
            // 
            // lbDiaChi
            // 
            lbDiaChi.AutoSize = true;
            lbDiaChi.Location = new Point(13, 106);
            lbDiaChi.Name = "lbDiaChi";
            lbDiaChi.Size = new Size(45, 15);
            lbDiaChi.TabIndex = 7;
            lbDiaChi.Text = "Dia Chi";
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(148, 39);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(252, 23);
            txtHoVaTen.TabIndex = 2;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(750, 96);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Luu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(669, 96);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 24);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(669, 68);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(75, 23);
            btnHuy.TabIndex = 4;
            btnHuy.Text = "Huy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(750, 68);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(750, 39);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(669, 39);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 1;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // lbHoVaTen
            // 
            lbHoVaTen.AutoSize = true;
            lbHoVaTen.Location = new Point(13, 42);
            lbHoVaTen.Name = "lbHoVaTen";
            lbHoVaTen.Size = new Size(59, 15);
            lbHoVaTen.TabIndex = 0;
            lbHoVaTen.Text = "Ho Va Ten";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboQuyenHan);
            groupBox1.Controls.Add(lbQuyen);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(lbMatKhau);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(lbTenDangNhap);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(lbDienThoai);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(lbDiaChi);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(lbHoVaTen);
            groupBox1.Location = new Point(-1, -1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(984, 155);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thong Tin Khach Hang";
            // 
            // cboQuyenHan
            // 
            cboQuyenHan.FormattingEnabled = true;
            cboQuyenHan.Items.AddRange(new object[] { "Quan Li", "Nhan Vien" });
            cboQuyenHan.Location = new Point(475, 97);
            cboQuyenHan.Name = "cboQuyenHan";
            cboQuyenHan.Size = new Size(186, 23);
            cboQuyenHan.TabIndex = 19;
            // 
            // lbQuyen
            // 
            lbQuyen.AutoSize = true;
            lbQuyen.Location = new Point(406, 102);
            lbQuyen.Name = "lbQuyen";
            lbQuyen.Size = new Size(67, 15);
            lbQuyen.TabIndex = 18;
            lbQuyen.Text = "Quyen Han";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(475, 69);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(186, 23);
            txtMatKhau.TabIndex = 17;
            // 
            // lbMatKhau
            // 
            lbMatKhau.AutoSize = true;
            lbMatKhau.Location = new Point(406, 73);
            lbMatKhau.Name = "lbMatKhau";
            lbMatKhau.Size = new Size(58, 15);
            lbMatKhau.TabIndex = 16;
            lbMatKhau.Text = "Mat Khau";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(148, 69);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(252, 23);
            txtTenDangNhap.TabIndex = 15;
            // 
            // lbTenDangNhap
            // 
            lbTenDangNhap.AutoSize = true;
            lbTenDangNhap.Location = new Point(13, 77);
            lbTenDangNhap.Name = "lbTenDangNhap";
            lbTenDangNhap.Size = new Size(88, 15);
            lbTenDangNhap.TabIndex = 14;
            lbTenDangNhap.Text = "Ten Dang Nhap";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, HoVaTen, DienThoai, DiaChi, TenDangNhap, QuyenHan });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 19);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(978, 346);
            dataGridView.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // HoVaTen
            // 
            HoVaTen.HeaderText = "Ho Va Ten";
            HoVaTen.Name = "HoVaTen";
            // 
            // DienThoai
            // 
            DienThoai.HeaderText = "Dien Thoai";
            DienThoai.Name = "DienThoai";
            // 
            // DiaChi
            // 
            DiaChi.HeaderText = "Dia Chi";
            DiaChi.Name = "DiaChi";
            // 
            // TenDangNhap
            // 
            TenDangNhap.HeaderText = "Ten Dang Nhap";
            TenDangNhap.Name = "TenDangNhap";
            // 
            // QuyenHan
            // 
            QuyenHan.HeaderText = "QuyenHan";
            QuyenHan.Name = "QuyenHan";
            // 
            // gbDanhSachSX
            // 
            gbDanhSachSX.Controls.Add(dataGridView);
            gbDanhSachSX.Location = new Point(-1, 169);
            gbDanhSachSX.Name = "gbDanhSachSX";
            gbDanhSachSX.Size = new Size(984, 368);
            gbDanhSachSX.TabIndex = 5;
            gbDanhSachSX.TabStop = false;
            gbDanhSachSX.Text = "Danh Sach Khach Hang ";
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 536);
            Controls.Add(groupBox1);
            Controls.Add(gbDanhSachSX);
            Name = "frmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmNhanVien";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            gbDanhSachSX.ResumeLayout(false);
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
        private GroupBox groupBox1;
        private TextBox txtTenDangNhap;
        private Label lbTenDangNhap;
        private DataGridView dataGridView;
        private GroupBox gbDanhSachSX;
        private Label lbQuyen;
        private TextBox txtMatKhau;
        private Label lbMatKhau;
        private ComboBox cboQuyenHan;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn QuyenHan;
    }
}