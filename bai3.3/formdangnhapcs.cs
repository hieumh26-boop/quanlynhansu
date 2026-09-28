using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bai3._3
{
    public partial class formdangnhapcs : Form
    {
        public formdangnhapcs()
        {
            InitializeComponent();
        }

        private void btdn_Click(object sender, EventArgs e)
        {
            
            if(tbten.Text=="hieu"&&tbmk.Text=="123")
            {
                this.DialogResult = DialogResult.OK;
               
            }
            else
            {
                MessageBox.Show("looix");
            }
        }
    }
}
