namespace tesst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Toan_CheckedChanged(object sender, EventArgs e)
        {
            if (!Toan.Checked)
            {
                MessageBox.Show("Bạn vừa bỏ check môn toán");
            }
        }
        private void Van_CheckedChanged(object sender, EventArgs e)
        {
            if (!Van.Checked)
            {
                MessageBox.Show("Bạn vừa bỏ check môn MCK");
            }
        }


        private void dk_Click(object sender, EventArgs e)
        {
            string tbmonhoc = ("Bạn đã chọn môn học\n");
            int kt = 0;
            if (Toan.Checked)
            {
                tbmonhoc += "Toán.";
                tbmonhoc += " số tiết: ";
                tbmonhoc += ds.Text;
                kt = 1;
            }
            if (Van.Checked)
            {
                tbmonhoc += "\nMCK.";
                tbmonhoc += " số tiết: ";
                tbmonhoc += dss.Text;

                kt = 1;
            }
            if (kt == 1)
            {
                MessageBox.Show(tbmonhoc);
            }
            else
            {
                MessageBox.Show("Chưa chonnj môn chi ");
            }
            if (ds.Text == "đang mưa rồi")
            {
                MessageBox.Show("nổ r");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToString("dddd/mmmm/yy"));
        }
    }
}
