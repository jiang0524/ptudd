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
    public partial class frmVDListBox : Form
    {
        public frmVDListBox()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int itemsselect = lbDanhsach.SelectedItems.Count - 1;
            for (int i = itemsselect; i >= 0; i--)
            {
                lbDanhsachChon.Items.Add(lbDanhsach.SelectedItems[i]);
                lbDanhsach.Items.Remove(lbDanhsach.SelectedItems[i]);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int i = lbDanhsach.SelectedItems.Count - 1;
            while (i >= 0)
            {
                lbDanhsachChon.Items.RemoveAt(lbDanhsachChon.SelectedIndices[i]);
                i--;
            }
        }
    }
}
