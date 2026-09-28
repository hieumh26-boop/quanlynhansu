namespace bai3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dssv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dssv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dssv.Row.Add("tt", "75", "26");
        }
    }
}
