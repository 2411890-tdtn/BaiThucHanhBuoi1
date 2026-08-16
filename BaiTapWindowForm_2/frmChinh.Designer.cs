namespace BaiTapWindowForm_2
{
    partial class frmChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bàiKiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bàiSốToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bàiSố2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bàiSố3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bàiKiểmToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bàiKiểmToolStripMenuItem
            // 
            this.bàiKiểmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bàiSốToolStripMenuItem,
            this.bàiSố2ToolStripMenuItem,
            this.bàiSố3ToolStripMenuItem});
            this.bàiKiểmToolStripMenuItem.Name = "bàiKiểmToolStripMenuItem";
            this.bàiKiểmToolStripMenuItem.Size = new System.Drawing.Size(102, 26);
            this.bàiKiểmToolStripMenuItem.Text = "Bài kiểm tra";
            // 
            // bàiSốToolStripMenuItem
            // 
            this.bàiSốToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bàiSốToolStripMenuItem.Image")));
            this.bàiSốToolStripMenuItem.Name = "bàiSốToolStripMenuItem";
            this.bàiSốToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bàiSốToolStripMenuItem.Text = "Bài số 1";
            this.bàiSốToolStripMenuItem.Click += new System.EventHandler(this.tsbBai1_Click);
            // 
            // bàiSố2ToolStripMenuItem
            // 
            this.bàiSố2ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bàiSố2ToolStripMenuItem.Image")));
            this.bàiSố2ToolStripMenuItem.Name = "bàiSố2ToolStripMenuItem";
            this.bàiSố2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bàiSố2ToolStripMenuItem.Text = "Bài số 2";
            this.bàiSố2ToolStripMenuItem.Click += new System.EventHandler(this.tsbBai2_Click);
            // 
            // bàiSố3ToolStripMenuItem
            // 
            this.bàiSố3ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bàiSố3ToolStripMenuItem.Image")));
            this.bàiSố3ToolStripMenuItem.Name = "bàiSố3ToolStripMenuItem";
            this.bàiSố3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bàiSố3ToolStripMenuItem.Text = "Bài số 3";
            this.bàiSố3ToolStripMenuItem.Click += new System.EventHandler(this.tsbBai3_Click);
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmChinh";
            this.Text = "Chương trình chính";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bàiKiểmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bàiSốToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bàiSố2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bàiSố3ToolStripMenuItem;
    }
}

