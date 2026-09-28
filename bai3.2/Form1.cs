using System.Data;
namespace bai3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mot_Click(object sender, EventArgs e)
        {
            tbcp.Text += "1";

        }

        private void hai_Click(object sender, EventArgs e)
        {
            tbcp.Text += "2";
        }

        private void ba_Click(object sender, EventArgs e)
        {
            tbcp.Text += "3";
        }

        private void bon_Click(object sender, EventArgs e)
        {
            tbcp.Text += "4";
        }

        private void lam_Click(object sender, EventArgs e)
        {
            tbcp.Text += "5";
        }

        private void sau_Click(object sender, EventArgs e)
        {
            tbcp.Text += "6";
        }

        private void bay_Click(object sender, EventArgs e)
        {
            tbcp.Text += "7";
        }

        private void tam_Click(object sender, EventArgs e)
        {
            tbcp.Text += "8";
        }

        private void chin_Click(object sender, EventArgs e)
        {
            tbcp.Text += "9";
        }

        private void ko_Click(object sender, EventArgs e)
        {
            tbcp.Text += "0";
        }

        private void cong_Click(object sender, EventArgs e)
        {
            tbcp.Text += "+";
        }

        private void tru_Click(object sender, EventArgs e)
        {
            tbcp.Text += "-";
        }

        private void nhan_Click(object sender, EventArgs e)
        {
            tbcp.Text += "*";
        }

        private void chia_Click(object sender, EventArgs e)
        {
            tbcp.Text += "/";
        }

        private void dapan_Click(object sender, EventArgs e)
        {
            DataTable cp = new DataTable();
            Object kq;
            kq = cp.Compute(tbcp.Text, "");
            MessageBox.Show($"{kq}");

        }

        private void xoa_Click(object sender, EventArgs e)
        {

        }
    }
}
