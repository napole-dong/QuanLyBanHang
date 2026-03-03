namespace QuanLyBanHang.Forms
{
    partial class frmHangSanXuat
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
            groupBox1 = new GroupBox();
            btnNhap = new Button();
            btnXuat = new Button();
            txtTenHangSanXuat = new TextBox();
            btnLuu = new Button();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            lbTenHangSanXuat = new Label();
            gbDanhSachSX = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenHangSanXuat = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            gbDanhSachSX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(txtTenHangSanXuat);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(lbTenHangSanXuat);
            groupBox1.Location = new Point(0, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(984, 155);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thong Tin Hang San Xuat";
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(752, 104);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(75, 23);
            btnNhap.TabIndex = 8;
            btnNhap.Text = "Nhap";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(862, 104);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(75, 23);
            btnXuat.TabIndex = 7;
            btnXuat.Text = "Xuat";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // txtTenHangSanXuat
            // 
            txtTenHangSanXuat.Location = new Point(176, 61);
            txtTenHangSanXuat.Name = "txtTenHangSanXuat";
            txtTenHangSanXuat.Size = new Size(761, 23);
            txtTenHangSanXuat.TabIndex = 2;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(655, 104);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Luu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(557, 104);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(453, 104);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(75, 23);
            btnHuyBo.TabIndex = 4;
            btnHuyBo.Text = "Huy";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(361, 104);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(270, 104);
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
            // lbTenHangSanXuat
            // 
            lbTenHangSanXuat.AutoSize = true;
            lbTenHangSanXuat.Location = new Point(16, 69);
            lbTenHangSanXuat.Name = "lbTenHangSanXuat";
            lbTenHangSanXuat.Size = new Size(106, 15);
            lbTenHangSanXuat.TabIndex = 0;
            lbTenHangSanXuat.Text = "Ten Hang San Xuat";
            // 
            // gbDanhSachSX
            // 
            gbDanhSachSX.Controls.Add(dataGridView);
            gbDanhSachSX.Location = new Point(0, 171);
            gbDanhSachSX.Name = "gbDanhSachSX";
            gbDanhSachSX.Size = new Size(984, 368);
            gbDanhSachSX.TabIndex = 1;
            gbDanhSachSX.TabStop = false;
            gbDanhSachSX.Text = "Danh Sach Hang San Xuat";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenHangSanXuat });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 19);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(978, 346);
            dataGridView.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // TenHangSanXuat
            // 
            TenHangSanXuat.HeaderText = "Ten Hang San Xuat";
            TenHangSanXuat.MinimumWidth = 6;
            TenHangSanXuat.Name = "TenHangSanXuat";
            // 
            // frmHangSanXuat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 536);
            Controls.Add(gbDanhSachSX);
            Controls.Add(groupBox1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "frmHangSanXuat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmHangSanXuat";
            Load += frmHangSanXuat_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbDanhSachSX.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox gbDanhSachSX;
        private DataGridView dataGridView;
        private TextBox txtTenHangSanXuat;
        private Button btnLuu;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Label lbTenHangSanXuat;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenHangSanXuat;
        private Button btnNhap;
        private Button btnXuat;
    }
}