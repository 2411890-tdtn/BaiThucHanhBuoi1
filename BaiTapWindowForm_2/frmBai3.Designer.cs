namespace BaiTapWindowForm_2
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
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.lblKqNoiChuoi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblKqGiaiThua = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnNoiChuoi = new System.Windows.Forms.Button();
            this.btnGiaiThua = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNoiChuoi);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.txtHo);
            this.groupBox1.Controls.Add(this.lblKqNoiChuoi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(56, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nối chuỗi";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(139, 75);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(145, 24);
            this.txtTen.TabIndex = 1;
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(139, 41);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(145, 24);
            this.txtHo.TabIndex = 1;
            // 
            // lblKqNoiChuoi
            // 
            this.lblKqNoiChuoi.AutoSize = true;
            this.lblKqNoiChuoi.Location = new System.Drawing.Point(112, 164);
            this.lblKqNoiChuoi.Name = "lblKqNoiChuoi";
            this.lblKqNoiChuoi.Size = new System.Drawing.Size(12, 18);
            this.lblKqNoiChuoi.TabIndex = 0;
            this.lblKqNoiChuoi.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kết quả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập họ:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGiaiThua);
            this.groupBox2.Controls.Add(this.lblKqGiaiThua);
            this.groupBox2.Controls.Add(this.txtN);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(56, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 226);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tính giai thừa";
            // 
            // lblKqGiaiThua
            // 
            this.lblKqGiaiThua.AutoSize = true;
            this.lblKqGiaiThua.Location = new System.Drawing.Point(124, 127);
            this.lblKqGiaiThua.Name = "lblKqGiaiThua";
            this.lblKqGiaiThua.Size = new System.Drawing.Size(12, 18);
            this.lblKqGiaiThua.TabIndex = 0;
            this.lblKqGiaiThua.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kết quả:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập số n:";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(139, 38);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(145, 24);
            this.txtN.TabIndex = 1;
            this.txtN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnNoiChuoi
            // 
            this.btnNoiChuoi.Location = new System.Drawing.Point(139, 115);
            this.btnNoiChuoi.Name = "btnNoiChuoi";
            this.btnNoiChuoi.Size = new System.Drawing.Size(117, 32);
            this.btnNoiChuoi.TabIndex = 2;
            this.btnNoiChuoi.Text = "Nối chuỗi";
            this.btnNoiChuoi.UseVisualStyleBackColor = true;
            this.btnNoiChuoi.Click += new System.EventHandler(this.btnNoiChuoi_Click);
            // 
            // btnGiaiThua
            // 
            this.btnGiaiThua.Location = new System.Drawing.Point(139, 77);
            this.btnGiaiThua.Name = "btnGiaiThua";
            this.btnGiaiThua.Size = new System.Drawing.Size(117, 32);
            this.btnGiaiThua.TabIndex = 2;
            this.btnGiaiThua.Text = "Tính giai thừa";
            this.btnGiaiThua.UseVisualStyleBackColor = true;
            this.btnGiaiThua.Click += new System.EventHandler(this.btnGiaiThua_Click);
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 542);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBai3";
            this.Text = "frmBai3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.Label lblKqNoiChuoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKqGiaiThua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnNoiChuoi;
        private System.Windows.Forms.Button btnGiaiThua;
    }
}