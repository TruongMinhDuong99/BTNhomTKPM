namespace GUI
{
    partial class QuanLyDichVu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDatLichKham = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiemTheoTen = new System.Windows.Forms.TextBox();
            this.lvwDanhSachDichVu = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDatLichKham);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTimKiemTheoTen);
            this.groupBox1.Controls.Add(this.lvwDanhSachDichVu);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 320);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách dịch vụ";
            // 
            // btnDatLichKham
            // 
            this.btnDatLichKham.Location = new System.Drawing.Point(681, 220);
            this.btnDatLichKham.Name = "btnDatLichKham";
            this.btnDatLichKham.Size = new System.Drawing.Size(89, 85);
            this.btnDatLichKham.TabIndex = 13;
            this.btnDatLichKham.Text = "Đặt lịch khám";
            this.btnDatLichKham.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(681, 129);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(89, 85);
            this.btnCapNhat.TabIndex = 12;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(397, 13);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 20);
            this.btnTim.TabIndex = 11;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(681, 39);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 85);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tìm kiếm theo tên";
            // 
            // txtTimKiemTheoTen
            // 
            this.txtTimKiemTheoTen.Location = new System.Drawing.Point(129, 13);
            this.txtTimKiemTheoTen.Name = "txtTimKiemTheoTen";
            this.txtTimKiemTheoTen.Size = new System.Drawing.Size(262, 20);
            this.txtTimKiemTheoTen.TabIndex = 7;
            // 
            // lvwDanhSachDichVu
            // 
            this.lvwDanhSachDichVu.HideSelection = false;
            this.lvwDanhSachDichVu.Location = new System.Drawing.Point(11, 39);
            this.lvwDanhSachDichVu.Name = "lvwDanhSachDichVu";
            this.lvwDanhSachDichVu.Size = new System.Drawing.Size(664, 266);
            this.lvwDanhSachDichVu.TabIndex = 6;
            this.lvwDanhSachDichVu.UseCompatibleStateImageBehavior = false;
            // 
            // QuanLyDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 344);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "QuanLyDichVu";
            this.Text = "QuanLyDichVu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDatLichKham;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiemTheoTen;
        private System.Windows.Forms.ListView lvwDanhSachDichVu;
    }
}