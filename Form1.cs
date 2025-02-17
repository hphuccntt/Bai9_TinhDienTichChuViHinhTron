using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai9_TinhDienTichChuViHinhTron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double So = double.Parse(txtSo.Text);
            double chuvi, dientich;
            if ( rdbCV.Checked)
            {
                chuvi = Math.PI * (So * 2);
                txtKQ.Text = chuvi.ToString();
            }
            if (rdbDT.Checked)
            {
                dientich = Math.PI * (So * So);
                txtKQ.Text = dientich.ToString();

            }
        }

        private void trbTinh_Scroll(object sender, EventArgs e)
        {
            txtSo.Text = trbTinh.Value.ToString();
        }
    }
}
