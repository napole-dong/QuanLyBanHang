namespace QuanLyBanHang.Forms
{
    partial class frmKhachHang
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
            gbDanhSachSX = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
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
            gbDanhSachSX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gbDanhSachSX
            // 
            gbDanhSachSX.Controls.Add(dataGridView);
            gbDanhSachSX.Location = new Point(-1, 169);
            gbDanhSachSX.Name = "gbDanhSachSX";
            gbDanhSachSX.Size = new Size(984, 368);
            gbDanhSachSX.TabIndex = 3;
            gbDanhSachSX.TabStop = false;
            gbDanhSachSX.Text = "Danh Sach Khach Hang ";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, HoVaTen, DienThoai, DiaChi });
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
            // groupBox1
            // 
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
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thong Tin Khach Hang";
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
            txtDiaChi.Location = new Point(148, 96);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(513, 23);
            txtDiaChi.TabIndex = 8;
            // 
            // lbDiaChi
            // 
            lbDiaChi.AutoSize = true;
            lbDiaChi.Location = new Point(13, 104);
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
            btnThoat.Click += btnThoat_Click;
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
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 536);
            Controls.Add(gbDanhSachSX);
            Controls.Add(groupBox1);
            Name = "frmKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmKhachHang";
            gbDanhSachSX.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbDanhSachSX;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn DiaChi;
        private GroupBox groupBox1;
        private TextBox txtHoVaTen;
        private Button btnLuu;
        private Button btnThoat;
        private Button btnHuy;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Label lbHoVaTen;
        private TextBox txtDienThoai;
        private Label lbDienThoai;
        private TextBox txtDiaChi;
        private Label lbDiaChi;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
    }
}