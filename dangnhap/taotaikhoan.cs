using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dangnhap
{
    public partial class taotaikhoan : Form
    {

        public taotaikhoan()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btxn_Click(object sender, EventArgs e)
        {
            string themtaikhoan = "INSERT INTO csdl_dangnhap " +
                        "VALUES(@tendn,@mk)";
            using (SqlConnection conn = new SqlConnection(dungchung.connectionString))
            {

                using (var lenh = new SqlCommand(themtaikhoan, conn))
                {
                    lenh.Parameters.Add("@tendn", SqlDbType.NVarChar, 50).Value = tbtdnm.Text;
                    lenh.Parameters.Add("@mk", SqlDbType.NVarChar, 50).Value = tbmkm.Text;
                    conn.Open();
                    int kt = lenh.ExecuteNonQuery();
                    if (kt > 0)
                    {
                        MessageBox.Show("Tạo tài khoản thành công");
                    }
                    else
                    {
                        MessageBox.Show("Looix");
                    }
                    if (tbmkm.Text != tbxnmk.Text)
                    {
                        MessageBox.Show("Sai mật khẩu");
                    }
                }
            }
        }

        private void btt2_Click(object sender, EventArgs e)
        {
            this.Hide();
            formdangnhap dn = new formdangnhap();
            dn.ShowDialog();
            this.Close();

        }

        private void taotaikhoan_Load(object sender, EventArgs e)
        {

        }
    }
}
