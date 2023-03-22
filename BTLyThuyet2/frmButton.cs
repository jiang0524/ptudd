using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLyThuyet2
{
    public partial class btnButton : Form
    {
        public btnButton()
        {
            InitializeComponent();
        }

        private void ckbMauChu_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ckbMauChu.Checked)
                this.Button.ForeColor = Color.Red;
            else
                this.Button.ForeColor = Color.Black;
                
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ckbMauNen.Checked)
                this.Button.BackColor = Color.LightCyan;
            else
                this.Button.BackColor = this.btnButtonFlat.BackColor;
        }

        private void rdFlat_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdFlat.Checked)
                this.btnButtonFlat.FlatStyle = FlatStyle.Flat;
            else
                this.btnButtonFlat.FlatStyle = FlatStyle.Popup;
        }
    }
}
