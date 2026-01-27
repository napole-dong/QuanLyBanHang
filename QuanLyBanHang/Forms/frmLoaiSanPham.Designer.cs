namespace QuanLyBanHang.Forms
{
    partial class frmLoaiSanPham
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
            dataGridView = new DataGridView();
            gbDanhSachLoai = new GroupBox();
            groupBox = new GroupBox();
            txtTenLoai = new TextBox();
            btnLuu = new Button();
            btnThoat = new Button();
            btnHuy = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            lbTenLoai = new Label();
            ID = new DataGridViewTextBoxColumn();
            TenLoaiSanPham = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            gbDanhSachLoai.SuspendLayout();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenLoaiSanPham });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 19);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(978, 346);
            dataGridView.TabIndex = 0;
            // 
            // gbDanhSachLoai
            // 
            gbDanhSachLoai.Controls.Add(dataGridView);
            gbDanhSachLoai.Location = new Point(-1, 169);
            gbDanhSachLoai.Name = "gbDanhSachLoai";
            gbDanhSachLoai.Size = new Size(984, 368);
            gbDanhSachLoai.TabIndex = 3;
            gbDanhSachLoai.TabStop = false;
            gbDanhSachLoai.Text = "Danh Sach Loai San Pham";
            // 
            // groupBox
            // 
            groupBox.Controls.Add(txtTenLoai);
            groupBox.Controls.Add(btnLuu);
            groupBox.Controls.Add(btnThoat);
            groupBox.Controls.Add(btnHuy);
            groupBox.Controls.Add(btnSua);
            groupBox.Controls.Add(btnXoa);
            groupBox.Controls.Add(btnThem);
            groupBox.Controls.Add(lbTenLoai);
            groupBox.Location = new Point(-1, -1);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(984, 155);
            groupBox.TabIndex = 2;
            groupBox.TabStop = false;
            groupBox.Text = "Thong Tin Loai San Pham";
            // 
            // txtTenLoai
            // 
            txtTenLoai.Location = new Point(176, 61);
            txtTenLoai.Name = "txtTenLoai";
            txtTenLoai.Size = new Size(761, 23);
            txtTenLoai.TabIndex = 2;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(862, 104);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Luu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(733, 104);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(589, 104);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(75, 23);
            btnHuy.TabIndex = 4;
            btnHuy.Text = "Huy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(443, 104);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(309, 104);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(176, 104);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 1;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // lbTenLoai
            // 
            lbTenLoai.AutoSize = true;
            lbTenLoai.Location = new Point(16, 69);
            lbTenLoai.Name = "lbTenLoai";
            lbTenLoai.Size = new Size(106, 15);
            lbTenLoai.TabIndex = 0;
            lbTenLoai.Text = "Ten Loai San Pham";
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // TenLoaiSanPham
            // 
            TenLoaiSanPham.HeaderText = "Ten Loai San Pham";
            TenLoaiSanPham.Name = "TenLoaiSanPham";
            // 
            // frmLoaiSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 536);
            Controls.Add(gbDanhSachLoai);
            Controls.Add(groupBox);
            Name = "frmLoaiSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLoaiSanPham";
            Load += frmLoaiSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            gbDanhSachLoai.ResumeLayout(false);
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn TenHangSanXuat;
        private GroupBox gbDanhSachLoai;
        private GroupBox groupBox;
        private TextBox txtTenLoai;
        private Button btnLuu;
        private Button btnThoat;
        private Button btnHuy;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Label lbTenLoai;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenLoaiSanPham;
    }
}