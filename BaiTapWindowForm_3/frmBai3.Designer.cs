namespace BaiTapWindowForm_3
{
    partial class frmBai3
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.lblKqThuTu = new System.Windows.Forms.Label();
            this.lblKqTachChuoi = new System.Windows.Forms.Label();
            this.btnTachChuoi = new System.Windows.Forms.Button();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTachChuoi);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.lblKqTachChuoi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(73, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tách họ và tên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKiemTra);
            this.groupBox2.Controls.Add(this.txtN2);
            this.groupBox2.Controls.Add(this.txtN1);
            this.groupBox2.Controls.Add(this.lblKqThuTu);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(73, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 227);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kiểm tra 2 số liên tiếp";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập họ tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kết quả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kết quả:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số thứ 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số thứ 2:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(157, 49);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(140, 22);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(157, 53);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(140, 22);
            this.txtN1.TabIndex = 1;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(157, 92);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(140, 22);
            this.txtN2.TabIndex = 1;
            // 
            // lblKqThuTu
            // 
            this.lblKqThuTu.AutoSize = true;
            this.lblKqThuTu.Location = new System.Drawing.Point(138, 184);
            this.lblKqThuTu.Name = "lblKqThuTu";
            this.lblKqThuTu.Size = new System.Drawing.Size(10, 16);
            this.lblKqThuTu.TabIndex = 0;
            this.lblKqThuTu.Text = ".";
            this.lblKqThuTu.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblKqTachChuoi
            // 
            this.lblKqTachChuoi.AutoSize = true;
            this.lblKqTachChuoi.Location = new System.Drawing.Point(138, 132);
            this.lblKqTachChuoi.Name = "lblKqTachChuoi";
            this.lblKqTachChuoi.Size = new System.Drawing.Size(10, 16);
            this.lblKqTachChuoi.TabIndex = 0;
            this.lblKqTachChuoi.Text = ".";
            // 
            // btnTachChuoi
            // 
            this.btnTachChuoi.Location = new System.Drawing.Point(157, 91);
            this.btnTachChuoi.Name = "btnTachChuoi";
            this.btnTachChuoi.Size = new System.Drawing.Size(91, 30);
            this.btnTachChuoi.TabIndex = 2;
            this.btnTachChuoi.Text = "Tách chuỗi";
            this.btnTachChuoi.UseVisualStyleBackColor = true;
            this.btnTachChuoi.Click += new System.EventHandler(this.btnTachChuoi_Click);
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Location = new System.Drawing.Point(156, 132);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(92, 30);
            this.btnKiemTra.TabIndex = 2;
            this.btnKiemTra.Text = "Kiểm tra";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 554);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBai3";
            this.Text = "frmBai3";
            this.Load += new System.EventHandler(this.frmBai3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.Label lblKqTachChuoi;
        private System.Windows.Forms.Label lblKqThuTu;
        private System.Windows.Forms.Button btnTachChuoi;
        private System.Windows.Forms.Button btnKiemTra;
    }
}