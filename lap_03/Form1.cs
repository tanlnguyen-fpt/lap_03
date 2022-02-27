using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lap_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSon.Text);
            int m = int.Parse(txtSom.Text);
            int tong = m + n;
            txtKetqua.Text = tong.ToString();   

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtSon.Text = "";
            txtSom.Text = "";
            txtKetqua.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSon.Select();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSon.Text);
            int m = int.Parse(txtSom.Text);
            int hieu = m - n;
            txtKetqua.Text = hieu.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSon.Text);
            int m = int.Parse(txtSom.Text);
            int tich = m * n;
            txtKetqua.Text = tich.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSon.Text);
            int m = int.Parse(txtSom.Text);
            try
            {
                int thuong = m / n;
                txtKetqua.Text = thuong.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
           
        }
    }
}
