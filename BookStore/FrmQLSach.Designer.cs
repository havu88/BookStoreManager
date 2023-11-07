namespace BookStore
{
    partial class FrmQuanLySach
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgvDSSach = new System.Windows.Forms.DataGridView();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTonKho = new System.Windows.Forms.TextBox();
            this.txtMaNhomSach = new System.Windows.Forms.TextBox();
            this.txtTenNhomSach = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.btnSuaSach = new System.Windows.Forms.Button();
            this.btnXoaSach = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemHome = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSPK = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSSach)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(315, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ SÁCH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã Sách ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Sách ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tồn Kho";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mã Nhóm Sách";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tên Nhóm Sách";
            // 
            // dtgvDSSach
            // 
            this.dtgvDSSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSSach.Location = new System.Drawing.Point(35, 336);
            this.dtgvDSSach.Name = "dtgvDSSach";
            this.dtgvDSSach.Size = new System.Drawing.Size(793, 271);
            this.dtgvDSSach.TabIndex = 4;
            this.dtgvDSSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSSach_CellContentClick);
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(195, 151);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(299, 20);
            this.txtTenSach.TabIndex = 5;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(195, 191);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(299, 20);
            this.txtDonGia.TabIndex = 5;
            // 
            // txtTonKho
            // 
            this.txtTonKho.Location = new System.Drawing.Point(195, 227);
            this.txtTonKho.Name = "txtTonKho";
            this.txtTonKho.Size = new System.Drawing.Size(299, 20);
            this.txtTonKho.TabIndex = 5;
            // 
            // txtMaNhomSach
            // 
            this.txtMaNhomSach.Location = new System.Drawing.Point(196, 258);
            this.txtMaNhomSach.Name = "txtMaNhomSach";
            this.txtMaNhomSach.Size = new System.Drawing.Size(299, 20);
            this.txtMaNhomSach.TabIndex = 5;
            // 
            // txtTenNhomSach
            // 
            this.txtTenNhomSach.Location = new System.Drawing.Point(196, 292);
            this.txtTenNhomSach.Name = "txtTenNhomSach";
            this.txtTenNhomSach.Size = new System.Drawing.Size(299, 20);
            this.txtTenNhomSach.TabIndex = 5;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(196, 118);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(299, 20);
            this.txtMaSach.TabIndex = 5;
            // 
            // btnThemSach
            // 
            this.btnThemSach.Location = new System.Drawing.Point(602, 118);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(113, 53);
            this.btnThemSach.TabIndex = 6;
            this.btnThemSach.Text = "Thêm sách ";
            this.btnThemSach.UseVisualStyleBackColor = true;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // btnSuaSach
            // 
            this.btnSuaSach.Location = new System.Drawing.Point(602, 190);
            this.btnSuaSach.Name = "btnSuaSach";
            this.btnSuaSach.Size = new System.Drawing.Size(113, 53);
            this.btnSuaSach.TabIndex = 6;
            this.btnSuaSach.Text = "Cập nhật sách";
            this.btnSuaSach.UseVisualStyleBackColor = true;
            this.btnSuaSach.Click += new System.EventHandler(this.btnSuaSach_Click);
            // 
            // btnXoaSach
            // 
            this.btnXoaSach.Location = new System.Drawing.Point(602, 258);
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.Size = new System.Drawing.Size(113, 53);
            this.btnXoaSach.TabIndex = 6;
            this.btnXoaSach.Text = "Xóa sách";
            this.btnXoaSach.UseVisualStyleBackColor = true;
            this.btnXoaSach.Click += new System.EventHandler(this.btnXoaSach_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemHome});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(863, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemHome
            // 
            this.menuItemHome.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSPK});
            this.menuItemHome.Name = "menuItemHome";
            this.menuItemHome.Size = new System.Drawing.Size(52, 20);
            this.menuItemHome.Text = "Home";
            this.menuItemHome.Click += new System.EventHandler(this.menuItemHome_Click);
            // 
            // menuItemSPK
            // 
            this.menuItemSPK.Name = "menuItemSPK";
            this.menuItemSPK.Size = new System.Drawing.Size(198, 22);
            this.menuItemSPK.Text = "Quản lý sản phẩm khác";
            this.menuItemSPK.Click += new System.EventHandler(this.menuItemSPK_Click);
            // 
            // FrmQuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 632);
            this.Controls.Add(this.btnXoaSach);
            this.Controls.Add(this.btnSuaSach);
            this.Controls.Add(this.btnThemSach);
            this.Controls.Add(this.txtTenNhomSach);
            this.Controls.Add(this.txtMaNhomSach);
            this.Controls.Add(this.txtTonKho);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.dtgvDSSach);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmQuanLySach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQLSach";
            this.Load += new System.EventHandler(this.FrmQuanLySach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSSach)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtgvDSSach;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTonKho;
        private System.Windows.Forms.TextBox txtMaNhomSach;
        private System.Windows.Forms.TextBox txtTenNhomSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.Button btnSuaSach;
        private System.Windows.Forms.Button btnXoaSach;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemHome;
        private System.Windows.Forms.ToolStripMenuItem menuItemSPK;
    }
}
