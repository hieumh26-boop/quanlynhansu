
using Microsoft.Data.SqlClient;
using System.Data;

namespace dangnhap
{
    public partial class formdangnhap : Form
    {
        public formdangnhap()
        {
            InitializeComponent();
            //SqlConnection conn = new SqlConnection(connectionString);

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            tbmk.PasswordChar = '*';
        }


        private void btc_Click(object sender, EventArgs e)
        {
                string dulieudangnhap = "SELECT COUNT(*) FROM csdl_dangnhap WHERE [tên đăng nhập]=@tdn AND [mật khẩu]=@mk";
                using (SqlConnection conn = new SqlConnection(dungchung.connectionString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand lenh = new SqlCommand(dulieudangnhap, conn);
                        string ten = tbtdn.Text.Trim();
                        string pass = tbmk.Text.Trim();
                        lenh.Parameters.AddWithValue("@tdn", ten);
                        lenh.Parameters.AddWithValue("@mk", pass);
                        // truy vấn= ống
                        //SqlDataAdapter ong = new SqlDataAdapter(dulieudangnhap, conn);
                        //chứa thông tin ống đưa vào
                        //DataTable thung = new DataTable();
                        //ong.Fill(thung);
                        //lệnh

                        //SqlDataReader reader = lenh.ExecuteReader();


                        int kt = Convert.ToInt32(lenh.ExecuteScalar());

                        if (kt > 0)
                        {
                            MessageBox.Show("Thanh cong");
                        }
                        else
                        {
                            MessageBox.Show("sai thông tin");
                        }
                        if (tbtdn.Text is null || tbmk.Text is null)
                        {
                            MessageBox.Show("Không được để trống");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(" " + ex.Message);
                    }

                }
            }
        private void btdn_Click(object sender, EventArgs e)
        {




        }

        private void tbtdn_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbamk_CheckedChanged(object sender, EventArgs e)
        {

            if (cbamk.Checked)
            {
                tbmk.PasswordChar = '\0';
                cbamk.Image = global::quanlynhansu.Properties.Resources.matmo;
            }
            else
            {
                tbmk.PasswordChar = '*';
                cbamk.Image = global::quanlynhansu.Properties.Resources.mătdong;
            }
        }

        private void btttkm_Click(object sender, EventArgs e)
        {
            this.Hide();
            taotaikhoan ttk = new taotaikhoan();
            ttk.ShowDialog();
            this.Close();
            //biết dùng r
        }
    }
}
