namespace BookStore
{
    partial class FrmQuanLySPK
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnXoaSPK = new System.Windows.Forms.Button();
            this.btnThemSPK = new System.Windows.Forms.Button();
            this.btnSuaSPK = new System.Windows.Forms.Button();
            this.txtMaSPK = new System.Windows.Forms.TextBox();
            this.txtTenSPK = new System.Windows.Forms.TextBox();
            this.txtDonGiaSPK = new System.Windows.Forms.TextBox();
            this.txtTonKhoSPK = new System.Windows.Forms.TextBox();
            this.dtgvSanPhamKhac = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPhamKhac)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SPK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên SPK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đơn Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tồn Kho";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(207, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(274, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "QUẢN LÝ SẢN PHẨM KHÁC";
            // 
            // btnXoaSPK
            // 
            this.btnXoaSPK.Location = new System.Drawing.Point(440, 275);
            this.btnXoaSPK.Name = "btnXoaSPK";
            this.btnXoaSPK.Size = new System.Drawing.Size(113, 56);
            this.btnXoaSPK.TabIndex = 2;
            this.btnXoaSPK.Text = "Xóa SPK";
            this.btnXoaSPK.UseVisualStyleBackColor = true;
            this.btnXoaSPK.Click += new System.EventHandler(this.btnXoaSPK_Click);
            // 
            // btnThemSPK
            // 
            this.btnThemSPK.Location = new System.Drawing.Point(136, 275);
            this.btnThemSPK.Name = "btnThemSPK";
            this.btnThemSPK.Size = new System.Drawing.Size(113, 56);
            this.btnThemSPK.TabIndex = 2;
            this.btnThemSPK.Text = "Thêm SPK";
            this.btnThemSPK.UseVisualStyleBackColor = true;
            this.btnThemSPK.Click += new System.EventHandler(this.btnThemSPK_Click);
            // 
            // btnSuaSPK
            // 
            this.btnSuaSPK.Location = new System.Drawing.Point(289, 275);
            this.btnSuaSPK.Name = "btnSuaSPK";
            this.btnSuaSPK.Size = new System.Drawing.Size(113, 56);
            this.btnSuaSPK.TabIndex = 2;
            this.btnSuaSPK.Text = "Sửa SPK";
            this.btnSuaSPK.UseVisualStyleBackColor = true;
            this.btnSuaSPK.Click += new System.EventHandler(this.btnSuaSPK_Click);
            // 
            // txtMaSPK
            // 
            this.txtMaSPK.Location = new System.Drawing.Point(211, 97);
            this.txtMaSPK.Name = "txtMaSPK";
            this.txtMaSPK.Size = new System.Drawing.Size(305, 20);
            this.txtMaSPK.TabIndex = 3;
            // 
            // txtTenSPK
            // 
            this.txtTenSPK.Location = new System.Drawing.Point(211, 142);
            this.txtTenSPK.Name = "txtTenSPK";
            this.txtTenSPK.Size = new System.Drawing.Size(305, 20);
            this.txtTenSPK.TabIndex = 3;
            // 
            // txtDonGiaSPK
            // 
            this.txtDonGiaSPK.Location = new System.Drawing.Point(211, 189);
            this.txtDonGiaSPK.Name = "txtDonGiaSPK";
            this.txtDonGiaSPK.Size = new System.Drawing.Size(305, 20);
            this.txtDonGiaSPK.TabIndex = 3;
            // 
            // txtTonKhoSPK
            // 
            this.txtTonKhoSPK.Location = new System.Drawing.Point(211, 229);
            this.txtTonKhoSPK.Name = "txtTonKhoSPK";
            this.txtTonKhoSPK.Size = new System.Drawing.Size(305, 20);
            this.txtTonKhoSPK.TabIndex = 3;
            // 
            // dtgvSanPhamKhac
            // 
            this.dtgvSanPhamKhac.Location = new System.Drawing.Point(95, 351);
            this.dtgvSanPhamKhac.Name = "dtgvSanPhamKhac";
            this.dtgvSanPhamKhac.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgvSanPhamKhac.Size = new System.Drawing.Size(489, 223);
            this.dtgvSanPhamKhac.TabIndex = 0;
            this.dtgvSanPhamKhac.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSanPhamKhac_CellContentClick);
            this.dtgvSanPhamKhac.Click += new System.EventHandler(this.dtgvSanPhamKhac_Click);
            // 
            // FrmQuanLySPK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 586);
            this.Controls.Add(this.dtgvSanPhamKhac);
            this.Controls.Add(this.txtTonKhoSPK);
            this.Controls.Add(this.txtDonGiaSPK);
            this.Controls.Add(this.txtTenSPK);
            this.Controls.Add(this.txtMaSPK);
            this.Controls.Add(this.btnSuaSPK);
            this.Controls.Add(this.btnThemSPK);
            this.Controls.Add(this.btnXoaSPK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "FrmQuanLySPK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQuanLySPK";
            this.Load += new System.EventHandler(this.FrmQuanLySPK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPhamKhac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnXoaSPK;
        private System.Windows.Forms.Button btnThemSPK;
        private System.Windows.Forms.Button btnSuaSPK;
        private System.Windows.Forms.TextBox txtMaSPK;
        private System.Windows.Forms.TextBox txtTenSPK;
        private System.Windows.Forms.TextBox txtDonGiaSPK;
        private System.Windows.Forms.TextBox txtTonKhoSPK;
        private System.Windows.Forms.DataGridView dtgvSanPhamKhac;
    }
}