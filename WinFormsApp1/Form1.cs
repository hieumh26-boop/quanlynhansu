using System;
using static System.Math;
using System.Data;
using System.Text;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private float a;
        private float b;
        private float c;
        private float kq;
        private bool kiemtra()
        {
            try
            {
                var soa = new DataTable().Compute(osoa.Text, null);
                var sob = new DataTable().Compute(osob.Text, null);
                var soc = new DataTable().Compute(osoc.Text, null);
                var sokq = new DataTable().Compute(sotong.Text, null);
                bool kta = float.TryParse(soa?.ToString(), out float A);
                bool ktb = float.TryParse(sob?.ToString(), out float B);
                bool ktc = float.TryParse(soc?.ToString(), out float C);
                bool ktkq = float.TryParse(sokq?.ToString(), out float KQ);
                if (float.IsNaN(A) || float.IsNaN(B) || float.IsNaN(C) || float.IsNaN(KQ) || float.IsInfinity(A) || float.IsInfinity(B) || float.IsInfinity(C) || float.IsInfinity(KQ) || !kta || !ktb || !ktc || !ktkq)
                {
                    MessageBox.Show("looix");
                    return false;
                }
                this.a = A;
                this.b = B;
                this.c = C;
                this.kq = KQ;
                return true;
            }

            catch
            {
                MessageBox.Show("looix");
                return false;
            }
        }
        private float tinhdelta()
        {
            float dt = this.b * this.b - 4 * this.a * this.c;
            return (dt);
        }
        private void tinhth()
        {

            if (tinhdelta() == 0)
            {
                float x = (-this.b) / (2 * this.a);
                x1.Text = x.ToString();
                x2.Text = x.ToString();
            }
            else if (tinhdelta() > 0)
            {
                double x = ((-this.b) + Math.Sqrt(tinhdelta())) / (2 * this.a);
                x1.Text = x.ToString();
                double xx = ((-this.b) - Math.Sqrt(tinhdelta())) / (2 * this.a);
                x2.Text = xx.ToString();
            }
            else if (tinhdelta() < 0)
            {
                MessageBox.Show("Phương trình vô nghiệm");
            }
            return;
        }
        private void tinh_Click(object sender, EventArgs e)
        {

            if (kiemtra())
            {
                tinhth();
            }

        }
        private void pt1_CheckedChanged(object sender, EventArgs e)
        {

            osoa.Enabled = false;


        }
        private void pt2_CheckedChanged(object sender, EventArgs e)
        {


            if (kiemtra())
            {
                tinhth();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void osob_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void x1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
