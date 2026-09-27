namespace dangnhap
{
    partial class taotaikhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbtdnm = new TextBox();
            tbmkm = new TextBox();
            tbxnmk = new TextBox();
            label4 = new Label();
            btxn = new Button();
            btt2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 74);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 144);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(231, 9);
            label3.Name = "label3";
            label3.Size = new Size(308, 46);
            label3.TabIndex = 2;
            label3.Text = "Tạo tài khoản mới";
            // 
            // tbtdnm
            // 
            tbtdnm.Location = new Point(231, 74);
            tbtdnm.Name = "tbtdnm";
            tbtdnm.Size = new Size(308, 27);
            tbtdnm.TabIndex = 3;
            // 
            // tbmkm
            // 
            tbmkm.Location = new Point(231, 137);
            tbmkm.Name = "tbmkm";
            tbmkm.Size = new Size(308, 27);
            tbmkm.TabIndex = 4;
            // 
            // tbxnmk
            // 
            tbxnmk.Location = new Point(231, 202);
            tbxnmk.Name = "tbxnmk";
            tbxnmk.Size = new Size(308, 27);
            tbxnmk.TabIndex = 6;
            tbxnmk.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 209);
            label4.Name = "label4";
            label4.Size = new Size(137, 20);
            label4.TabIndex = 5;
            label4.Text = "Xác nhận mật khẩu:";
            // 
            // btxn
            // 
            btxn.Location = new Point(231, 276);
            btxn.Name = "btxn";
            btxn.Size = new Size(94, 29);
            btxn.TabIndex = 7;
            btxn.Text = "xác nhận";
            btxn.UseVisualStyleBackColor = true;
            btxn.Click += btxn_Click;
            // 
            // btt2
            // 
            btt2.Location = new Point(445, 276);
            btt2.Name = "btt2";
            btt2.Size = new Size(94, 29);
            btt2.TabIndex = 8;
            btt2.Text = "Thoát";
            btt2.UseVisualStyleBackColor = true;
            btt2.Click += btt2_Click;
            // 
            // taotaikhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(btt2);
            Controls.Add(btxn);
            Controls.Add(tbxnmk);
            Controls.Add(label4);
            Controls.Add(tbmkm);
            Controls.Add(tbtdnm);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "taotaikhoan";
            Text = "taotaikhoan";
            Load += taotaikhoan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbtdnm;
        private TextBox tbmkm;
        private TextBox tbxnmk;
        private Label label4;
        private Button btxn;
        private Button btt2;
    }
}