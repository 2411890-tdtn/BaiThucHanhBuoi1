using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowForm_2
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {
            double so1 = 0;
            double so2 = 0;
            double ketQua = 0;

            if (!double.TryParse(txtSo1.Text, out so1) || !double.TryParse(txtSo2.Text, out so2))
            {
                lblKetQua.Text = "Lỗi: Vui lòng nhập đúng định dạng số!";
                return;
            }

            if (radCong.Checked)
            {
                ketQua = so1 + so2;
            }
            else if (radTru.Checked)
            {
                ketQua = so1 - so2;
            }
            else if (radNhan.Checked)
            {
                ketQua = so1 * so2;
            }
            else if (radChia.Checked)
            {
                if (so2 == 0)
                {
                    lblKetQua.Text = "Lỗi: Không thể chia cho 0!"; 
                    return;
                }
                ketQua = so1 / so2;
            }

            lblKetQua.Text = "Kết quả là: " + ketQua.ToString();
        }
    }
}
