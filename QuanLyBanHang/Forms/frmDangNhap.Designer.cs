namespace QuanLyBanHang.Forms
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            btnDangnhap = new Button();
            btnHuybo = new Button();
            txtTendangnhap = new TextBox();
            txtMatkhau = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lbdangnhap = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnDangnhap
            // 
            btnDangnhap.Location = new Point(12, 137);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(75, 23);
            btnDangnhap.TabIndex = 0;
            btnDangnhap.Text = "Dang Nhap";
            btnDangnhap.UseVisualStyleBackColor = true;
            btnDangnhap.Click += btnDangnhap_Click;
            // 
            // btnHuybo
            // 
            btnHuybo.Location = new Point(85, 60);
            btnHuybo.Name = "btnHuybo";
            btnHuybo.Size = new Size(88, 23);
            btnHuybo.TabIndex = 1;
            btnHuybo.Text = "Huy Bo";
            btnHuybo.UseVisualStyleBackColor = true;
            btnHuybo.Click += btnHuybo_Click;
            // 
            // txtTendangnhap
            // 
            txtTendangnhap.Location = new Point(85, 108);
            txtTendangnhap.Name = "txtTendangnhap";
            txtTendangnhap.Size = new Size(153, 23);
            txtTendangnhap.TabIndex = 2;
            // 
            // txtMatkhau
            // 
            txtMatkhau.Location = new Point(12, 31);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.PasswordChar = '*';
            txtMatkhau.Size = new Size(148, 23);
            txtMatkhau.TabIndex = 3;
            txtMatkhau.KeyDown += txtMatkhau_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 90);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 4;
            label1.Text = "Ten Dang Nhap";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 16);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 5;
            label2.Text = "Mat Khau";
            // 
            // lbdangnhap
            // 
            lbdangnhap.AutoSize = true;
            lbdangnhap.FlatStyle = FlatStyle.System;
            lbdangnhap.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbdangnhap.Location = new Point(139, 0);
            lbdangnhap.Name = "lbdangnhap";
            lbdangnhap.Size = new Size(111, 21);
            lbdangnhap.TabIndex = 6;
            lbdangnhap.Text = "DANG NHAP";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 190);
            Controls.Add(pictureBox1);
            Controls.Add(lbdangnhap);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMatkhau);
            Controls.Add(txtTendangnhap);
            Controls.Add(btnHuybo);
            Controls.Add(btnDangnhap);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dang Nhap";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDangnhap;
        private Button btnHuybo;
        private Label label1;
        private Label label2;
        public TextBox txtTendangnhap;
        public TextBox txtMatkhau;
        private Label lbdangnhap;
        private PictureBox pictureBox1;
    }
}