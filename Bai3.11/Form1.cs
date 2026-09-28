namespace Bai3._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbht_TextChanged(object sender, EventArgs e)
        {

        }

        private void btdk_Click(object sender, EventArgs e)
        {
            string ngay = nt.Text;
            MessageBox.Show($"thí sinh {tbht.Text} sinh ngày {ngay} trình độ học vấn: {cbhv.Text} đăng kí khóa học");
        }
    }
}
