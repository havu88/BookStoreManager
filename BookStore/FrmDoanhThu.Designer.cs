namespace BookStore
{
    partial class FrmDoanhThu
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
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.rdAll = new System.Windows.Forms.RadioButton();
            this.rdSach = new System.Windows.Forms.RadioButton();
            this.rdSPK = new System.Windows.Forms.RadioButton();
            this.mskTuNgay = new System.Windows.Forms.MaskedTextBox();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.lblToiNgay = new System.Windows.Forms.Label();
            this.mskToiNgay = new System.Windows.Forms.MaskedTextBox();
            this.btnTruyVan = new System.Windows.Forms.Button();
            this.dvgHoaDon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.Font = new System.Drawing.Font("Microsoft Tai Le", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThu.Location = new System.Drawing.Point(312, 19);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(448, 56);
            this.lblDoanhThu.TabIndex = 0;
            this.lblDoanhThu.Text = "Doanh thu bán hàng";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1122, 9);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 50);
            this.btnClose.TabIndex = 45;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(12, 19);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(90, 40);
            this.btnHome.TabIndex = 46;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // rdAll
            // 
            this.rdAll.AutoSize = true;
            this.rdAll.Checked = true;
            this.rdAll.Location = new System.Drawing.Point(650, 134);
            this.rdAll.Name = "rdAll";
            this.rdAll.Size = new System.Drawing.Size(78, 24);
            this.rdAll.TabIndex = 47;
            this.rdAll.TabStop = true;
            this.rdAll.Text = "Tất cả";
            this.rdAll.UseVisualStyleBackColor = true;
            this.rdAll.CheckedChanged += new System.EventHandler(this.rdAll_CheckedChanged);
            // 
            // rdSach
            // 
            this.rdSach.AutoSize = true;
            this.rdSach.Location = new System.Drawing.Point(790, 134);
            this.rdSach.Name = "rdSach";
            this.rdSach.Size = new System.Drawing.Size(71, 24);
            this.rdSach.TabIndex = 47;
            this.rdSach.Text = "Sách";
            this.rdSach.UseVisualStyleBackColor = true;
            this.rdSach.CheckedChanged += new System.EventHandler(this.rdSach_CheckedChanged);
            // 
            // rdSPK
            // 
            this.rdSPK.AutoSize = true;
            this.rdSPK.Location = new System.Drawing.Point(931, 134);
            this.rdSPK.Name = "rdSPK";
            this.rdSPK.Size = new System.Drawing.Size(65, 24);
            this.rdSPK.TabIndex = 47;
            this.rdSPK.Text = "SPK";
            this.rdSPK.UseVisualStyleBackColor = true;
            this.rdSPK.CheckedChanged += new System.EventHandler(this.rdSPK_CheckedChanged);
            // 
            // mskTuNgay
            // 
            this.mskTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTuNgay.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.mskTuNgay.Location = new System.Drawing.Point(744, 81);
            this.mskTuNgay.Name = "mskTuNgay";
            this.mskTuNgay.Size = new System.Drawing.Size(146, 30);
            this.mskTuNgay.TabIndex = 48;
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuNgay.Location = new System.Drawing.Point(637, 86);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(91, 25);
            this.lblTuNgay.TabIndex = 49;
            this.lblTuNgay.Text = "Từ ngày";
            // 
            // lblToiNgay
            // 
            this.lblToiNgay.AutoSize = true;
            this.lblToiNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToiNgay.Location = new System.Drawing.Point(896, 86);
            this.lblToiNgay.Name = "lblToiNgay";
            this.lblToiNgay.Size = new System.Drawing.Size(96, 25);
            this.lblToiNgay.TabIndex = 49;
            this.lblToiNgay.Text = "Tới ngày";
            // 
            // mskToiNgay
            // 
            this.mskToiNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskToiNgay.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.mskToiNgay.Location = new System.Drawing.Point(998, 81);
            this.mskToiNgay.Name = "mskToiNgay";
            this.mskToiNgay.Size = new System.Drawing.Size(150, 30);
            this.mskToiNgay.TabIndex = 48;
            // 
            // btnTruyVan
            // 
            this.btnTruyVan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTruyVan.Location = new System.Drawing.Point(1018, 123);
            this.btnTruyVan.Name = "btnTruyVan";
            this.btnTruyVan.Size = new System.Drawing.Size(130, 43);
            this.btnTruyVan.TabIndex = 50;
            this.btnTruyVan.Text = "Truy vấn";
            this.btnTruyVan.UseVisualStyleBackColor = true;
            this.btnTruyVan.Click += new System.EventHandler(this.btnTruyVan_Click);
            // 
            // dvgHoaDon
            // 
            this.dvgHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgHoaDon.Location = new System.Drawing.Point(24, 205);
            this.dvgHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dvgHoaDon.Name = "dvgHoaDon";
            this.dvgHoaDon.RowHeadersWidth = 51;
            this.dvgHoaDon.RowTemplate.Height = 24;
            this.dvgHoaDon.Size = new System.Drawing.Size(1124, 394);
            this.dvgHoaDon.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(803, 606);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 52;
            this.label1.Text = "Tổng doanh thu";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(987, 606);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 30);
            this.textBox1.TabIndex = 53;
            // 
            // FrmDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 649);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvgHoaDon);
            this.Controls.Add(this.btnTruyVan);
            this.Controls.Add(this.lblToiNgay);
            this.Controls.Add(this.lblTuNgay);
            this.Controls.Add(this.mskToiNgay);
            this.Controls.Add(this.mskTuNgay);
            this.Controls.Add(this.rdSPK);
            this.Controls.Add(this.rdSach);
            this.Controls.Add(this.rdAll);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblDoanhThu);
            this.Name = "FrmDoanhThu";
            this.Text = "FrmDoanhThu";
            this.Load += new System.EventHandler(this.FrmDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.RadioButton rdAll;
        private System.Windows.Forms.RadioButton rdSach;
        private System.Windows.Forms.RadioButton rdSPK;
        private System.Windows.Forms.MaskedTextBox mskTuNgay;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.Label lblToiNgay;
        private System.Windows.Forms.MaskedTextBox mskToiNgay;
        private System.Windows.Forms.Button btnTruyVan;
        private System.Windows.Forms.DataGridView dvgHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}