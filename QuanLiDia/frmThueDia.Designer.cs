namespace QuanLiDia
{
    partial class frmThueDia
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
            this.btnCheckFees = new System.Windows.Forms.Button();
            this.txtMaPT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpNgaythue = new System.Windows.Forms.DateTimePicker();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtTenDia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtMaDia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChonDia = new System.Windows.Forms.Button();
            this.lvwKhachHang = new System.Windows.Forms.ListView();
            this.lvwDia = new System.Windows.Forms.ListView();
            this.btnThue = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCheckFees);
            this.groupBox1.Controls.Add(this.txtMaPT);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtpNgaythue);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Phiếu Thuê";
            // 
            // btnCheckFees
            // 
            this.btnCheckFees.Location = new System.Drawing.Point(270, 53);
            this.btnCheckFees.Name = "btnCheckFees";
            this.btnCheckFees.Size = new System.Drawing.Size(95, 23);
            this.btnCheckFees.TabIndex = 2;
            this.btnCheckFees.Text = "Check late fees";
            this.btnCheckFees.UseVisualStyleBackColor = true;
            this.btnCheckFees.Click += new System.EventHandler(this.btnCheckFees_Click);
            // 
            // txtMaPT
            // 
            this.txtMaPT.Location = new System.Drawing.Point(140, 15);
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.Size = new System.Drawing.Size(124, 20);
            this.txtMaPT.TabIndex = 0;
            this.txtMaPT.Text = "mpt01";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Mã Phiếu Thuê";
            // 
            // dtpNgaythue
            // 
            this.dtpNgaythue.Enabled = false;
            this.dtpNgaythue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaythue.Location = new System.Drawing.Point(140, 134);
            this.dtpNgaythue.Name = "dtpNgaythue";
            this.dtpNgaythue.Size = new System.Drawing.Size(124, 20);
            this.dtpNgaythue.TabIndex = 1;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Enabled = false;
            this.txtTenKH.Location = new System.Drawing.Point(140, 92);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(124, 20);
            this.txtTenKH.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Khách Hàng";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(140, 53);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(124, 20);
            this.txtMaKH.TabIndex = 1;
            this.txtMaKH.TextChanged += new System.EventHandler(this.txtMaKH_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(409, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 192);
            this.button3.TabIndex = 1;
            this.button3.Text = ">>>";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.txtTenDia);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTT);
            this.groupBox2.Controls.Add(this.txtGia);
            this.groupBox2.Controls.Add(this.txtMaDia);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(466, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 192);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Đĩa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mô tả";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(98, 75);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 56);
            this.textBox2.TabIndex = 9;
            // 
            // txtTenDia
            // 
            this.txtTenDia.Location = new System.Drawing.Point(98, 49);
            this.txtTenDia.Name = "txtTenDia";
            this.txtTenDia.Size = new System.Drawing.Size(154, 20);
            this.txtTenDia.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tên đĩa";
            // 
            // txtTT
            // 
            this.txtTT.Location = new System.Drawing.Point(98, 166);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(154, 20);
            this.txtTT.TabIndex = 6;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(98, 137);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(154, 20);
            this.txtGia.TabIndex = 5;
            // 
            // txtMaDia
            // 
            this.txtMaDia.Location = new System.Drawing.Point(98, 15);
            this.txtMaDia.Name = "txtMaDia";
            this.txtMaDia.Size = new System.Drawing.Size(154, 20);
            this.txtMaDia.TabIndex = 1;
            this.txtMaDia.TextChanged += new System.EventHandler(this.txtMaDia_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tổng Tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Đĩa";
            // 
            // btnChonDia
            // 
            this.btnChonDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonDia.Location = new System.Drawing.Point(849, 10);
            this.btnChonDia.Name = "btnChonDia";
            this.btnChonDia.Size = new System.Drawing.Size(49, 186);
            this.btnChonDia.TabIndex = 2;
            this.btnChonDia.Text = "Chon Dia";
            this.btnChonDia.UseVisualStyleBackColor = true;
            this.btnChonDia.Click += new System.EventHandler(this.btnChonDia_Click);
            // 
            // lvwKhachHang
            // 
            this.lvwKhachHang.FullRowSelect = true;
            this.lvwKhachHang.Location = new System.Drawing.Point(4, 204);
            this.lvwKhachHang.Name = "lvwKhachHang";
            this.lvwKhachHang.Size = new System.Drawing.Size(435, 128);
            this.lvwKhachHang.TabIndex = 4;
            this.lvwKhachHang.UseCompatibleStateImageBehavior = false;
            // 
            // lvwDia
            // 
            this.lvwDia.FullRowSelect = true;
            this.lvwDia.Location = new System.Drawing.Point(453, 204);
            this.lvwDia.Name = "lvwDia";
            this.lvwDia.Size = new System.Drawing.Size(445, 128);
            this.lvwDia.TabIndex = 4;
            this.lvwDia.UseCompatibleStateImageBehavior = false;
            // 
            // btnThue
            // 
            this.btnThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThue.Location = new System.Drawing.Point(358, 341);
            this.btnThue.Name = "btnThue";
            this.btnThue.Size = new System.Drawing.Size(169, 46);
            this.btnThue.TabIndex = 3;
            this.btnThue.Text = "Thuê ";
            this.btnThue.UseVisualStyleBackColor = true;
            this.btnThue.Click += new System.EventHandler(this.btnThue_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 20);
            this.button1.TabIndex = 11;
            this.button1.Text = "Check disk name";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmThueDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 390);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnThue);
            this.Controls.Add(this.lvwDia);
            this.Controls.Add(this.lvwKhachHang);
            this.Controls.Add(this.btnChonDia);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(914, 429);
            this.MinimumSize = new System.Drawing.Size(914, 429);
            this.Name = "frmThueDia";
            this.Text = "frmThueDia";
            this.Load += new System.EventHandler(this.frmThueDia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.DateTimePicker dtpNgaythue;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaDia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnChonDia;
        private System.Windows.Forms.ListView lvwKhachHang;
        private System.Windows.Forms.TextBox txtMaPT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.ListView lvwDia;
        private System.Windows.Forms.Button btnThue;
        private System.Windows.Forms.TextBox txtTT;
        private System.Windows.Forms.Button btnCheckFees;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtTenDia;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}