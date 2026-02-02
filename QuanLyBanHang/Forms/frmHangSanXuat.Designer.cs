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
            groupBox1.Controls.Add(txtTenHangSanXuat);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(lbTenHangSanXuat);
            groupBox1.Location = new Point(0, 1);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1125, 207);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thong Tin Hang San Xuat";
            // 
            // txtTenHangSanXuat
            // 
            txtTenHangSanXuat.Location = new Point(201, 81);
            txtTenHangSanXuat.Margin = new Padding(3, 4, 3, 4);
            txtTenHangSanXuat.Name = "txtTenHangSanXuat";
            txtTenHangSanXuat.Size = new Size(869, 27);
            txtTenHangSanXuat.TabIndex = 2;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(985, 139);
            btnLuu.Margin = new Padding(3, 4, 3, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(86, 31);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Luu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(838, 139);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(86, 31);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(673, 139);
            btnHuyBo.Margin = new Padding(3, 4, 3, 4);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(86, 31);
            btnHuyBo.TabIndex = 4;
            btnHuyBo.Text = "Huy";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(506, 139);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(86, 31);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(353, 139);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(86, 31);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(201, 139);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(86, 31);
            btnThem.TabIndex = 1;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // lbTenHangSanXuat
            // 
            lbTenHangSanXuat.AutoSize = true;
            lbTenHangSanXuat.Location = new Point(18, 92);
            lbTenHangSanXuat.Name = "lbTenHangSanXuat";
            lbTenHangSanXuat.Size = new Size(134, 20);
            lbTenHangSanXuat.TabIndex = 0;
            lbTenHangSanXuat.Text = "Ten Hang San Xuat";
            // 
            // gbDanhSachSX
            // 
            gbDanhSachSX.Controls.Add(dataGridView);
            gbDanhSachSX.Location = new Point(0, 228);
            gbDanhSachSX.Margin = new Padding(3, 4, 3, 4);
            gbDanhSachSX.Name = "gbDanhSachSX";
            gbDanhSachSX.Padding = new Padding(3, 4, 3, 4);
            gbDanhSachSX.Size = new Size(1125, 491);
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
            dataGridView.Location = new Point(3, 24);
            dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1119, 463);
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 715);
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
    }
}