namespace BookStore
{
    partial class FrmHome
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
            this.dtgvSach = new System.Windows.Forms.DataGridView();
            this.dtgvSPK = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiemTL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.txtTimKH = new System.Windows.Forms.TextBox();
            this.btnTimKH = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaKHinHD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtDonGiaSach = new System.Windows.Forms.TextBox();
            this.txtSoLuongSach = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnThemHD = new System.Windows.Forms.Button();
            this.btnThemSachinHD = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtDonGiaSP = new System.Windows.Forms.TextBox();
            this.txtSoLuongSP = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnThemSPinHD = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSPK)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvSach
            // 
            this.dtgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSach.Location = new System.Drawing.Point(29, 56);
            this.dtgvSach.Name = "dtgvSach";
            this.dtgvSach.RowHeadersWidth = 51;
            this.dtgvSach.RowTemplate.Height = 24;
            this.dtgvSach.Size = new System.Drawing.Size(765, 360);
            this.dtgvSach.TabIndex = 0;
            this.dtgvSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSach_CellClick);
            // 
            // dtgvSPK
            // 
            this.dtgvSPK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSPK.Location = new System.Drawing.Point(29, 443);
            this.dtgvSPK.Name = "dtgvSPK";
            this.dtgvSPK.RowHeadersWidth = 51;
            this.dtgvSPK.RowTemplate.Height = 24;
            this.dtgvSPK.Size = new System.Drawing.Size(765, 352);
            this.dtgvSPK.TabIndex = 1;
            this.dtgvSPK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSPK_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(798, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(988, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Điểm tích luỹ";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(829, 116);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(117, 22);
            this.txtMaKH.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(826, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã Khách Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(988, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên Khách Hàng";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(991, 116);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(168, 22);
            this.txtTenKH.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(826, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số điện thoại";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(829, 173);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(117, 22);
            this.txtSDT.TabIndex = 9;
            // 
            // txtDiemTL
            // 
            this.txtDiemTL.Location = new System.Drawing.Point(991, 173);
            this.txtDiemTL.Name = "txtDiemTL";
            this.txtDiemTL.Size = new System.Drawing.Size(117, 22);
            this.txtDiemTL.TabIndex = 10;
            this.txtDiemTL.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(801, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "HOÁ ĐƠN";
            // 
            // btnThemKH
            // 
            this.btnThemKH.Location = new System.Drawing.Point(1140, 173);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(75, 23);
            this.btnThemKH.TabIndex = 12;
            this.btnThemKH.Text = "Thêm KH";
            this.btnThemKH.UseVisualStyleBackColor = true;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // txtTimKH
            // 
            this.txtTimKH.Location = new System.Drawing.Point(974, 53);
            this.txtTimKH.Name = "txtTimKH";
            this.txtTimKH.Size = new System.Drawing.Size(168, 22);
            this.txtTimKH.TabIndex = 13;
            // 
            // btnTimKH
            // 
            this.btnTimKH.Location = new System.Drawing.Point(1155, 52);
            this.btnTimKH.Name = "btnTimKH";
            this.btnTimKH.Size = new System.Drawing.Size(75, 23);
            this.btnTimKH.TabIndex = 14;
            this.btnTimKH.Text = "Tìm KH";
            this.btnTimKH.UseVisualStyleBackColor = true;
            this.btnTimKH.Click += new System.EventHandler(this.btnTimKH_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(826, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Mã Hoá Đơn";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(829, 307);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(117, 22);
            this.txtMaHD.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(967, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Mã Khách Hàng";
            // 
            // txtMaKHinHD
            // 
            this.txtMaKHinHD.Location = new System.Drawing.Point(970, 307);
            this.txtMaKHinHD.Name = "txtMaKHinHD";
            this.txtMaKHinHD.Size = new System.Drawing.Size(117, 22);
            this.txtMaKHinHD.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1113, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Mã Nhân Viên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(1116, 307);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(117, 22);
            this.txtMaNV.TabIndex = 20;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(829, 465);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(117, 22);
            this.txtMaSach.TabIndex = 21;
            // 
            // txtDonGiaSach
            // 
            this.txtDonGiaSach.Location = new System.Drawing.Point(970, 465);
            this.txtDonGiaSach.Name = "txtDonGiaSach";
            this.txtDonGiaSach.Size = new System.Drawing.Size(117, 22);
            this.txtDonGiaSach.TabIndex = 22;
            // 
            // txtSoLuongSach
            // 
            this.txtSoLuongSach.Location = new System.Drawing.Point(1113, 465);
            this.txtSoLuongSach.Name = "txtSoLuongSach";
            this.txtSoLuongSach.Size = new System.Drawing.Size(117, 22);
            this.txtSoLuongSach.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(798, 372);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 32);
            this.label10.TabIndex = 24;
            this.label10.Text = "Sách";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(826, 425);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "Mã Sách";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(967, 425);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "Đơn Giá Sách";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1110, 425);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 16);
            this.label13.TabIndex = 27;
            this.label13.Text = "Số Lượng";
            // 
            // btnThemHD
            // 
            this.btnThemHD.Location = new System.Drawing.Point(1116, 352);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(88, 23);
            this.btnThemHD.TabIndex = 28;
            this.btnThemHD.Text = "Thêm HD";
            this.btnThemHD.UseVisualStyleBackColor = true;
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // btnThemSachinHD
            // 
            this.btnThemSachinHD.Location = new System.Drawing.Point(1116, 512);
            this.btnThemSachinHD.Name = "btnThemSachinHD";
            this.btnThemSachinHD.Size = new System.Drawing.Size(159, 23);
            this.btnThemSachinHD.TabIndex = 29;
            this.btnThemSachinHD.Text = "Thêm Sách vào HD";
            this.btnThemSachinHD.UseVisualStyleBackColor = true;
            this.btnThemSachinHD.Click += new System.EventHandler(this.btnThemSachinHD_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(798, 573);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(231, 32);
            this.label14.TabIndex = 30;
            this.label14.Text = "Sản Phẩm Khác";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(829, 670);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(117, 22);
            this.txtMaSP.TabIndex = 31;
            // 
            // txtDonGiaSP
            // 
            this.txtDonGiaSP.Location = new System.Drawing.Point(970, 670);
            this.txtDonGiaSP.Name = "txtDonGiaSP";
            this.txtDonGiaSP.Size = new System.Drawing.Size(117, 22);
            this.txtDonGiaSP.TabIndex = 32;
            // 
            // txtSoLuongSP
            // 
            this.txtSoLuongSP.Location = new System.Drawing.Point(1116, 670);
            this.txtSoLuongSP.Name = "txtSoLuongSP";
            this.txtSoLuongSP.Size = new System.Drawing.Size(117, 22);
            this.txtSoLuongSP.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(826, 640);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 16);
            this.label15.TabIndex = 34;
            this.label15.Text = "Mã Sản Phẩm";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(967, 640);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 16);
            this.label16.TabIndex = 35;
            this.label16.Text = "Đơn Giá SP";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1113, 640);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 16);
            this.label17.TabIndex = 36;
            this.label17.Text = "Số Lượng";
            // 
            // btnThemSPinHD
            // 
            this.btnThemSPinHD.Location = new System.Drawing.Point(1116, 720);
            this.btnThemSPinHD.Name = "btnThemSPinHD";
            this.btnThemSPinHD.Size = new System.Drawing.Size(159, 23);
            this.btnThemSPinHD.TabIndex = 37;
            this.btnThemSPinHD.Text = "Thêm SP vào HD";
            this.btnThemSPinHD.UseVisualStyleBackColor = true;
            this.btnThemSPinHD.Click += new System.EventHandler(this.btnThemSPinHD_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(910, 758);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(159, 23);
            this.btnThanhToan.TabIndex = 38;
            this.btnThanhToan.Text = "THANH TOÁN";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 807);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnThemSPinHD);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtSoLuongSP);
            this.Controls.Add(this.txtDonGiaSP);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnThemSachinHD);
            this.Controls.Add(this.btnThemHD);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSoLuongSach);
            this.Controls.Add(this.txtDonGiaSach);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMaKHinHD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnTimKH);
            this.Controls.Add(this.txtTimKH);
            this.Controls.Add(this.btnThemKH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDiemTL);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvSPK);
            this.Controls.Add(this.dtgvSach);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHome";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSPK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvSach;
        private System.Windows.Forms.DataGridView dtgvSPK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiemTL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.TextBox txtTimKH;
        private System.Windows.Forms.Button btnTimKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaKHinHD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtDonGiaSach;
        private System.Windows.Forms.TextBox txtSoLuongSach;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnThemHD;
        private System.Windows.Forms.Button btnThemSachinHD;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtDonGiaSP;
        private System.Windows.Forms.TextBox txtSoLuongSP;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnThemSPinHD;
        private System.Windows.Forms.Button btnThanhToan;
    }
}