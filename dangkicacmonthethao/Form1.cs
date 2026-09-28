using System.Linq;
namespace dangkicacmonthethao

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

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ctt_Click(object sender, EventArgs e)
        {
            try
            {
                box2.Items.AddRange(box1.Items);
                box1.Items.Clear();
            }

            catch
            {
                MessageBox.Show("Looix");
            }
        }

        private void ctp_Click(object sender, EventArgs e)
        {
            try
            {
                box2.Items.Add(box1.Items[0]);
                box1.Items.Remove(box1.Items[0]);
            }
            catch
            {
                MessageBox.Show("Looix");
            }
        }

        private void btp_Click(object sender, EventArgs e)
        {
            try
            {
                box1.Items.Add(box2.Items[0]);
                box2.Items.Remove(box2.Items[0]);
            }
            catch
            {
                MessageBox.Show("Looix");
            }
        }

        private void btt_Click(object sender, EventArgs e)
        {
            try
            {
                box1.Items.AddRange(box2.Items);
                box2.Items.Clear();
            }
            catch
            {
                MessageBox.Show("Looix");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string nguoi = ndk.Text;
            string thoigian = dk.Text;
            List<string> dsmon = new List<string>();
            foreach (var item in box2.Items)
            {
                dsmon.Add(item.ToString());
            }
            string cacmon = string.Join(",", dsmon);
            textBox1.Text = $"nguoi dang ki:{nguoi} \r\n" +
                $"\nthoi gian dang ky:{thoigian}\r\n" +
                $"\ncac mon da da chon:\r\n{cacmon}";

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            box2.ClearSelected();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dk_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
