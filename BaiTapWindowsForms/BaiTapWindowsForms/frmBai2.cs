using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForms
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void frmBai2_Load(object sender, EventArgs e)
        {

        }

        private void cbbTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stt = cbbTenHang.SelectedIndex;
            switch(stt)
            {
                //0,1,2 là vị trí các mặt hàng trong danh sách
                case 0:
                    txtDonGia.Text = "100000";
                    break;
                case 1:
                    txtDonGia.Text = "2000000";
                    break;
                case 2:
                    txtDonGia.Text = "150000";
                    break;
            }    
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int donGia = int.Parse(txtDonGia.Text);
            int soLuong = int.Parse(txtSoLuong.Text);
            double thanhTien = donGia * soLuong;


            if (rdChuyenKhoan.Checked)
                thanhTien = donGia * soLuong * 0.95;

            lblSoTien.Text = thanhTien.ToString();
        }
    }
}
