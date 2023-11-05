namespace BookStore
{
    partial class FrmBangLuong
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
            this.dgv_BangLuong = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BangLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_BangLuong
            // 
            this.dgv_BangLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BangLuong.Location = new System.Drawing.Point(-2, -3);
            this.dgv_BangLuong.Name = "dgv_BangLuong";
            this.dgv_BangLuong.Size = new System.Drawing.Size(804, 458);
            this.dgv_BangLuong.TabIndex = 2;
            this.dgv_BangLuong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_BangLuong_CellContentClick);
            // 
            // FrmBangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_BangLuong);
            this.Name = "FrmBangLuong";
            this.Text = "FrmBangLuong";
            this.Load += new System.EventHandler(this.FrmBangLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BangLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_BangLuong;
    }
}