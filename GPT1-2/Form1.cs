namespace GPT1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private float A;
        private float B;
        private float C;
        private bool kiemtrab1()
        {
            try
            {
                float a = float.Parse(tba.Text);
                float b = float.Parse(tbb.Text);
                this.A = a;
                this.B = b;
                return true;
            }
            catch
            {
                MessageBox.Show("looix");
                return false;
            }
        }
        private bool kiemtrab2()
        {
            try
            {
                if (this.A == 0)
                {
                    MessageBox.Show("looix");
                    return false;
                }
                else
                {
                    float c = float.Parse(tbc.Text);
                    return true;
                }
            }
            catch
            {
                MessageBox.Show("looix");
                return false;
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbb1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbb1.Checked && cbb2.Checked)
            {
                MessageBox.Show("looix");
                

            }
            else if (cbb1.Checked == true)
            {
                tbc.Enabled = false;
                tbx2.Enabled = false;
                
            }
            else 
            {
                tbc.Enabled = true;
                tbx2.Enabled = true;
                
            }
        }
        private void cbb2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbb1.Checked && cbb2.Checked)
            {

                MessageBox.Show("looix");
                
            }
            else
            {
                tbc.Enabled = true;
                tbx2.Enabled = true;
                

            }
        }

        private void btt_Click(object sender, EventArgs e)
        {
            if (cbb1.Checked)
            {
                if (kiemtrab1())
                {
                    float x = (-this.B) / this.A;
                    tbx1.Text = x.ToString();
                }

            }
            if (cbb2.Checked)
            {
                if (kiemtrab1() && kiemtrab2())
                {
                    double dt = this.B * this.B - (4 * this.A * this.C);
                    if (dt < 0)
                    {
                        MessageBox.Show("Pt vo nghiem");
                    }
                    else if (dt == 0)
                    {
                        float x1, x2;
                        x1 = x2 = (-this.B) / 2 * this.A;
                        tbx2.Text = tbx1.Text = x1.ToString();
                    }
                    else if (dt > 0)
                    {
                        float x1, x2;
                        x1 = ((-this.B) + (float)Math.Sqrt(dt)) / 2 * this.A;
                        tbx1.Text = x1.ToString();
                        x2 = ((-this.B) - (float)Math.Sqrt(dt)) / 2 * this.A;
                        tbx2.Text = x2.ToString();
                    }
                }
            }
        }

        private void btx_Click(object sender, EventArgs e)
        {
            tba.Clear();
            tbb.Clear();
            tbc.Clear();
            tbx1.Clear();
            tbx2.Clear();

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
