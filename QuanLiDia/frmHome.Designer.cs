namespace QuanLiDia
{
    partial class frmHome
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
            this.btnThueDia = new System.Windows.Forms.Button();
            this.btnTraDia = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 99);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lí DVD_CD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThueDia
            // 
            this.btnThueDia.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThueDia.Location = new System.Drawing.Point(12, 115);
            this.btnThueDia.Name = "btnThueDia";
            this.btnThueDia.Size = new System.Drawing.Size(170, 125);
            this.btnThueDia.TabIndex = 0;
            this.btnThueDia.Text = "Thuê Đĩa";
            this.btnThueDia.UseVisualStyleBackColor = true;
            this.btnThueDia.Click += new System.EventHandler(this.btnThueDia_Click);
            // 
            // btnTraDia
            // 
            this.btnTraDia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraDia.Location = new System.Drawing.Point(244, 115);
            this.btnTraDia.Name = "btnTraDia";
            this.btnTraDia.Size = new System.Drawing.Size(167, 125);
            this.btnTraDia.TabIndex = 1;
            this.btnTraDia.Text = "Trả Đĩa";
            this.btnTraDia.UseVisualStyleBackColor = true;
            this.btnTraDia.Click += new System.EventHandler(this.btnTraDia_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(457, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 125);
            this.button1.TabIndex = 2;
            this.button1.Text = "Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 253);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTraDia);
            this.Controls.Add(this.btnThueDia);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(555, 292);
            this.MinimumSize = new System.Drawing.Size(555, 292);
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThueDia;
        private System.Windows.Forms.Button btnTraDia;
        private System.Windows.Forms.Button button1;
    }
}