﻿namespace BookStore
{
    partial class FrmHoaDon
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
            this.lbMaHD = new System.Windows.Forms.Label();
            this.lbTenKH = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.lbTriGiaHD = new System.Windows.Forms.Label();
            this.lbNgayXuatHD = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.Location = new System.Drawing.Point(222, 57);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(57, 16);
            this.lbMaHD.TabIndex = 0;
            this.lbMaHD.Text = "lbMaHD";
            // 
            // lbTenKH
            // 
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.Location = new System.Drawing.Point(222, 126);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(60, 16);
            this.lbTenKH.TabIndex = 1;
            this.lbTenKH.Text = "lbTenKH";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Location = new System.Drawing.Point(222, 264);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(72, 16);
            this.lbSoLuong.TabIndex = 2;
            this.lbSoLuong.Text = "lbSoLuong";
            // 
            // lbTriGiaHD
            // 
            this.lbTriGiaHD.AutoSize = true;
            this.lbTriGiaHD.Location = new System.Drawing.Point(222, 336);
            this.lbTriGiaHD.Name = "lbTriGiaHD";
            this.lbTriGiaHD.Size = new System.Drawing.Size(75, 16);
            this.lbTriGiaHD.TabIndex = 3;
            this.lbTriGiaHD.Text = "lbTriGiaHD";
            // 
            // lbNgayXuatHD
            // 
            this.lbNgayXuatHD.AutoSize = true;
            this.lbNgayXuatHD.Location = new System.Drawing.Point(222, 194);
            this.lbNgayXuatHD.Name = "lbNgayXuatHD";
            this.lbNgayXuatHD.Size = new System.Drawing.Size(97, 16);
            this.lbNgayXuatHD.TabIndex = 4;
            this.lbNgayXuatHD.Text = "lbNgayXuatHD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã Hoá Đơn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ngày Xuất Hoá Đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số Lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Thành Tiền";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(167, 395);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 28);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 447);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNgayXuatHD);
            this.Controls.Add(this.lbTriGiaHD);
            this.Controls.Add(this.lbSoLuong);
            this.Controls.Add(this.lbTenKH);
            this.Controls.Add(this.lbMaHD);
            this.Name = "FrmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHoaDon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaHD;
        private System.Windows.Forms.Label lbTenKH;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Label lbTriGiaHD;
        private System.Windows.Forms.Label lbNgayXuatHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClose;
    }
}