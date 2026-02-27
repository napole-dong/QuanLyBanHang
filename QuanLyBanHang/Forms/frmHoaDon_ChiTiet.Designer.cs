namespace QuanLyBanHang.Forms
{
    partial class frmHoaDon_ChiTiet
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            grpThongTinHoaDon = new GroupBox();
            lblNhanVienLap = new Label();
            cboNhanVien = new ComboBox();
            lblKhachHang = new Label();
            cboKhachHang = new ComboBox();
            lblGhiChu = new Label();
            txtGhiChuHoaDon = new TextBox();
            grpChiTietHoaDon = new GroupBox();
            lblSanPham = new Label();
            cboSanPham = new ComboBox();
            lblDonGiaBan = new Label();
            numDonGiaBan = new NumericUpDown();
            lblSoLuongBan = new Label();
            numSoLuongBan = new NumericUpDown();
            btnXacNhanBan = new Button();
            btnXoa = new Button();
            dataGridView = new DataGridView();
            SanPhamID = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            DonGiaBan = new DataGridViewTextBoxColumn();
            SoLuongBan = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            btnLuuHoaDon = new Button();
            btnInHoaDon = new Button();
            btnThoat = new Button();
            grpThongTinHoaDon.SuspendLayout();
            grpChiTietHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // grpThongTinHoaDon
            // 
            grpThongTinHoaDon.Controls.Add(lblNhanVienLap);
            grpThongTinHoaDon.Controls.Add(cboNhanVien);
            grpThongTinHoaDon.Controls.Add(lblKhachHang);
            grpThongTinHoaDon.Controls.Add(cboKhachHang);
            grpThongTinHoaDon.Controls.Add(lblGhiChu);
            grpThongTinHoaDon.Controls.Add(txtGhiChuHoaDon);
            grpThongTinHoaDon.Location = new Point(16, 18);
            grpThongTinHoaDon.Margin = new Padding(4, 5, 4, 5);
            grpThongTinHoaDon.Name = "grpThongTinHoaDon";
            grpThongTinHoaDon.Padding = new Padding(4, 5, 4, 5);
            grpThongTinHoaDon.Size = new Size(1013, 154);
            grpThongTinHoaDon.TabIndex = 0;
            grpThongTinHoaDon.TabStop = false;
            grpThongTinHoaDon.Text = "Thông tin hóa đơn";
            // 
            // lblNhanVienLap
            // 
            lblNhanVienLap.AutoSize = true;
            lblNhanVienLap.Location = new Point(13, 38);
            lblNhanVienLap.Margin = new Padding(4, 0, 4, 0);
            lblNhanVienLap.Name = "lblNhanVienLap";
            lblNhanVienLap.Size = new Size(123, 20);
            lblNhanVienLap.TabIndex = 0;
            lblNhanVienLap.Text = "Nhân viên lập (*):";
            // 
            // cboNhanVien
            // 
            cboNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(147, 34);
            cboNhanVien.Margin = new Padding(4, 5, 4, 5);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(265, 28);
            cboNhanVien.TabIndex = 1;
            // 
            // lblKhachHang
            // 
            lblKhachHang.AutoSize = true;
            lblKhachHang.Location = new Point(467, 38);
            lblKhachHang.Margin = new Padding(4, 0, 4, 0);
            lblKhachHang.Name = "lblKhachHang";
            lblKhachHang.Size = new Size(89, 20);
            lblKhachHang.TabIndex = 2;
            lblKhachHang.Text = "Khách hàng:";
            // 
            // cboKhachHang
            // 
            cboKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(573, 34);
            cboKhachHang.Margin = new Padding(4, 5, 4, 5);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(265, 28);
            cboKhachHang.TabIndex = 3;
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Location = new Point(13, 92);
            lblGhiChu.Margin = new Padding(4, 0, 4, 0);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(120, 20);
            lblGhiChu.TabIndex = 4;
            lblGhiChu.Text = "Ghi chú hóa đơn:";
            // 
            // txtGhiChuHoaDon
            // 
            txtGhiChuHoaDon.Location = new Point(147, 88);
            txtGhiChuHoaDon.Margin = new Padding(4, 5, 4, 5);
            txtGhiChuHoaDon.Name = "txtGhiChuHoaDon";
            txtGhiChuHoaDon.Size = new Size(692, 27);
            txtGhiChuHoaDon.TabIndex = 5;
            // 
            // grpChiTietHoaDon
            // 
            grpChiTietHoaDon.Controls.Add(lblSanPham);
            grpChiTietHoaDon.Controls.Add(cboSanPham);
            grpChiTietHoaDon.Controls.Add(lblDonGiaBan);
            grpChiTietHoaDon.Controls.Add(numDonGiaBan);
            grpChiTietHoaDon.Controls.Add(lblSoLuongBan);
            grpChiTietHoaDon.Controls.Add(numSoLuongBan);
            grpChiTietHoaDon.Controls.Add(btnXacNhanBan);
            grpChiTietHoaDon.Controls.Add(btnXoa);
            grpChiTietHoaDon.Controls.Add(dataGridView);
            grpChiTietHoaDon.Location = new Point(16, 185);
            grpChiTietHoaDon.Margin = new Padding(4, 5, 4, 5);
            grpChiTietHoaDon.Name = "grpChiTietHoaDon";
            grpChiTietHoaDon.Padding = new Padding(4, 5, 4, 5);
            grpChiTietHoaDon.Size = new Size(1013, 462);
            grpChiTietHoaDon.TabIndex = 1;
            grpChiTietHoaDon.TabStop = false;
            grpChiTietHoaDon.Text = "Thông tin chi tiết hóa đơn";
            // 
            // lblSanPham
            // 
            lblSanPham.AutoSize = true;
            lblSanPham.Location = new Point(13, 38);
            lblSanPham.Margin = new Padding(4, 0, 4, 0);
            lblSanPham.Name = "lblSanPham";
            lblSanPham.Size = new Size(98, 20);
            lblSanPham.TabIndex = 0;
            lblSanPham.Text = "Sản phẩm (*):";
            // 
            // cboSanPham
            // 
            cboSanPham.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Location = new Point(120, 34);
            cboSanPham.Margin = new Padding(4, 5, 4, 5);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(239, 28);
            cboSanPham.TabIndex = 1;
            // 
            // lblDonGiaBan
            // 
            lblDonGiaBan.AutoSize = true;
            lblDonGiaBan.Location = new Point(371, 38);
            lblDonGiaBan.Margin = new Padding(4, 0, 4, 0);
            lblDonGiaBan.Name = "lblDonGiaBan";
            lblDonGiaBan.Size = new Size(114, 20);
            lblDonGiaBan.TabIndex = 2;
            lblDonGiaBan.Text = "Đơn giá bán (*):";
            // 
            // numDonGiaBan
            // 
            numDonGiaBan.Location = new Point(493, 34);
            numDonGiaBan.Margin = new Padding(4, 5, 4, 5);
            numDonGiaBan.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGiaBan.Name = "numDonGiaBan";
            numDonGiaBan.Size = new Size(133, 27);
            numDonGiaBan.TabIndex = 3;
            numDonGiaBan.ThousandsSeparator = true;
            // 
            // lblSoLuongBan
            // 
            lblSoLuongBan.AutoSize = true;
            lblSoLuongBan.Location = new Point(636, 37);
            lblSoLuongBan.Margin = new Padding(4, 0, 4, 0);
            lblSoLuongBan.Name = "lblSoLuongBan";
            lblSoLuongBan.Size = new Size(121, 20);
            lblSoLuongBan.TabIndex = 4;
            lblSoLuongBan.Text = "Số lượng bán (*):";
            // 
            // numSoLuongBan
            // 
            numSoLuongBan.Location = new Point(760, 34);
            numSoLuongBan.Margin = new Padding(4, 5, 4, 5);
            numSoLuongBan.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuongBan.Name = "numSoLuongBan";
            numSoLuongBan.Size = new Size(80, 27);
            numSoLuongBan.TabIndex = 5;
            numSoLuongBan.ThousandsSeparator = true;
            // 
            // btnXacNhanBan
            // 
            btnXacNhanBan.Location = new Point(853, 31);
            btnXacNhanBan.Margin = new Padding(4, 5, 4, 5);
            btnXacNhanBan.Name = "btnXacNhanBan";
            btnXacNhanBan.Size = new Size(120, 35);
            btnXacNhanBan.TabIndex = 6;
            btnXacNhanBan.Text = "Xác nhận bán";
            btnXacNhanBan.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(853, 77);
            btnXoa.Margin = new Padding(4, 5, 4, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(120, 35);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { SanPhamID, TenSanPham, DonGiaBan, SoLuongBan, ThanhTien });
            dataGridView.Location = new Point(13, 123);
            dataGridView.Margin = new Padding(4, 5, 4, 5);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(960, 323);
            dataGridView.TabIndex = 8;
            // 
            // SanPhamID
            // 
            SanPhamID.DataPropertyName = "SanPhamID";
            SanPhamID.HeaderText = "ID";
            SanPhamID.MinimumWidth = 6;
            SanPhamID.Name = "SanPhamID";
            SanPhamID.ReadOnly = true;
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.HeaderText = "Tên sản phẩm";
            TenSanPham.MinimumWidth = 6;
            TenSanPham.Name = "TenSanPham";
            TenSanPham.ReadOnly = true;
            // 
            // DonGiaBan
            // 
            DonGiaBan.DataPropertyName = "DonGiaBan";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            DonGiaBan.DefaultCellStyle = dataGridViewCellStyle1;
            DonGiaBan.HeaderText = "Đơn giá bán";
            DonGiaBan.MinimumWidth = 6;
            DonGiaBan.Name = "DonGiaBan";
            DonGiaBan.ReadOnly = true;
            // 
            // SoLuongBan
            // 
            SoLuongBan.DataPropertyName = "SoLuongBan";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            SoLuongBan.DefaultCellStyle = dataGridViewCellStyle2;
            SoLuongBan.HeaderText = "Số lượng bán";
            SoLuongBan.MinimumWidth = 6;
            SoLuongBan.Name = "SoLuongBan";
            SoLuongBan.ReadOnly = true;
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Blue;
            dataGridViewCellStyle3.Format = "N0";
            ThanhTien.DefaultCellStyle = dataGridViewCellStyle3;
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            ThanhTien.ReadOnly = true;
            // 
            // btnLuuHoaDon
            // 
            btnLuuHoaDon.Location = new Point(347, 662);
            btnLuuHoaDon.Margin = new Padding(4, 5, 4, 5);
            btnLuuHoaDon.Name = "btnLuuHoaDon";
            btnLuuHoaDon.Size = new Size(133, 46);
            btnLuuHoaDon.TabIndex = 2;
            btnLuuHoaDon.Text = "Lưu hóa đơn";
            btnLuuHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Location = new Point(493, 662);
            btnInHoaDon.Margin = new Padding(4, 5, 4, 5);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(133, 46);
            btnInHoaDon.TabIndex = 3;
            btnInHoaDon.Text = "In hóa đơn...";
            btnInHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(640, 662);
            btnThoat.Margin = new Padding(4, 5, 4, 5);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(133, 46);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // frmHoaDon_ChiTiet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 740);
            Controls.Add(btnThoat);
            Controls.Add(btnInHoaDon);
            Controls.Add(btnLuuHoaDon);
            Controls.Add(grpChiTietHoaDon);
            Controls.Add(grpThongTinHoaDon);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmHoaDon_ChiTiet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa đơn chi tiết";
            grpThongTinHoaDon.ResumeLayout(false);
            grpThongTinHoaDon.PerformLayout();
            grpChiTietHoaDon.ResumeLayout(false);
            grpChiTietHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpThongTinHoaDon;
        private System.Windows.Forms.Label lblNhanVienLap;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChuHoaDon;
        private System.Windows.Forms.GroupBox grpChiTietHoaDon;
        private System.Windows.Forms.Label lblSanPham;
        private System.Windows.Forms.ComboBox cboSanPham;
        private System.Windows.Forms.Label lblDonGiaBan;
        private System.Windows.Forms.NumericUpDown numDonGiaBan;
        private System.Windows.Forms.Label lblSoLuongBan;
        private System.Windows.Forms.NumericUpDown numSoLuongBan;
        private System.Windows.Forms.Button btnXacNhanBan;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SanPhamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Button btnLuuHoaDon;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnThoat;
    }
}
