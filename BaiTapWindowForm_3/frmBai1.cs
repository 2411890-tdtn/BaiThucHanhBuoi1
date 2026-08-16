using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowForm_3
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien("NV01", "Nguyễn Văn A", "15/05/2000", 2.34, 0.5);
            lblThongTin.Text = nv.HienThi();
        }
    }
}
