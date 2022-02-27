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
    public partial class frmUocboi : Form
    {
       
        public frmUocboi()
        {
            InitializeComponent();
            rbtnUSCLN.Checked = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtKetqua.Text = "";
            rbtnBSCNN.Checked = false;
            rbtnUSCLN.Checked = false;
        }
        private int USCLN(int a, int b)
        {
            if (b == 0) return a;
            return USCLN(b, a % b);
        }

        private int BSCNN(int a, int b)
        {
            return (a * b) / USCLN(a, b);
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            if (rbtnBSCNN.Checked) txtKetqua.Text = BSCNN(a, b).ToString();
            else txtKetqua.Text = USCLN(a, b).ToString();
        }
    }
}
