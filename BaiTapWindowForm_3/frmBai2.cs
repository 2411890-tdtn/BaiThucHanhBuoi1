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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {
            int n = 0;

            if (!int.TryParse(txtN.Text, out n) || n < 1)
            {
                lblKetQua.Text = "Lỗi: Vui lòng nhập số nguyên dương N >= 1!";
                return;
            }

            if (radTong.Checked)
            {
                long tong = 0;
                for (int i = 1; i <= n; i++)
                {
                    tong += i;
                }
                lblKetQua.Text = "Kết quả là: " + tong;
            }
            else if (radGiaiThua.Checked)
            {
                long giaiThua = 1;
                for (int i = 1; i <= n; i++)
                {
                    giaiThua *= i;
                }
                lblKetQua.Text = "Kết quả là: " + giaiThua;
            }
        }
    }
}
